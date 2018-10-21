﻿using System;
using TestFlightAPI;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace TestFlightCore
{
    public class TestFlightRnDTeam
    {
        public float Points { get; set; }

        public float CostFactor { get; set; }

        public float MaxData { get; set; }

        public float PartRnDRate { get; set; }

        public float PartRnDCost { get; set; }

        public float Cost
        {
            get
            {
                return Points * CostFactor;
            }
        }

        public string PartInResearch { get; set; }

        public bool ResearchActive { get; set; }

        internal void Log(string message)
        {
            bool debug = TestFlightManagerScenario.Instance.userSettings.debugLog;
            message = "TestFlightRnDTeam: " + message;
            TestFlightUtil.Log(message, debug);
        }

        public TestFlightRnDTeam(float points, float costFactor)
        {
            Points = points;
            CostFactor = costFactor;
            PartInResearch = "";
            ResearchActive = false;
            Log("New team started");
        }

        /// <summary>
        /// Updates the research on the team's current part
        /// </summary>
        /// <returns>The amount of du added to the part this update.</returns>
        public float UpdateResearch(float normalizedTime, float currentPartData)
        {
            if (PartInResearch != "" && ResearchActive)
            {
                float pointsForTick = Points * normalizedTime * PartRnDRate;
                pointsForTick = Mathf.Min(pointsForTick, MaxData - currentPartData);
                float costForTick = Cost * normalizedTime * PartRnDCost;
                Log("Points " + pointsForTick + ", Cost " + costForTick);
                if (HighLogic.CurrentGame.Mode == Game.Modes.CAREER)
                {
                    CurrencyModifierQuery query = CurrencyModifierQuery.RunQuery(TransactionReasons.RnDPartPurchase, -costForTick, 0f, 0f);
                    float totalCost = query.GetInput(Currency.Funds) + query.GetEffectDelta(Currency.Funds);
                    Log("Total cost " + totalCost);
                    if (totalCost < Funding.Instance.Funds)
                    {
                        Log("Subtracting cost...");
                        Funding.Instance.AddFunds(totalCost, TransactionReasons.RnDPartPurchase);
                        return pointsForTick;
                    }
                    else
                    {
                        return 0f;
                    }
                }
                else
                    return pointsForTick;
            }
            return 0f;
        }
    }

    public struct TestFlightRNDTeamSettings
    {
        public float points;
        public float costFactor;
    }

    [KSPScenario(ScenarioCreationOptions.AddToAllGames, 
        new GameScenes[]
        { 
            GameScenes.FLIGHT,
            GameScenes.EDITOR,
            GameScenes.SPACECENTER,
            GameScenes.TRACKSTATION
        }
    )]
    public class TestFlightRnDScenario : ScenarioModule
    {
        public static TestFlightRnDScenario Instance { get; private set; }

        public bool isReady = false;

        protected TestFlightManagerScenario tfScenario = null;
        protected List<TestFlightRnDTeam> availableTeams = null;
        protected Dictionary<string, TestFlightRnDTeam> activeTeams = null;
        protected List<string> teamsToStop = null;
        protected Dictionary<string, TestFlightRnDTeam>.Enumerator teamsEnumerator;

        [KSPField(isPersistant = true)]
        protected double lastUpdateTime = 0f;

        // Config settings
        public double updateFrequency = 86400d;
        List<TestFlightRNDTeamSettings> teamSettings;


        internal void Log(string message)
        {
            bool debug = TestFlightManagerScenario.Instance.userSettings.debugLog;
            message = "TestFlightRnDScenario: " + message;
            TestFlightUtil.Log(message, debug);
        }

        public override void OnAwake()
        {
            Log("OnAwake");
            teamsToStop = new List<string>();
            teamSettings = new List<TestFlightRNDTeamSettings>();
            ConfigNode node = GameDatabase.Instance.GetConfigNode("TFRNDSETTINGS");
            if (node != null)
            {
                node.TryGetValue("updateFrequency", ref updateFrequency);
                if (node.HasNode("TEAM"))
                {
                    ConfigNode[] teamNodes = node.GetNodes("TEAM");
                    foreach (ConfigNode teamNode in teamNodes)
                    {
                        TestFlightRNDTeamSettings team = new TestFlightRNDTeamSettings();
                        team.points = 100f;
                        team.costFactor = 1.0f;
                        teamNode.TryGetValue("points", ref team.points);
                        teamNode.TryGetValue("costFactor", ref team.costFactor);
                        teamSettings.Add(team);
                    }
                }
                else
                {
                    TestFlightRNDTeamSettings team = new TestFlightRNDTeamSettings();
                    team.points = 100f;
                    team.costFactor = 1.0f;
                    teamSettings.Add(team);
                    team.points = 125f;
                    team.costFactor = 1.5f;
                    teamSettings.Add(team);
                    team.points = 150f;
                    team.costFactor = 2.0f;
                    teamSettings.Add(team);
                }
            }
            else
            {
                updateFrequency = 86400d;
                TestFlightRNDTeamSettings team = new TestFlightRNDTeamSettings();
                team.points = 100f;
                team.costFactor = 1.0f;
                teamSettings.Add(team);
                team.points = 125f;
                team.costFactor = 1.5f;
                teamSettings.Add(team);
                team.points = 150f;
                team.costFactor = 2.0f;
                teamSettings.Add(team);
            }
        }

        public void Start()
        {
            Log("RnD Start");
            StartCoroutine("ConnectToScenario");
        }

        public void Update()
        {
            if (TestFlightManagerScenario.Instance == null)
                return;

            if (!TestFlightManagerScenario.Instance.SettingsEnabled)
                return;
            
            double currentTime = Planetarium.GetUniversalTime();
            teamsToStop.Clear();
            if (currentTime - lastUpdateTime >= updateFrequency)
            {
                float normalizedTime = (float)((currentTime - lastUpdateTime) / updateFrequency);
                Log("Doing research update, normalized time " + normalizedTime);
                lastUpdateTime = currentTime;
                if (activeTeams == null || activeTeams.Count <= 0)
                    return;
                teamsEnumerator = activeTeams.GetEnumerator();
                KeyValuePair<string, TestFlightRnDTeam> entry;
                while (teamsEnumerator.MoveNext())
                {
                    entry = teamsEnumerator.Current;
                    if (entry.Value.PartInResearch != "" && entry.Value.ResearchActive)
                    {
                        float partCurrentData = tfScenario.GetFlightDataForPartName(entry.Value.PartInResearch);
                        if (partCurrentData >= entry.Value.MaxData)
                        {
                            Log("Part " + entry.Value.PartInResearch + " has reached maximum RnD data.  Removing research automatically");
                            teamsToStop.Add(entry.Key);
                        }
                        else
                        {
                            float partData = entry.Value.UpdateResearch(normalizedTime, partCurrentData);
                            Log("Research tick for part " + entry.Value.PartInResearch + " yielded " + partData + "du");
                            if (partData > 0)
                            {
                                TestFlightManagerScenario.Instance.AddFlightDataForPartName(entry.Value.PartInResearch, partData);
                            }
                        }
                    }
                }
                if (teamsToStop.Count > 0)
                {
                    for (int i = 0; i < teamsToStop.Count; i++)
                    {
                        activeTeams.Remove(teamsToStop[i]);
                    }
                }
            }
        }

        IEnumerator ConnectToScenario()
        {
            while (TestFlightManagerScenario.Instance == null)
            {
                yield return null;
            }

            tfScenario = TestFlightManagerScenario.Instance;
            while (!tfScenario.isReady)
            {
                yield return null;
            }
            Startup();
        }

        public void Startup()
        {
            CreateTeams();
            isReady = true;
            Instance = this;
        }

        public void CreateTeams()
        {
            if (availableTeams != null)
                return;
            
            availableTeams = new List<TestFlightRnDTeam>();
            if (teamSettings == null)
                return;
            
            foreach (TestFlightRNDTeamSettings team in teamSettings)
            {
                availableTeams.Add(new TestFlightRnDTeam(team.points, team.costFactor));
            }

            if (activeTeams == null)
                activeTeams = new Dictionary<string, TestFlightRnDTeam>();
        }

        public void AddResearchTeam(Part part, string alias, int team)
        {
            Log(String.Format("Assign team #{0} to part", team));

            if (IsPartBeingResearched(alias))
                return;

            ITestFlightCore core = TestFlightUtil.GetCore(part, alias);
            if (core == null)
                return;

            if (TestFlightManagerScenario.Instance == null)
                return;

            if (!TestFlightManagerScenario.Instance.SettingsEnabled)
                return;

            if (availableTeams == null)
                CreateTeams();
            
            if (team < availableTeams.Count)
            {
                float techTransfer = core.GetTechTransfer();
                if (techTransfer > 0f)
                    TestFlightManagerScenario.Instance.AddFlightDataForPartName(alias, techTransfer);
                TestFlightRnDTeam template = availableTeams[team];
                activeTeams.Add(alias, new TestFlightRnDTeam(template.Points, template.CostFactor));
                activeTeams[alias].PartInResearch = alias;
                activeTeams[alias].MaxData = core.GetMaximumRnDData() + techTransfer;
                activeTeams[alias].PartRnDCost = core.GetRnDCost();
                activeTeams[alias].PartRnDRate = core.GetRnDRate();
                activeTeams[alias].ResearchActive = true;
                Log(String.Format("Team #{0} has been assigned to part {1}", team, alias));
            }
            else
            {
                Log(String.Format("Team #{0} is not valid.  There are {1} teams.", team, availableTeams.Count));
            }
            Log(String.Format("New active team count is {0}", activeTeams.Count));
        }

        public void RemoveResearch(string partName)
        {
            if (activeTeams == null)
                return;
            
            activeTeams.Remove(partName);
        }

        public bool IsPartBeingResearched(string partName)
        {
            if (activeTeams == null)
                return false;
            
            return activeTeams.ContainsKey(partName);
        }

        public List<string> GetPartsInResearch()
        {
            if (activeTeams == null)
                return null;
            
            List<string> parts = new List<string>(activeTeams.Keys);
            return parts;
        }

        public bool GetPartResearchState(string partName)
        {
            if (!IsPartBeingResearched(partName))
                return false;

            return activeTeams[partName].ResearchActive;
        }

        public void SetPartResearchState(string partName, bool researchActive)
        {
            if (activeTeams.ContainsKey(partName))
            {
                activeTeams[partName].ResearchActive = researchActive;
            }
        }

        public List<TestFlightRNDTeamSettings> GetAvailableTeams()
        {
            return teamSettings;
        }

        public override void OnLoad(ConfigNode node)
        {
            base.OnLoad(node);
            if (node.HasNode("TESTFLIGHT_RNDTEAM"))
            {
                if (activeTeams == null)
                    activeTeams = new Dictionary<string, TestFlightRnDTeam>();
                
                foreach (ConfigNode teamNode in node.GetNodes("TESTFLIGHT_RNDTEAM"))
                {
                    string partName = teamNode.GetValue("PartInResearch");
                    if (partName != null && partName != "")
                    {
                        float points = 100f;
                        float costFactor = 1.0f;
                        teamNode.TryGetValue("Points", ref points);
                        teamNode.TryGetValue("CostFactor", ref costFactor);
                        activeTeams.Add(partName, new TestFlightRnDTeam(points, costFactor));
                        activeTeams[partName].PartInResearch = partName;
                        activeTeams[partName].MaxData = float.Parse(teamNode.GetValue("MaxData"));
                        activeTeams[partName].PartRnDCost = float.Parse(teamNode.GetValue("PartRnDCost"));
                        activeTeams[partName].PartRnDRate = float.Parse(teamNode.GetValue("PartRnDRate"));
                        activeTeams[partName].ResearchActive = bool.Parse(teamNode.GetValue("ResearchActive"));
                    }
                }
            }
        }

        public override void OnSave(ConfigNode node)
        {
            base.OnSave(node);

            if (activeTeams == null)
            {
                return;
            }
            
            if (activeTeams.Count > 0)
            {
                foreach (KeyValuePair<string, TestFlightRnDTeam> entry in activeTeams)
                {
                    Log(String.Format("Saving team researching part {0}", entry.Value.PartInResearch));
                    ConfigNode teamNode = node.AddNode("TESTFLIGHT_RNDTEAM");
                    teamNode.AddValue("Points", entry.Value.Points);
                    teamNode.AddValue("CostFactor", entry.Value.CostFactor);
                    teamNode.AddValue("PartInResearch", entry.Value.PartInResearch);
                    teamNode.AddValue("MaxData", entry.Value.MaxData);
                    teamNode.AddValue("PartRnDCost", entry.Value.PartRnDCost);
                    teamNode.AddValue("PartRnDRate", entry.Value.PartRnDRate);
                    teamNode.AddValue("ResearchActive", entry.Value.ResearchActive);
                }
            }
        }
    }
}

