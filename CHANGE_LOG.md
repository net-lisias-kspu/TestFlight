# Test Flight :: Change log

* 2016-0502: 1.6.0.1 (jwvanderbeck) for KSP 1.1.2
	+ 1.6.0.1
	+ KSP Version
	+ KSP 1.1.2
	+ Changes
		- Recompiled for RealFuels v11.0 for KSP 1.1.2
* 2016-0501: 1.6.0.0 (jwvanderbeck) for KSP 1.1.2
	+ 1.6.0.0
	+ KSP Version
	+ KSP 1.1.2
	+ Changes
	+ None.  This release is v1.5.5 compiled for KSP 1.1.2
* 2016-0430: 1.5.5.0 (jwvanderbeck) for KSP 1.0.5
	+ 1.5.5.0
	+ KSP Version
	+ KSP 1.0.5
	+ Highlights
		- New optional module for working with RealFuels.  This module will only load if RealFuels is present, and if found will allow TestFlight to inject burn times into the RF EngineConfig GUI in the editor.  This means you will be able to mouse over engine configs, even unlocked ones, and see the rated burn time for that config.
		- Multiple failures! TestFlight now allows multiple failures to stack up on a single part.  No more hoping for a "safe" failure that will block more dangerous ones.  The only limitation is a part can't have the same failure happen more than once.
		- Multiple core.  Configs can now place multiple `TestFlightCore` modules on a single part.  Additional TestFlight modules can also be added that work with particular cores.  Each will bind to the core with the same alias.  In short this allows for essentially virtual sub-parts on a given part.  So that if you have composite parts, like say a probe core that has modules for the probe, a built in antenna, and a science experiment, you can now have those show up as actual distinct parts in TestFlight.
		- TestFlight no longer handles repair functionality.  Parts can fail, and the TestFlight API has a call to instantly repair them, but does not itself provide any interface to the player for doing so.  The repair functionality in TestFlight was always rather bare bones, and did not really do the topic service.  Repair functionality is really a whole mode in itself and now it can be!  I may write a bare bones repair system to work with TestFlight in the future but it is my hope that someone will jump on this to make a really nice in depth repair system.
	+ Changes
			- FIX: Fix possible issue with adding burn times to RealFuels info if an existing description didn't already exist
			- CHANGE: Use KSPs own formatting for the timestamp in flight log
			- NEW: For parts with stack icons, TestFlight will now change the background of those icons when failures occur.  Orange = Minor failure, Red = Major failure.  More options for failure identification will be coming in the future
			- CHANGE-API: `TestFlightUtil.GetFullPartName` has been removed and is no longer available.  Every module should know its part name anyway
			- NEW: Tweakable menu will now display a R&D button for each activecore, distinguished by the Alias, and allow opening the R&D menu for that sub part directly.
			- NEW: Major refactor to allow for multiples cores on a single part, creating essentially virtual sub parts within one part.  This involves major API changes which need to be documented.
			- NEW-API: ITestFlightCore.Alias property returns the alias of the core configuration
			- NEW-API: Added overloaded TestFlightUtil.GetCost() method to retrieve an active core based on alias.
			- CHANGE: Engines now properly start their cycle at ignition rather than after clearing the tower.  NOTE: You will still not start accumulating data until the craft actually launches.
			- FIX: Don't allow multiple instances of the same failure.
			- NEW: Parts can now have multiple failures.  This means that after the initial failure on a part, the part can continue to receive other failures.  There is no hard limit on the number of failures that can accumulate on a part.
			- CHANGE: TestFlight no longer handles repairs, and all repair functionality has been removed.
			- NEW: Report rated burn time in pretty format, not just seconds.
			- NEW: For EngineCycle modules, add rated burn time to the RealFuels config descriptions, if RealFuels is installed
			- NEW-CONFIG: Added new property `engineConfig` to the `ITestFlightReliability_EngineCycle` module for use in RealFuels injection
			- NEW-API: TestFlight main assembly now identifies as KSPAssembly `TestFlight`
			- FIX: Fixed bug causing Editor Info window to display wrong amount of flight data units.
* 2016-0411: 1.5.4.4 (jwvanderbeck) for KSP 1.0.5
	+ 1.5.4.4
	+ KSP Version
	+ KSP 1.0.5
	+ Changes
		- FIX: Fix R&D teams eating up insane amount of funds due to no research having been active for very long times
* 2016-0409: 1.5.4.3 (jwvanderbeck) for KSP 1.0
	+ 1.5.4.3
	+ KSP Version
	+ KSP v1.0.5
	+ Changes
		- FIX: Fixed PluginDir not being created on fresh installs which would prevent any settings from being saved
* 2016-0402: 1.5.4.2 (jwvanderbeck) for KSP 1.0
	+ Hotfix
	+ KSP Version: 1.0.5
		- FIX: Fix major bug in FloatCurve handling that was causing TestFlightFailure_IgnitionFail and TestFlightReliability_EngineCycle to both not apply proper failure chances
* 2016-0402: 1.5.4.1.beta-2 (jwvanderbeck) for KSP 1.0 PRE-RELEASE
	+ FIX: Fix major bug in FloatCurve handling that was causing TestFlightFailure_IgnitionFail and TestFlightReliability_EngineCycle to both not apply proper failure chances
* 2016-0328: 1.5.4.0 (jwvanderbeck) for KSP 1.0
	+ 1.5.4.0
	+ Highlights
	+ The TestFlight R&D System is finally here!  It has been teased forever by the nonfunctional R&D tab seen in the TestFlight window in the KSC screen, but now it is finally implemented.
	+ The R&D system is an optional feature that allows you to spend funds and time to increase part reliability without actually flying them and risking _bad things_ happening.  Gaining data through flight will still often be quicker, but not as safe.  R&D will be safer but slower and cost funds.  The choice is yours.  Parts do have maximum R&D limits however, so while engineers can get you to a better reliability before flight testing, they won't get you all the way.
	+ R&D can be assigned to any supported part while in the editor constructing your vessel.  Simply right click on the part and click the `R&D Window` button to toggle the R&D window.  Here you can assign one of several teams to begin researching that part.  Choose the one that works for you, balancing time and cost.
	+ Every research cycle, which defaults to one day but may be changed by other mods, your part will receive flight data assigned to it by the research team, and funds will be subtracted.
	+ You can stop/pause/resume research at any time either in the editor or as a shortcut by using the R&D tab in the main KSC screen.  Research will also auto stop if the part reaches its maximum R&D level.
	+ In addition to the R&D system, I also took this time to redo how TestFlight information is displayed in the editor.  The old TF window in the editor is now gone, and is replaced by the new R&D window for assigning research and a new "Info Overlay" window which can give you detailed TestFlight information on any placed part with a simple Middle Click.
	+ Upgrade Notes
	+ Upgrading from 1.5.3.0 release to 1.5.4.0 release should not cause any issues.  If you are upgrading from a dev or beta version of 1.5.4.0, it is suggested that you first stop all R&D teams before upgrading.
	+ Changes
		- FIX: Fix editor info window not hiding properly
		- FIX: Fix editor info window not shrinking in size when changing parts or hiding the window
		- NEW: EngineCycle module now displays information on idle decayand thrust modifiers if applicable in the info window
		- FIX: Fixed a possible NRE in TestFlightRNDScenario load, as wellas making that code a bit more robust in the case of unexpected data.
		- FIX: Apply `rndRate` and `rndCost` to display in R&D window.  Fixes #136
		- FIX: Fixed internal burn time handling on TestFlightReliability_EngineCycle
		- FIX: Fixed major bug that was causing time handling to be truncated, causing part updates to happen less and less frequently the longer your save went on
		- FIX: Moved TestFlight settings file to PluginData so that it doesn't cause ModuleManager recaching when settings change.  Important Note: TestFlight will automatically migrate the settings file for you the first time, but it won't be able to clean up the old file.  Once migration happens you can freely delete the old file if desired.
		- FIX: Fixed to RND Teams getting reset due to a race condition during RND scenario load.
		- FIX: Fixed Editor R&D Window position not being properly read from settings on initial load.
		- NEW: Parts no longer can gain data while in the PRELAUNCH situation.  This means no more static test firing.  The new R&D system should be used instead if you don't want to risk parts on an actual flight.
		- NEW: Expanded Info window data for Core and Reliability modules
		- FIX: Major bug fix that was preventing pretty much all modules from properly attaching!
		- NEW: Placed parts in Editor now have a quick info overlay window that can be accessed by right clicking on the place part.  This info window will display TestFlight information on the part.
		- NEW-API:  TestFlight modules now all have an interface method for `GetTestFlightInfo` which is used to return data the module desires to be displayed in the Editor Info window
		- NEW-API: Interop changes now fire an event on the active Core module allowing for reactions to the change.
		- FIX: Fix duplicate _R&D Window_ buttons showing up in editor tweakables.
		- NEW: R&D Window in Editor now displays information on how the system works, how much teams cost and how many points they contribute
		- NEW: R&D settings can no be configured by other mods using Confignodes.  Place all settings in a node named “TFRNDSETTINGS”.`updateFrequency` is a double indicating how often the R&D teams tick. Value is in seconds and the default is 86400 or 1 day.
		- NEW: R&D Teams can be configured by mods using a Config node.  For each desired team add a node named “TEAM” under the main “TFRNDSETTINGS” node with the following properties: `points` indicates the amount of research points (directly mapped to data units) generated by the team per update.  Default is 100. `costFactor` indicates the cost per point of the research team. Defaults to 1.  Added ConfigNodeExtensions from @stupid_chris with license information.
		- NEW: TestFlight supported parts in the Editor now have a right click menu button _R&D Window_ which allows you to quickly open up a window to control research team allocation for the part.
		- NEW: TestFlight now has a new Research and Development feature.  This R&D System is optional, but allows you to trade off time and funds for increased part reliability.  Rather than risking failures during a mission with low reliability parts, you can instead assign engineering teams to work on the parts over time, slowly increasing the part reliability without risk.
		- NEW-CONFIG: New property added to `ITestFlightCore` to support R&D: `rndMaxData` defines the maximum amount of flight data that can be obtain by using engineering teams.  This is defined in absolute units and if not present, R&D ill cap out at 75% of the part's maximum data
		- NEW-CONFIG: New property added to `ITestFlightCore` to support R&D: `rndRate` defines the speed at which the part is research by engineering teams.  This is a multiplier against the number of points generated by a team each cycle and defaults to 1, IE no modification.
		- NEW-CONFIG: New property added to `ITestFlightCore` to support R&D: `rndCost` defines the cost at which the part is research by engineering teams.  This is a multiplier against the cost of the team each cycle and defaults to 1, IE no modification.
		- FIX: The following failures will re-apply themselves on loading a game: EnginePerformanceLoss, LockGimbal, ReducedMaxThrust, ResourceLeak
		- NEW: `TestFlightReliability_EngineCycle` can now optionally modify accumulated burn time based on the actual thrust output of the engine.  This is defined as a modifier curve using the FloatCurve `thrustModifier`
		- NEW: `TestFlightReliability_EngineCycle` can now optionally decaythe used burn time on an engine when the engine is turned off.  Can bedefined by using the property `idleDecayRate`.  This value is directlysubtracted from the engine's current burn time each second, so a valueof 1 would be an approximate 1:1 time decay.  This can optionally allowengines to have extended usage when shut off during coast periods.Note that this only kicks in if the engine is shut off (not ignited).
		- NEW: `TestFlightFailure_IgnitionFail` can now apply an additional modifier to the chance of ignition based on the number of previous ignitions used.  Use the FloatCurve `ingitionUseMultiplier`.  This is a straight multiplier and thus values below 1 will lower the chance of the engine igniting and values above 1 will increase the chances.
		- NEW: `TestFlightFailure_IgnitionFail` can now cause an additionalfailure to occur if the ignition fails.  The chance of this occurringcan be set in the property `additionalFailChance` and is a value 0-1f,with  default of 0.  If this additional failure triggers then theengine will receive one of the existing random failures assigned to thepart.
		- NEW-API: Add new property `Failed` to `ITestFlightFailure` interface.
		- FIX: Persist the failed state on a part
		- NEW: Add EngineModuleWrapper method to set the number of ignitions directly.
		- NEW: `ShutdownEngine` failure now also removes all ignitions from the engine.  They are restored is the failure is repaired.
		- NEW-API: Add method to EngineModuleWrapper to return the current number of ignitions on an engine. `int GetIgnitionCount()`
		- NEW-API: Added new functions to EngineModuleWrapper to Add and Remove ignitions from compatible engines. `void AddIgnitions(int numIgnitions)` and `void RemoveIgnitions(int numIgnitions)`  Passing < 0 to `RemoveIgnitions` will remove all ignitions on the engine.
* 2016-0311: 1.5.3-beta.1 (jwvanderbeck) for KSP 1.0 PRE-RELEASE
	+ NEW: New Failure module EnginePerformanceLoss causes the engine's Isp to degrade by an amount specified in the config property `ispMultiplier`.  A second property `ispMultiplierJitter` can be used to add some small extra random variance to the degredation
	+ Use aliased format for kspPartNames when coerced from blank string as it is cleaner.
		- NEW: TestFlightInterop now adds an intervop value named `kspPartName` which is theinternal KSP name of the underlying part.  This does not change.  Can be used in config queries and should be used instead of blank queries or queries with just part names.  `config = kspPartName = squadFoo`.
		- CHANGE: Internally, any empty configuration string is coercedinto `kspPartname = squadFoo` using the new interop value and theparsed part name.
		- FIX: If a part has starting flight data from the config, add that to the scenario data store when first initializing it.  Should fix issue with needing to record _past_ the startFlightData before it would stick.
		- NEW-API: Added `TestFlightPartData.AddValue` and overloaded versions for int, float, and double that do what it says on the tin.
		- NEW-API: Added `TestFlightPartData.ToggleValue` for bools
		- NEW-API: Added`TestFlightManagerScenario.AddFlightDataForPartName` helper function toadd to existing flight data for a part.
		- CHANGE-API: Renamed `TestFlightPartData.AddValue` to `TestFlightPartData.SetValue` following in accordance with the previous similar change to TestFlightManagerScenario which wraps these for convenience.
		- CHANGE: Removed persistence from `TestFlightCore.startFlightData`as it is not dynamic.
		- CHANGE: TestFlightFailure_ResourceLeak - Use System.Random from TestFlightCore instead of Unity's broken random.
		- CHANGE: All RealismOverhaul configs have been removed from TestFlight and are now managed and provided by Realism Overhaul directly.
		- CHANGE: TestFlight Realism Overhaul Config pack is no longer built or provided by TestFlight.Updated build process to omit RO configsUpdated Netkans (this also needs to be done with CKAN)
		- CHANGE: Removed Aerobee engine line from RealismOverhaul configs, as these configs now live in the RO project
		- NEW: Reliability modules for SkinTemperature and InternalTemperature
* 2016-0317: 1.5.3.0 (jwvanderbeck) for KSP 1.0
	+ NEW: New Failure module EnginePerformanceLoss causes the engine's Isp to degrade by an amount specified in the config property `ispMultiplier`.  A second property `ispMultiplierJitter` can be used to add some small extra random variance to the degredation
	+ NEW: TestFlightInterop now adds an intervop value named `kspPartName` which is the internal KSP name of the underlying part.  This does not change.  Can be used in config queries and should be used instead of blank queries or queries with just part names.  `config = kspPartName = squadFoo`.
	+ CHANGE: Internally, any empty configuration string is coerced into `kspPartname = squadFoo` using the new interop value and the parsed part name.
	+ FIX: If a part has starting flight data from the config, add that to the scenario data store when first initializing it.  Should fix issue with needing to record _past_ the startFlightData before it would stick.
	+ NEW-API: Added `TestFlightPartData.AddValue` and overloaded versions for int, float, and double that do what it says on the tin.
	+ NEW-API: Added `TestFlightPartData.ToggleValue` for bools
	+ NEW-API: Added`TestFlightManagerScenario.AddFlightDataForPartName` helper function to add to existing flight data for a part.
	+ CHANGE-API: Renamed `TestFlightPartData.AddValue` to `TestFlightPartData.SetValue` following in accordance with the previous similar change to TestFlightManagerScenario which wraps these for convenience.
	+ CHANGE: Removed persistence from `TestFlightCore.startFlightData`as it is not dynamic.
	+ CHANGE: TestFlightFailure_ResourceLeak - Use System.Random from TestFlightCore instead of Unity's broken random.
	+ CHANGE: All RealismOverhaul configs have been removed from TestFlight and are now managed and provided by Realism Overhaul directly.
	+ CHANGE: TestFlight Realism Overhaul Config pack is no longer built or provided by TestFlight.
	+ CHANGE: Removed Aerobee engine line from RealismOverhaul configs, as these configs now live in the RO project
	+ NEW: Reliability modules for SkinTemperature and InternalTemperature
* 2016-0308: 1.5.2.0 (jwvanderbeck) for KSP 1.0
	+ 1.5.2.0
	+ IMPORTANT
		- This release has some changes and fixes that can affect existing saves and .craft files.
		- A change to how part names are determined will cause some parts to be registered with a new name that no longer matches what might already be stored in the save file.  In this case those parts will reset to 0 data!
		- A fix to how data is persisted in the .craft files has been fixed.  This bug could cause saved .craft to not initialize properly and thus never gain any data from previous flights.  This bug has been fixed however the fix is not retroactive and thus will only affect new saved craft and not fix old ones.
	+ CHANGES
			- CHANGE: TestFlightReliability_DynamicPressure - Clamp evaluated dynamic pressure reliability curve to `TestFlightUtil.MIN_FAILURE_RATE`
			- CHANGE: DynamicPressure minimum modifer value now configurable
			- CHANGE: TestFlightContracts linked to latest version (1.9.7) of ContractConfigurator
			- CHANGE Support Passive RT antennas as well.
			- API CHANGE: `TestFlightScenario.AddValue` methods have been renamed to `SetValue` as that more accurately represents how they function (setting an absolute value).  New methods have been added to the Scenario called `AddValue` that do just that, taking the existing stored value and adding to it.  Obviously not available for `string` and `bool` types.
			- API NEW: Added `TestFlightScenario.ToggleValue(string key, booldefaultValue)`.  This method will either take the existing stored value and set the opposite (so false to true, true to false) or if there is no existing value it will set the `defaultValue`
			- FIX Part.name is unreliable. Use a corrected version of the part name (code borrowed from RealFuels) that should be reliable.
		- Spelling ftw
			- FIX: Fixed duplicate TestFlightInterop modules on some parts that could cause errors on the RL10x2 series and LR91-AJ series engines
			- NEW: Light bulb flickering failure
			- NEW: MaxQ reliability module to lower reliability at high Q
			- FIX: Science failures now have experimentID to support multiple experiments
			- CHANGE Start XLR11 at 0 data.
			- FIX Increase data rates for XLR11, XLR99.
			- CHANGE ResourceLeak now supports resource to leak "all"; persistence fixed, refactored to use leak lists.
			- FIX Update resource leaking to use fixed timesteps rather than realtime.
			- FIX Engine fixes. Flight Data Recorder (Engines) binds to first engine on the part. The failure modules grab all engines matching passed spec, defaulting to 'all' engines on the part. The wrapper is cleaned up and does not use scriptable objects anymore. Also fixed some KSPFielding and now don't recalculate dynamic pressure.
			- FIX: EngineModuleWrapper spam removed by properly treating ScriptableObject as Unity requires.  Because reasons.
			- FIX: XLR11, XLR99 configs to apply to all of them (use different MM pattern). Fix LR91 part matches for other LR91s.
			- CHANGE: Remove unneeded persistence flags.
			- FIX: Proper data initialization for saved .craft files.  NOTE: Fix is not retroactive and will only work properly on new saved craft.
			- FIX: Properly accumulate flightData when multiple parts with the same underlying part name are on a vessel.  Fixes #101
* 2016-0229: 1.5.1.0 (NathanKell) for KSP 1.0
	+ 1.5.1.0
		- FIX: Do a pass to further clean up burn times
		- NEW: Add new LR87-LH2 config.
		- FIX: Correct LR91 burn time cycles.
		- NEW: Add LR91-AJ-3; fix LR87/91 config names for next RO.
		- FIX:  Fix ignition pressure curves, remove Agena and LR89/105 configs (done in RO).
		- NEW: Add AJ10-early comments.
		- CHANGE: Update AJ10-early configs for new RO.
		- CHANGE: Update Examples.txt. Added example config for failures to FARControllableSurface module
* 2016-0225: 1.5.0.1 (anxcon) for KSP 1.0
	+ minor fix to avoid a possible issue
* 2016-0225: 1.5.0.0 (anxcon) for KSP 1.0
	+ NEW: Hands on research! A mechanic (available to cfg modders) to use part data as science discounts in tech tree nodes the part is present in.
	+ NEW: Failures for RemoteTech and parts using ModuleScienceExperiment
* 2015-1123: 1.4.0.2 (jwvanderbeck) for KSP 1.0
	+ TestFlight v1.4.0.2
		- FIX: Fixes Issue #82 LR-105 engine misconfigured in RO configs
		- NEW Configs: Added LR-91 (-5, -7, -9, -11, -11A models) configs to the FASA Gemini LR-91 model.  Thanks @stratochief66!
		- API Changed: `baseFailureRate` and `momentaryFailureRate`, as well as momentary failure rate modifiers are all treated internally as doubles now for extra precision with very small failure rates. All API calls utilizing any of these values now return and expect doubles.
		- NEW Configs: Added new property to TestFlightCore,
		- `failureRateModifier` which defaults to 1.  This is a flat, fixed,
		- modifier applied to the calculated baseFailureRate which can be used to
		- force smaller values than is possible normally due to 32 bit
		- restrictions in KSP.
			- NEW: In order to accommodate very small failure rates, the core
		- has been reworked to use 64 bit double precision floats internally.
		- This allows failure rates as low as .00000000000001.  However, KSP
		- itself will not persist doubles, only floats.  Further more, by their
		- very nature FloatCurves, which are used to define the failure rate
		- curves, have to be floats.  This means that while internally the
		- failure rate can be much lower than before, KSP will still only allow
		- you to specify failure rate values down to .0000001 (This is one
		- significant digit lower than previous).  In order to get even smaller
		- values than that, use the new property on TestFlightCore
		- `failureRateModifier` to force it even lower.  Setting both the
		- failureRate and the failureRateModifier to the smallest float value of
			- 0000001 will result in a calculated failureRate internally of the min
		- rate, .00000000000001
				- CHANGED Configs: Update RO configs for RO 10.0
				- Aerobee configs were renamed
				- RL, AJ, and LR no longer have a dash (Only the last was relevant here)
				- NEW: Recompiled for KSP v1.0.5
				- CHANGED: Updated ContractConfigurator to 1.8.1
				- NEW: Added support for lots of different parts thanks to the awesome work of @anxcon.  New part support includes: Avionics, Docking Rings, FAR Control Surfaces, Gimbals, Reaction Wheels, Solar Panels, Heat Shields and more! Major thanks to @anxcon
* 2015-1123: 1.4.0.1 (jwvanderbeck) for KSP 1.0 PRE-RELEASE
	+ TestFlight v1.4.0.0
		- FIX: Fixes Issue #82 LR-105 engine misconfigured in RO configs
		- NEW Configs: Added LR-91 (-5, -7, -9, -11, -11A models) configs to the FASA Gemini LR-91 model.  Thanks @stratochief66!
		- API Changed: `baseFailureRate` and `momentaryFailureRate`, as well as momentary failure rate modifiers are all treated internally as doubles now for extra precision with very small failure rates. All API calls utilizing any of these values now return and expect doubles.
		- NEW Configs: Added new property to TestFlightCore,
		- `failureRateModifier` which defaults to 1.  This is a flat, fixed,
		- modifier applied to the calculated baseFailureRate which can be used to
		- force smaller values than is possible normally due to 32 bit
		- restrictions in KSP.
			- NEW: In order to accommodate very small failure rates, the core
		- has been reworked to use 64 bit double precision floats internally.
		- This allows failure rates as low as .00000000000001.  However, KSP
		- itself will not persist doubles, only floats.  Further more, by their
		- very nature FloatCurves, which are used to define the failure rate
		- curves, have to be floats.  This means that while internally the
		- failure rate can be much lower than before, KSP will still only allow
		- you to specify failure rate values down to .0000001 (This is one
		- significant digit lower than previous).  In order to get even smaller
		- values than that, use the new property on TestFlightCore
		- `failureRateModifier` to force it even lower.  Setting both the
		- failureRate and the failureRateModifier to the smallest float value of
			- 0000001 will result in a calculated failureRate internally of the min
		- rate, .00000000000001
				- CHANGED Configs: Update RO configs for RO 10.0
				- Aerobee configs were renamed
				- RL, AJ, and LR no longer have a dash (Only the last was relevant here)
				- NEW: Recompiled for KSP v1.0.5
				- CHANGED: Updated ContractConfigurator to 1.8.1
				- NEW: Added support for lots of different parts thanks to the awesome work of @anxcon.  New part support includes: Avionics, Docking Rings, FAR Control Surfaces, Gimbals, Reaction Wheels, Solar Panels, Heat Shields and more! Major thanks to @anxcon
* 2015-1123: 1.4.0.0 (jwvanderbeck) for KSP 1.0 PRE-RELEASE
	+ TestFlight v1.4.0.0
		- FIX: Fixes Issue #82 LR-105 engine misconfigured in RO configs
		- NEW Configs: Added LR-91 (-5, -7, -9, -11, -11A models) configs to the FASA Gemini LR-91 model.  Thanks @stratochief66!
		- API Changed: `baseFailureRate` and `momentaryFailureRate`, as well as momentary failure rate modifiers are all treated internally as doubles now for extra precision with very small failure rates. All API calls utilizing any of these values now return and expect doubles.
		- NEW Configs: Added new property to TestFlightCore,
		- `failureRateModifier` which defaults to 1.  This is a flat, fixed,
		- modifier applied to the calculated baseFailureRate which can be used to
		- force smaller values than is possible normally due to 32 bit
		- restrictions in KSP.
			- NEW: In order to accommodate very small failure rates, the core
		- has been reworked to use 64 bit double precision floats internally.
		- This allows failure rates as low as .00000000000001.  However, KSP
		- itself will not persist doubles, only floats.  Further more, by their
		- very nature FloatCurves, which are used to define the failure rate
		- curves, have to be floats.  This means that while internally the
		- failure rate can be much lower than before, KSP will still only allow
		- you to specify failure rate values down to .0000001 (This is one
		- significant digit lower than previous).  In order to get even smaller
		- values than that, use the new property on TestFlightCore
		- `failureRateModifier` to force it even lower.  Setting both the
		- failureRate and the failureRateModifier to the smallest float value of
			- 0000001 will result in a calculated failureRate internally of the min
		- rate, .00000000000001
				- CHANGED Configs: Update RO configs for RO 10.0
				- Aerobee configs were renamed
				- RL, AJ, and LR no longer have a dash (Only the last was relevant here)
				- NEW: Recompiled for KSP v1.0.5
				- CHANGED: Updated ContractConfigurator to 1.8.1
				- NEW: Added support for lots of different parts thanks to the awesome work of @anxcon.  New part support includes: Avionics, Docking Rings, FAR Control Surfaces, Gimbals, Reaction Wheels, Solar Panels, Heat Shields and more! Major thanks to @anxcon
* 2015-0518: 1.3.1.1 (jwvanderbeck) for KSP 1.0
	+ Release 1.3 (v1.3.1.1)
	+ Change Log
		- FIX: Incorrect KSP version in AVC file
* 2015-0518: 1.3.1.0 (jwvanderbeck) for KSP 1.0
	+ Test Flight v1.3.1.0
	+ Highlights
		- KSP v1.0.2 Compatible
		- No more scope
	+ As of v1.3, the concept of flight scope has been removed form TestFlight.  This means that part reliability and flight data are universal.  Removal of scope reduced the complexity of the code, but more importantly opened up things for coming soon features that simply couldn't be done well while scope was there.  It made things too complex for the player.
		- ContractConfigurator Support
	+ TestFlight now supports ContractConfigurator by adding a new contract goal to gather flight data on a part.  This allows contract authors to add flight testing!  _NOTE:_ While the support is there, currently no contracts actually use it.
		- Stock Configs
	+ This version of TestFlight introduces some basic preliminary config files to support Stock parts for everyone who wanted to play with TestFlight but don't play RealismOverhaul.  More fleshed out configs will come later and i'm really hoping I can enlist some community help on these, as I personally don't play stock.
		- TestFlight Plugin, and Config Packs
	+ TestFlight is now distributed in pieces consisting of one ZIP file for the core plugin, without any configs, and then separate config packs, currently for RealismOverhaul and Stock.  _NOTE:_ Under this new model, you must make sure to download and extract both the core plugin and one config pack.
	+ There may be some initial hiccups on CKAN due to this change, as it isn't possible for me to test it 100% before releasing.  Any issues I will endeavor to fix as quickly as possible.  Please let me know if you run into any problems!
	+ Change Log
			- API: new API stubs for interrogating scenario data store
			- GAME-PLAY: The concept of '_scope_' no longer applies, and data and reliability is universal. This is a major change that paves the way for newer features coming soon.
			- CONFIGS - ALL: Updated reliability configs to use noscope format
			- NEW: ContractConfigurator support.  TestFlight now creates a new Contract goal for gaining flight data on a part.  This allows contract authors to incorporate flight testing into contracts.
			- FIX: Fixed data type errors in noscope api changes. Added data overloads for float, int, bool, and double
			- NEW: Property added to TestFlightCore `startFlightData` that can be used to indicate that a part should start with a given amount of existing flight data
			- NEW: TestFlightScenario available in all scenes
			- FIX: ContractConfigurator don’t try to validate part string during initial load, as we won’t have a scenario available then
			- FIX: ContractConfigurator only display data remaining if some data has been collected
			- KSP: Updated and compiled for KSP v1.0.0
			- NEW: TestFlight now distributed as multiple files, with a core Plugin Only distribution and multiple Config Packs, currently for RealismOverhaul and Stock.
			- FIX: If TestFlight title property is not defined or blank, use the part's stock title instead
			- FIX: Fix possible infinite loop when the TestFlightCore had a configuration without query in it
			- NEW: Allow any module to have a blank or undefined config. In such cases it is considered always active
			- CONFIGS - STOCK: Added RT5, RT10, BACC, and Kickback solid boosters
			- CONFIGS - STOCK: Added: LV-T30, LV-T45, LV-909, Poodle, Skipper, Mainsail liquid engines
			- CONFIGS - RO: WAC-Corporal and XLR11 engines start fully tested
			- CONFIGS - STOCK: Fixed incorrect configuration tags on stock solid engines
			- CONFIGS - STOCK: First tier stock liquid and solid engines start at max data
		- already researched
			- API: Added API to TestFlightManager for persisting arbitrary data for a save game
			- NEW: Added per save game settings
			- NEW: Parts can be set to always be at maximum flight data in a specific save game
			- NEW: TestFlight can be enabled or disabled on a per save game basis
			- FIX: When part’s start at MaxData they start at properly the maximum data defined by the  ReliabilityCurve and not some insane high value.
			- FIX: NREs caused by save game without existing data store
			- NEW: Added save game settings to the KSC level TestFlight settings window
			- FIX: Engines would continue gaining data when shutown. Engines now use finalThrust to determine running state
			- NEW: Added `maxData` property to TestFlightCore to indicate the maximum amount of flight data the part can obtain.
			- CONFIGS - STOCK: Added stock resource tank configs
			- NEW: Flight data caps out at `maxData` as defined by the TestFlightCore. Closes #68
			- CONFIGS - STOCK: Add maxData to all the stock engine configs
			- NEW: Added default savegame settings
			- API: Updated SaveData API to allow passing a default value to be used in the case where the saved data could not be found or converted to type
			- CONFIGS - RO: Added proper `maxData` lines to all existing RO engine configs (Thanks @NathanKell!)
			- CONFIGS - STOCK: Don't treat command pods with resources as resource tanks
			- FIX: Updated AV .version to KSP 1.0
			- NEW: Updated build system to include a version file for configs
			- NEW: Split core and config packs into separate netkans
			- FIX: Updated ReducedThrust code to work with FuelFlow (Reducing fuel flow results in loss of thrust) for KSP 1.0
			- NEW: Failure_ReducedMaxThrust now supports new KSP 1.0 engines as well as RF EngineSolver engines- Refactored EngineModuleWrapper to no longer split between ModuleEngines and ModuleEnginesFX, and to support new EngineSolverengines such as ModuleEnginesRF
			- FIX: No longer use FAR (when installed) to get atmospheric density, as KSP 1.0 has proper values now
			- NEW: Compiled for KS 1.0.2
			- NEW: Compiled for ContractorConfigurator 1.0.4
			- NEW: Failure_ResourceLeak is now more flexible in how the leak amounts are defined.  By default it functions as normal, however you can optionally specify values to be in percent of maximum resource capacity or percent of current resource level.  By adding the suffixes %t or %c respectively.
			- NEW: Added `calculatePerTick` property to Failure_ResourceLeak.  If set to `true` then any percent values will be re-calculated each tick.  If`false` then they will only be calculated initially at the time of failure.  Default values is `false`.
			- FIX: Leaked resources will no longer pull from other parts!
			- FIX: Proper lowercase check for failure module names. (Thanks @magico13!)
			- FIX: Catch situation where TriggerFailure() has no valid failures inthe list. (Thanks @magico13!)
			- NEW: Core.dataCap is now a float percentage rather than a hard number
			- NEW: Add API method GetMaximumFlightData() which returns the most amount of flight data possible to be gained on a part
			- FIX: Parse leak values as en-US format
* 2015-0517: 1.3.0.19 (jwvanderbeck) for KSP 1.0.2 PRE-RELEASE
	+ TestFlight v1.3 Experimental 13 (1.3.0.19)
	+ KSP 1.0.2 Compatible
	+ Important Note:
	+ Version 1.3 of TestFlight is potentially save-game breaking.  The underlying scenario data store has changed.  While v1.3 includes code to automatically upgrade previous 1.2 save games, it might not always work.
	+ Change Log
		- Parse leak amounts in en-US format
* 2015-0517: 1.3.0.18 (jwvanderbeck) for KSP 1.0.2 PRE-RELEASE
	+ TestFlight v1.3 Experimental 12 (1.3.0.18)
	+ KSP 1.0.2 Compatible
	+ Important Note:
	+ Version 1.3 of TestFlight is potentially save-game breaking.  The underlying scenario data store has changed.  While v1.3 includes code to automatically upgrade previous 1.2 save games, it might not always work.
	+ Change Log
		- Adding additional logging to TestFlightFailure_ResourceLeak
* 2015-0517: 1.3.0.17 (jwvanderbeck) for KSP 1.0.2 PRE-RELEASE
	+ TestFlight v1.3 Release Candidate 4 (1.3.0.17)
	+ KSP 1.0.2 Compatible
	+ Important Note:
	+ Version 1.3 of TestFlight is potentially save-game breaking.  The underlying scenario data store has changed.  While v1.3 includes code to automatically upgrade previous 1.2 save games, it might not always work.
	+ Change Log
		- NEW: Added API method `GetMaximumFlightData` to return the absolute maximum amount of flight data that may be gained on a part.
* 2015-0517: 1.3.0.16 (jwvanderbeck) for KSP 1.0.2 PRE-RELEASE
	+ TestFlight v1.3 Release Candidate 4 (1.3.0.16)
	+ KSP 1.0.2 Compatible
	+ Important Note:
	+ Version 1.3 of TestFlight is potentially save-game breaking.  The underlying scenario data store has changed.  While v1.3 includes code to automatically upgrade previous 1.2 save games, it might not always work.
	+ Change Log
		- NEW: Core.dataCap is now a float percentage rather than a fixed value
* 2015-0517: 1.3.0.15 (jwvanderbeck) for KSP 1.0.2 PRE-RELEASE
	+ TestFlight v1.3 Release Candidate 3 (1.3.0.15)
	+ KSP 1.0.2 Compatible
	+ Important Note:
	+ Version 1.3 of TestFlight is potentially save-game breaking.  The underlying scenario data store has changed.  While v1.3 includes code to automatically upgrade previous 1.2 save games, it might not always work.
	+ Change Log
		- FIX: Fixed incorrect case comparison when checking if a failure module is disabled.  (Thanks @magico13)
		- FIX: Fixed NRE when TriggerFailure can't find any failure modules. (Thanks @magico13)
* 2015-0516: 1.3.0.13 (jwvanderbeck) for KSP 1.0.2 PRE-RELEASE
	+ TestFlight v1.3 Release Candidate 2 (1.3.0.13)
	+ KSP 1.0.2 Compatible
	+ Important Note:
	+ Version 1.3 of TestFlight is potentially save-game breaking.  The underlying scenario data store has changed.  While v1.3 includes code to automatically upgrade previous 1.2 save games, it might not always work.
	+ Change Log
		- FIX: Leaked resources will no longer pull from other parts!
		- NEW: Failure_ResourceLeak is now more flexible in how the leak amounts are defined.  By default it functions as normal, however you can optionally specify values to be in percent of maximum resource capacity or percent of current resource level.  By adding the suffixes %t or %c respectively.
		- NEW: Added `calculatePerTick` property to Failure_ResourceLeak.  If set to `true` then any percent values will be re-calculated each tick.  If`false` then they will only be calculated initially at the time of failure.  Default values is `false`.
* 2015-0511: 1.3.0.12 (jwvanderbeck) for KSP 1.0.2 PRE-RELEASE
	+ TestFlight v1.3 Release Candidate 1 (1.3.0.12)
	+ KSP 1.0.2 Compatible
	+ Important Note:
	+ Version 1.3 of TestFlight is potentially save-game breaking.  The underlying scenario data store has changed.  While v1.3 includes code to automatically upgrade previous 1.2 save games, it might not always work.
	+ Change Log
		- NEW: Compiled for KSP 1.0.2
		- NEW: ContractConfigurator add-on compiled for CC v1.0.4
* 2015-0511: 1.3.0.11 (jwvanderbeck) for KSP 1.0 PRE-RELEASE
	+ TestFlight v1.3 Experimental (1.3.0.11)
		- This is an experimental development release and should only be used to provide testing feedback
		- Things to test
	+ If you are helping test this experimental, thank you!.  Things to look for:
		- NOTE: For proper testing of this build, it should be tested on a normal live save game.  However please make a backup of your save game first!
	+ 1. This version is a major change to how data is stored in KSP's persistent.sfs file, and would normally be save game breaking. However I have added code to automatically migrate the saved data from the old format to the new format the first time you load and then save your game. Easiest way to do this is just load your game, then immediately exit to the main menu.
	+ 2. Everything should work exactly as before, with the obvious difference being no more scopes.
	+ Change Log
			- NEW: Added `maxData` property to TestFlightCore to indicate the maximum amount of flight data the part can obtain.  This is a required value for all parts, or else the maximum data will be 0!
			- NEW: Added stock resource tank configs
			- NEW: Flight data caps out at `maxData` as defined by the TestFlightCore. Closes #68
			- NEW: Added default savegame settings
			- NEW: Updated SaveData API to allow passing a default value to be used in the case where the saved data could not be found or converted to type
			- NEW: `maxData` properly add to all RealismOverhaul engine configs (Thanks @NathanKelll)
			- FIX: Stock: Don't treat command pods with resources as resource tanks
			- FIX: Updated AVC .version to KSP 1.0
			- NEW: Failure_ReducedMaxThrust now supports new KSP 1.0 engines as well as RF EngineSolver engines
			- NEW: No longer use FAR (when installed) to get atmospheric density, as KSP 1.0 has proper values now
* 2015-0501: 1.3.0.10 (jwvanderbeck) for KSP 1.0.2 PRE-RELEASE
	+ TestFlight v1.3 Experimental (1.3.0.10)
		- This is an experimental development release and should only be used to provide testing feedback
		- Things to test
	+ If you are helping test this experimental, thank you!.  Things to look for:
		- NOTE: For proper testing of this build, it should be tested on a normal live save game.  However please make a backup of your save game first!
	+ 1. This version is a major change to how data is stored in KSP's persistent.sfs file, and would normally be save game breaking. However I have added code to automatically migrate the saved data from the old format to the new format the first time you load and then save your game. Easiest way to do this is just load your game, then immediately exit to the main menu.
	+ 2. Everything should work exactly as before, with the obvious difference being no more scopes.
	+ Change Log
			- FIX: NREs caused by save game without existing data store
			- FIX: When part’s start at MaxData they start at properly the maximum
		- data defined by the ReliabilityCurve and not some insane high value.
			- NEW: Added save game settings to the KSC level TestFlight settings window
			- FIX: Engines would continue gaining data when shutown. Engines now use finalThrust to determine running state
* 2015-0429: 1.3.0.9 (jwvanderbeck) for KSP 1.0.2 PRE-RELEASE
	+ TestFlight v1.3 Experimental (1.3.0.9)
		- This is an experimental development release and should only be used to provide testing feedback
		- Things to test
	+ If you are helping test this experimental, thank you!.  Things to look for:
		- NOTE: For proper testing of this build, it should be tested on a normal live save game.  However please make a backup of your save game first!
	+ 1. This version is a major change to how data is stored in KSP's persistent.sfs file, and would normally be save game breaking. However I have added code to automatically migrate the saved data from the old format to the new format the first time you load and then save your game. Easiest way to do this is just load your game, then immediately exit to the main menu.
	+ 2. Everything should work exactly as before, with the obvious difference being no more scopes.
	+ Change Log
			- NEW: Added per save game settings
			- NEW: TestFlight can be enabled or disabled on a per save game basis
			- NEW: Parts can be set to always be at maximum flight data in a specific
		- save game
			- NEW: Added API to TestFlightManager for persisting arbitrary data for a save game
* 2015-0429: 1.3.0.7 (jwvanderbeck) for KSP 1.0.2 PRE-RELEASE
	+ TestFlight v1.3 Experimental (1.3.0.7)
		- This is an experimental development release and should only be used to provide testing feedback
		- Things to test
	+ If you are helping test this experimental, thank you!.  Things to look for:
		- NOTE: For proper testing of this build, it should be tested on a normal live save game.  However please make a backup of your save game first!
	+ 1. This version is a major change to how data is stored in KSP's persistent.sfs file, and would normally be save game breaking. However I have added code to automatically migrate the saved data from the old format to the new format the first time you load and then save your game. Easiest way to do this is just load your game, then immediately exit to the main menu.
	+ 2. Everything should work exactly as before, with the obvious difference being no more scopes.
	+ Change Log
			- FIX: Fixed zip file creation of new build system to hopefully not generate blank zips
* 2015-0429: 1.3.0.6 (jwvanderbeck) for KSP 1.0.2 PRE-RELEASE
	+ TestFlight v1.3 Experimental (1.3.0.6)
		- This is an experimental development release and should only be used to provide testing feedback
		- Things to test
	+ If you are helping test this experimental, thank you!.  Things to look for:
		- NOTE: For proper testing of this build, it should be tested on a normal live save game.  However please make a backup of your save game first!
	+ 1. This version is a major change to how data is stored in KSP's persistent.sfs file, and would normally be save game breaking. However I have added code to automatically migrate the saved data from the old format to the new format the first time you load and then save your game. Easiest way to do this is just load your game, then immediately exit to the main menu.
	+ 2. Everything should work exactly as before, with the obvious difference being no more scopes.
	+ Change Log
			- FIX: Fix possible infinite loop when the TestFlightCore had a configuration without query in it
			- FIX: If TestFlight title property is not defined or blank, use the part's stock title instead
			- NEW: Allow any module to have a blank or undefined config. In such cases it is considered always active
			- NEW: Stock Configs: Added RT5, RT10, BACC, and Kickback solid boosters
			- NEW: Stock Configs: Added: LV-T30, LV-T45, LV-909, Poodle, Skipper, Mainsail liquid engines
			- FIX: Fixed incorrect configuration tags on stock solid engines
			- NEW: First tier stock liquid and solid engines start at max data
		- already researched
			- NEW: WAC-Corporal and XLR11 start fully tested
* 2015-0428: 1.3.0.5 (jwvanderbeck) for KSP 1.0.2 PRE-RELEASE
	+ TestFlight v1.3 Experimental (1.3.0.4)
		- This is an experimental development release and should only be used to provide testing feedback
		- Things to test
	+ If you are helping test this experimental, thank you!.  Things to look for:
		- NOTE: For proper testing of this build, it should be tested on a normal live save game.  However please make a backup of your save game first!
	+ 1. This version is a major change to how data is stored in KSP's persistent.sfs file, and would normally be save game breaking. However I have added code to automatically migrate the saved data from the old format to the new format the first time you load and then save your game. Easiest way to do this is just load your game, then immediately exit to the main menu.
	+ 2. Everything should work exactly as before, with the obvious difference being no more scopes.
	+ Change Log
			- NEW: Updated for KSP v1.0
* 2015-0426: 1.3.0.4 (jwvanderbeck) for KSP 1.0.2 PRE-RELEASE
	+ TestFlight v1.3 Experimental (1.3.0.4)
		- This is an experimental development release and should only be used to provide testing feedback
		- Things to test
	+ If you are helping test this experimental, thank you!.  Things to look for:
		- NOTE: For proper testing of this build, it should be tested on a normal live save game.  However please make a backup of your save game first!
	+ 1. This version is a major change to how data is stored in KSP's persistent.sfs file, and would normally be save game breaking. However I have added code to automatically migrate the saved data from the old format to the new format the first time you load and then save your game. Easiest way to do this is just load your game, then immediately exit to the main menu.
	+ 2. Everything should work exactly as before, with the obvious difference being no more scopes.
	+ Change Log
			- API: new API stubs for interrogating scenario data store
			- NEW Feature: ContractConfigurator support.  TestFlight now supports ContractConfigurator and adds a new parameter for requiring the player to collect a given amount of flight data on a given part.  TestFlight now supports ContractConfigurator but there are not any contracts that currently use this feature.  These will hopefully come in the future.  If you want to make some, please let me know and I can help you out.
			- NEW: Property added to TestFlightCore `startFlightData` that can be used to indicate that a part should start with a given amount of existing flight data
			- NEW: TestFlightScenario available in all scenes
			- FIX: Target .NET 3.5 for ContractConfigurator plugin
			- FIX: ContractConfigurator only display data remaining if some data has been collected
			- FIX: ContractConfigurator don’t try to validate part string during initial load, as we won’t have a scenario available then
* 2015-0403: 1.3.0.3 (jwvanderbeck) for KSP 1.0.2 PRE-RELEASE
	+ TestFlight v1.3 Experimental (1.3.0.3)
		- This is an experimental development release and should only be used to provide testing feedback
		- Things to test
	+ If you are helping test this experimental, thank you!.  Things to look for:
		- NOTE: For proper testing of this build, it should be tested on a normal live save game.  However please make a backup of your save game first!
	+ 1. This version is a major change to how data is stored in KSP's persistent.sfs file, and would normally be save game breaking. However I have added code to automatically migrate the saved data from the old format to the new format the first time you load and then save your game. Easiest way to do this is just load your game, then immediately exit to the main menu.
	+ 2. Everything should work exactly as before, with the obvious difference being no more scopes.
	+ Change Log
			- FIX: Fix for invalid datatypes causing NREs in new storage scheme.  Added additional data type overloads as well.
* 2015-0319: 1.3.0.2 (jwvanderbeck) for KSP 1.0.2 PRE-RELEASE
	+ TestFlight v1.3 Experimental (1.3.0.2)
		- This is an experimental development release and should only be used to provide testing feedback
		- Things to test
	+ If you are helping test this experimental, thank you!.  Things to look for:
		- NOTE: For proper testing of this build, it should be tested on a normal live save game.  However please make a backup of your save game first!
	+ 1. This version is a major change to how data is stored in KSP's persistent.sfs file, and would normally be save game breaking. However I have added code to automatically migrate the saved data from the old format to the new format the first time you load and then save your game. Easiest way to do this is just load your game, then immediately exit to the main menu.
	+ 2. Everything should work exactly as before, with the obvious difference being no more scopes.
	+ Change Log
		- Large code refactor to remove scopes
		- Updated RO configs to noscope format
* 2015-0319: 1.3.0.1 (jwvanderbeck) for KSP 1.0.2 PRE-RELEASE
	+ TestFlight v1.3 Experimental
		- This is an experimental development release and should only be used to provide testing feedback
		- Things to test
	+ If you are helping test this experimental, thank you!.  Things to look for:
		- NOTE: For proper testing of this build, it should be tested on a normal live save game.  However please make a backup of your save game first!
	+ 1. This version is a major change to how data is stored in KSP's persistent.sfs file, and would normally be save game breaking. However I have added code to automatically migrate the saved data from the old format to the new format the first time you load and then save your game. Easiest way to do this is just load your game, then immediately exit to the main menu.
	+ 2. Everything should work exactly as before, with the obvious difference being no more scopes.
* 2015-0319: 1.3E1 (jwvanderbeck) for KSP 1.0.2 PRE-RELEASE
	+ TestFlight v1.3 Experimental
		- This is an experimental development release and should only be used to provide testing feedback
		- Things to test
	+ If you are helping test this experimental, thank you!.  Things to look for:
		- NOTE: For proper testing of this build, it should be tested on a normal live save game.  However please make a backup of your save game first!
	+ 1. This version is a major change to how data is stored in KSP's persistent.sfs file, and would normally be save game breaking. However I have added code to automatically migrate the saved data from the old format to the new format the first time you load and then save your game. Easiest way to do this is just load your game, then immediately exit to the main menu.
	+ 2. Everything should work exactly as before, with the obvious difference being no more scopes.
* 2015-0314: 1.2.2.0 (jwvanderbeck) for KSP 1.0.2
	+ v1.2.2.0
		- NEW: UI: New TestFlight window available at Space Center that will contain new features in the future.  For now can be used to modify global settings.
		- FIX: Remember last MET upon reload
		- FIX: FAILURES: Set initial engine ignition state based on current engine ignition state rather than UNKNOWN
		- FIX: Persist operatingTime on the part so that loading a game doesn't mess up the timer
		- FIX: FAILURES: IgnitionFail fallback to 100% baseIgnitionChance if not defined in configs
		- UI: Reduced logging in Editor scene
* 2015-0228: 1.2.1.0 (jwvanderbeck) for KSP 1.0.2
	+ v1.2.1.0
		- FIX: UI: Fixed Master Status Display getting into a bad UI state when failed parts where removed from the vessel, which caused other Non-TF Windows to get temporarily broken
		- CONFIGS: Restore ignition charges on the pad but not in the air
		- FAILURES: IgnitionFail: Don't apply pressureCurve if it evaluates to 0
		- FAILURES: IgnitionFail: Always restore ignition charge if in PRELAUNCH situation
		- UI: Updated timestamp on FlightLogger to better match stock KSP entries
		- CONFIG: Updated all engines with new pressure based IgnitionFail configs
		- CONFIG: Updated FloatCurve tangents on all configured parts
		- CONFIG: The KW part representing 2xRL10 engines now records data at twice the rate
		- UI: Tighter GUI popping to hopefuly reduce clashes between mods
		- FIX: #53 OneShot failures weren't being triggered
		- CONFIG: Restore ignition charge on all IgnitionFail failures
		- FAILURES: Allow IgnitionFail to scale based on dynamic pressure
		- UI: Add failures to F3 Flight Log along with MET timestamp
		- CONFIG: Add low tech transfer from Aerobee line to AJ10 Early line
* 2015-0225: 1.2.0.0 (jwvanderbeck) for KSP 1.0.2
	+ Highlights
	+ This version of TestFlight includes some major changes including a brand new Interop API that allows mods that have dynamic parts to work with TestFlight.  In addition there are many config changes to sync up with the latest versions of Realism Overhaul and RP-0.
		- VERY IMPORTANT: If you use RealFuels, RealismOverhaul, or RP-0 you will need to get the latest versions of those mods, being released in sync with this version of TestFlight, to ensure continued proper operation.  If you do not, TestFlight will not properly attach to parts.
	+ Change Log
		- New Interop API allows mods that make dynamic parts, such as RealFuels and Procedural Parts, to connect with TestFlight and provide data that identifies parts by those dynamic properties.
		- Totally reworked configs pre-processor makes it easier to update and add new part configs
		- New Query System allows for far more control in configs as to what modules apply to what
		- Support for failure modules to operate on specific engines in a part when a part has more than one engine module.
		- You can now see the rated burn time on engines in the VAB
		- Fixed some benign NREs
		- Possible fix for the TestFlight MSD sometimes going blank and taking half the UI with it for a few seconds
		- Updates to several engine configs including LR-89, LR-105, and AJ10 series engines to match current configs in RealismOverhaul/RP-0
		- Fixed a bug that sometimes prevented TestFlight from properly determining state change of an engine from NOT_IGNITED to IGNITED
		- Fix bug in settings window where your last view settings page was not properly restored upon loading the window
		- EngineModuleWrapper and all Engine based Failure Modules now support two ways of addressing specific ModuleEngines and ModuleEnginesFX on a part; Index and engineID
		- Added new Diffuculty Setting to make all parts operate under a Single Scope rather than distinct scopes based on craft location & situation
		- If a part uses the TestFlightReliability_Engine module, the rated burn time for the engine as well as the burn through time and penalty is now listed in part's "Info" window in the VAB.
		- New part aliasing feature allows configs to change without loss of flight data in most cases.  Also allows multiple parts to be treated as the same part.
* 2015-0210: 1.1.0.0 (jwvanderbeck) for KSP 1.0.2
	+ TestFlight v1.1.0.0
	+ Change Log
		- Changed AJ10 engine config names to line up with RP-0
		- NEW ENGINE: XLR11 (FASA Pack) -->  XLR99
		- NEW ENGINE: LR-87-3 (FASA and AIES Packs) --> LR-87-5 --> LR-87-7 --> LR-87-9 --> LR-87-11 --> LR-87-11A
		- NEW ENGINE: RL10A-1 (Squd, KW, and FASA Packs) -> RL10A-3-1 --> RL10A-3-3 --> RL10A-3-3A --> RL-10A-4 --> RL-10A-4-1/2 --> RL10B-2 --> RL10C-1
		- FIX spelling error in settings window
		- FIX #47 Parts that are destroyed or staged will now remain in the MSD for about 15 seconds giving you time to see their status
		- FIX Incorrect LR-89 engine reference
		- NEW Initial support for Procedural Tanks, more to come on this!
* 2015-0208: 1.0.0.0 (jwvanderbeck) for KSP 1.0.2
	+ [Vanguard Fails Again](http://i.ytimg.com/vi/m3y_LwN5afc/maxresdefault.jpg)
	+ TestFlight Release 1
	+ Here we are space cadets!  Several months of hard work has paid off and we have arrived at the full public release of TestFlight!
	+ Thank you to everyone who assisted during the development process and to everyone who encouraged and supported the development of this mod.
* 2015-0203: 0.4.6-RealismOverhaul (jwvanderbeck) for KSP 1.0.2 PRE-RELEASE
	+ Alpha Release
		- This is an Alpha Development Release and thus should be assumed to contain bugs that may or make not break your game.  Use of this release in a clean test save game is highly recommended.
	+ Change Log
		- FIX #21  When triggering a random failure, skip ones marked as disabled
		- FIX #22 Only add positive flight data.  Should resolve issue with 0 or negative du showing in MSD
		- NEW #23 Parts can now gain bonus flight data when they fail, and when failures are repaired.  After all, we're supposed to learn from our failures!  New properties `duFail` and `duRepair` added to Failure modules and implemented automatically by the base class.
		- NEW #26 Failures can be "one-shot" which means the bad stuff from the failure happens but the part is not placed into a failed state and continues to operate (if possible).  New property `oneShot` added to Failure modules.
		- NEW #29 Support for EngineIgnitor mod.  The IgnitionFail Failure Module can optionally restore a used up ignition when it fails.  New property `restoreIgnitionCharge` added to TestFlightFailure_IgnitionFail Module
		- FIX EngineCycle Reliability was incorrectly modifying Base Failure Rate, and was being enabled when it should have been.  Both issues fixed.
		- NEW #31 Instead of defining a reliabilityCurve for every one of the possible 33 scopes, even when they were the same, a "default" scope curve can now be used and TestFlightReliability will use the default scope if a specific one is not found.
			- [RealismOverhaul] Removed accidental double definition of Aerobee-150.
			- [RealismOverhaul] Re-added use of IgnitionFail failure after bugs were fixed.
			- [RealismOverhaul] Added large chance of ignition failure to X-405 Vanguard.
			- [RealismOverhaul] WAC-Corporal/Aerobee Line, X-405, and AJ-10-37/42 all use EngineCycle Reliability now, which defines a "bathtub" curve for reliability over the expected operating cycle of the engine, based on real manufacturer specs.  This means the engine will have an increase in failure rate for the first few seconds of operation, smooth out to normal Base Failure Rate for the "Rated Burn Time" of the engine, and the the failure rate will slowly start increasing as the engine exceeds the manufacturer's "Rated Burn Time".  Rated burn times: WAC/Aerobee: 47 seconds, X-405: 145 seconds, AJ-10-37/42:L 115 seconds.
* 2015-0206: 0.4.6.2-Stock (jwvanderbeck) for KSP 1.0.2 PRE-RELEASE
	+ Alpha Release
		- This is an Alpha Development Release and thus should be assumed to contain bugs that may or make not break your game.  Use of this release in a clean test save game is highly recommended.
	+ Change Log
		- FIX AVC .version file had bad formatting
		- FIX autogenerated URLs for AVC and CKAN had incorrect URLs
		- FIX Output pretty JSON for CKAN
		- FIX ID in .version file was backwards
		- FIX Property `deepSpaceThreshold` in Core was wrong format
		- NEW #37  MSD will now restore its previous visibility state
		- FIX #38 DataRecorder_Engine now uses the common engine wrapper
		- FIX #39 Improved support for RF/MFT and ModuleEngineConfig.  Derivative engines should work properly now.
		- NEW #40 The amount of thrust lost in the ReducedMaxThrust failure can now be configured with the `thrustReduction` property which is a multiplier from 0 to 1.
			- [RealismOverhaul] Major work on tweaking Aerobee, X-405, and AJ-10 engines for both realistic reliability and fun gameplay.
			- [RealismOverhaul] NEW Engine configs for AJ10-142 and AJ10-104D
			- [RealismOverhaul] NEW Engine configs for LR-89-5
			- [RealismOverhaul] NEW Engine configs for LR-105-5
			- [RealismOverhaul] NEW Engine configs for Bell 80XX series engine
* 2015-0205: 0.4.6.1-RealismOverhaul (jwvanderbeck) for KSP 1.0.2 PRE-RELEASE
	+ Alpha Release
		- This is an Alpha Development Release and thus should be assumed to contain bugs that may or make not break your game.  Use of this release in a clean test save game is highly recommended.
	+ Change Log
		- ShutdownEngine failure should now also shutdown the visual effects playing with certain mods like RealPlume/Smoekscreen
		- ShutdownEngine failure now uses the common EngineModuleWrapper
		- ReducedMaxThrust should now work properly with RF/MFT or any other ModuleEngineConfigs based mod
		- TestFlight now has AVC .version files.  It does not include miniAVC, but if you are using the full AVC mod (which I highly suggest because its awesome) you should now be notified of updates
		- TestFlight now generates CKAN files so should be on CKAN soon
		- FIX Fixed a bug in Failure modules that was preventing the `duFail` and `duRepair` properties from working.  Unfortunately due to the way KSP works, you will need to create new craft for this fix to take effect.  Any existing craft or saved .craft files will not work.
* 2015-0203: 0.4.5-Stock (jwvanderbeck) for KSP 1.0.2 PRE-RELEASE
	+ Alpha Release
		- This is an Alpha Development Release and thus should be assumed to contain bugs that may or make not break your game.  Use of this release in a clean test save game is highly recommended.
	+ Highlights
		- Initial release of TestFlight with Realism Overhaul compatibility
		- Support for MFT/RF ModuleEngineConfig system
		- Support for Technology Transfer from part to part
		- Initial configs for RealismOverhaul
	+ Stock & Realism Overhaul Support
	+ As of this release, TestFlight now officially supports Realism Overhaul.  Currently configs exist for only a single part, the Aerobee engine line.  Each version of the Aerobee has different failure rates based on real data, and tech transfer exists throughout the line.  Feedback on this is most appreciated!
	+ Moving forward there will be separate releases for Stock and Realism Overhaul so that each contains the correct configs.  Choose the one you want and download that.  They will be clearly marked as Stock or Realism Overhaul.
	+ They both are the same code and the same Plugins, it is just the ModuleManager configs that differ.
	+ Change Log
		- All TestFlight modules can now use a new property `configuration`.  If specified TestFlight will only enable that module if the part's currently active MFT/RF configuration matches the specified value.  This allows configuration of ModuleEngineConfig parts as if they were their own separate parts.
		- DataRecorder runs off `operatingTime` now and therefore will not record data if the part is in a failed state
			- API: Added new methods for retrieving TestFlight modules on a part.
			- New Module: Added new Failure module, TestFlightFailure_IgnitionFail which is works a bit different than most, and would be considered a FailureTrigger module.  It monitors for an engine to change states from not ignited, to ignited, and applies a chance for that ignition to fail.  This chance is based on FlightData and the curve can be configured in .cfg file.
		- Initial configs for RO starting with the WAC-Corporal/Aerobee engine line.
		- `operatingTime` is no longer capped at MTBF so parts can still fail after MTBF has passed
		- Added new class to TestFlightAPI to wrap up the annoying duality of ModuleEngines and ModulesEnginesFX
		- New property added to all Module Interfaces `TestFlightEnabled` determines if the module is currently running under TestFlight
		- Fixed bug with "0 time to repair" failures not giving the Repair Button
		- Fixed bug with failures that had no repair config breaking the system
		- Added Technology Transfer system that allows partial flight data to transfer from one part to another part that is considered to be a related technology path.
		- Swapped to using System.Random for random numbers since apparently KSP spews out the same random sequence each time you load a game.
		- Added instance of System.Random to TestFlightCore and TestFlightManagerScenario for use by other modules.
		- Fixed issue #16 - parts continue to accrue operating time even when failed
		- Fixed issue #19 - operating time wasn't respecting IsPartOperating
		- More adjustments to MSD window size to avoid horizontal scrolling
		- Updates to build system to allow building Stock and RealismOverhaul configs as needed
* 2015-0203: 0.4.5.1-RealismOverhaul (jwvanderbeck) for KSP 1.0.2 PRE-RELEASE
	+ Alpha Release
		- This is an Alpha Development Release and thus should be assumed to contain bugs that may or make not break your game.  Use of this release in a clean test save game is highly recommended.
	+ Change Log
		- Removed IgnitionFail failure from Aerobee because it has some bugs
		- Tweaked Aerobee reliability and tech transfer values
		- Added initial config for X-405 Vanguard
		- Added initial config for AJ-10-37 and AJ-10-47
* 2015-0202: 0.4.2 (jwvanderbeck) for KSP 1.0.2 PRE-RELEASE
	+ Alpha Release
		- This is an Alpha Development Release and thus should be assumed to contain bugs that may or make not break your game.  Use of this release in a clean test save game is highly recommended.
	+ Important Installation Note
	+ Currently the ZIP file will contain configs for both Stock and Realism Overhaul.  You must delete the folder for whichever you do not need or else who knows what will happen.
	+ Highlights
		- Initial release of TestFlight with Realism Overhaul compatibility
		- Support for MFT/RF ModuleEngineConfig system
		- Support for Technology Transfer from part to part
		- Initial configs for RealismOverhaul
	+ Realism Overhaul Support
	+ As of this release, TestFlight now officially supports Realism Overhaul.  Currently configs exist for only a single part, the Aerobee engine line.  Each version of the Aerobee has different failure rates based on real data, and tech transfer exists throughout the line.  Feedback on this is most appreciated!
	+ Change Log
		- All TestFlight modules can now use a new property `configuration`.  If specified TestFlight will only enable that module if the part's currently active MFT/RF configuration matches the specified value.  This allows configuration of ModuleEngineConfig parts as if they were their own separate parts.
		- DataRecorder runs off `operatingTime` now and therefore will not record data if the part is in a failed state
			- API: Added new methods for retrieving TestFlight modules on a part.
			- New Module: Added new Failure module, TestFlightFailure_IgnitionFail which is works a bit different than most, and would be considered a FailureTrigger module.  It monitors for an engine to change states from not ignited, to ignited, and applies a chance for that ignition to fail.  This chance is based on FlightData and the curve can be configured in .cfg file.
		- Initial configs for RO starting with the WAC-Corporal/Aerobee engine line.
		- `operatingTime` is no longer capped at MTBF so parts can still fail after MTBF has passed
		- Added new class to TestFlightAPI to wrap up the annoying duality of ModuleEngines and ModulesEnginesFX
		- New property added to all Module Interfaces `TestFlightEnabled` determines if the module is currently running under TestFlight
		- Fixed bug with "0 time to repair" failures not giving the Repair Button
		- Fixed bug with failures that had no repair config breaking the system
		- Added Technology Transfer system that allows partial flight data to transfer from one part to another part that is considered to be a related technology path.
		- Swapped to using System.Random for random numbers since apparently KSP spews out the same random sequence each time you load a game.
		- Added instance of System.Random to TestFlightCore and TestFlightManagerScenario for use by other modules.
		- Fixed issue #16 - parts continue to accrue operating time even when failed
		- Fixed issue #19 - operating time wasn't respecting IsPartOperating
		- More adjustments to MSD window size to avoid horizontal scrolling
		- Updates to build system to allow building Stock and RealismOverhaul configs as needed
* 2015-0128: 0.4.0 (jwvanderbeck) for KSP 1.0.2 PRE-RELEASE
	+ Alpha Release
		- This is an early alpha development release and thus should be assumed to be buggy, and capable of breaking your game and game saves.  Please do not test this in a game save that you care about!
		- IMPORTANT NOTE Due to many changes in how settings are handled, and stored, as well as the removal and addition of different settings than previous releases, please completely delete any previous install of TestFlight before installing this version.  In addition it is _highly recommended_ to start a new save game for this release.
	+ Highlights
		- TestFlight API completely overhauled and is not backwards compatible
		- Totally rewritten underlying core systems
		- Migrated from a polling "pull" style system to a "push" style system where the individual parts are responsible for their own state, and the core manager/GUI only asks for that state when needed to update the GUI or save to disk
		- Brand new Editor Window allows you to inspect your parts while building.
		- Initial implementation of new Mean Time Between Failure (MTBF) system.
	+ MTBF System
	+ Some things to understand about the new MTBF system.
	+ 1. MTBF does not mean time until failure.  A MTBF of 60 seconds does not mean your part will fail in 60 seconds.  It could fail well before 60s or well after 60s.  But on average it will fail sometime around 60s.  Maybe.
	+ 2. Probability is a bitch.  Just because something is highly unlikely does not mean it is impossible.
	+ Important testing in this update is "How does it feel?".  I know this is subjective and everyone will have a different opinion, but please let me know how it feels to you.  Both on early flights, and later flights once your parts have gained reliability.  I have some knobs I can tune.
		- [Image of TestFlightEditorWindow](http://i.imgur.com/xDKU0P6.png)
	+ In the VAB you will now see TestFlight on the AppLauncher.  Click to open the Editor Window.  The Editor Window will show you details on your parts so you can make decisions on what to use on your craft.  It shows you the flight data and reliability of the part for all scopes with recorded flight data.
	+ To use:
	+ 1. Open the window by clicking the TestFlight icon in the AppLauncher bar
	+ 2. Mouse over parts in the parts bin on the left.  As you mouse over parts, you will see that part's data in the window.
	+ 3. Right click a part in the parts bin to lock the window to that part.  Once locked, you can move your mouse wherever and it will continue to show the data from the locked part.  Right click th same part again to unlock the window, or right click a new part to change the lock to that part.
	+ 4. Left clicking a part to add it to the craft will automatically unlock the window if it is locked.
	+ As with the main TestFlight window, you can click the "Lock Window" button to lock or unlock the window to the dock.  If unlocked, you can position it wherever you want.
	+ API Changes
			- The TestFlight API is not backwards compatible with previous versions
	+ This release contains a completely overhauled API.  If you have written a module for TestFlight it will need to be updated to use the new API.
	+ The good news is that while the API got a lot more flexible and a lot more powerful,most of the changes _for now_ are in the Core, not the plugin modules.  Changes to compile against this release will probably be minor.
	+ Change Log
			- Rewrote core scenario code.  TestFlightManagerScenario is now only a data store for the persistent data, and contains no appreciable game logic
			- Redesigned TestFlightCore API to accommodate both the new "push" method as well as upcoming changes to the underlying reliability and failure architecture
			- Flight Data and Flight Time now stored as doubles
			- Implemented brand new Test Flight API
			- Changes to ITestFlightCore interface
			- Changes to ITestFlightDataRecorder interface
			- Changes to ITestFlightReliability interface
			- Core system refreshes status more often now that there is less of a performance hit
			- Changed method of configuring how FlightData converts into Reliability in the config files.  This is now done using a FloatCurve which allows the modder to make it as simple or as complex as desired
			- Fixed a bug that caused reliability to not load properly when going through the VAB with a craft
			- Fixed a bug causing "sub" modules to load before the Core and therefore never attaching properly
			- Added new Editor Window to see part's flight data and reliability while building
			- Defer loading of prefab data to Start() in case KSP is being slothful.  Should fix reliability not loading correctly in Flight.
			- Initial implementation of new MTBF system
			- MSD now shows MTBF
			- MSD now shows Failure Rate
			- Make font in MSD smaller, and adjusted window to accommodate new data
			- Updated settings pane in MSD to remove no longer used settings, and rename/tweak ones that are left.
			- New Reflection Interface for other mods to integrate with TestFlight.  This is still a WIP and feedback is more than welcome.
			- Fix issue #11 - Settings Dropdown List hard to read
			- Fix issues #14 - Data rate multiplier being incorrectly applied and giving zillions of data units (or none!)
			- New API methods to allow repairs to take time to complete
			- Expanded Reflection Interface and API
			- MSD can now show failure rate in addtion to MTBF
			- failure rate in MSD now properly shows the 'worst' momentary failure rate
			- DataRecorder modules can now control when a part is considered "operating"
			- Mission time is now calculated from activation of first stage, not from MET which KSP does not start until you leave the pad.  This means two main things.
				- Engine test stands are a thing
				- The practice of igniting your first stage before releasing the launch clamps is a good one, to ensure you engine(s) are ignited and running properly.
			- Added new Reliability module that increase the failure rate of an engine for the first 5 seconds after ignition.  This is also a sample of the power of the new system to do things like this!  Currently enabled on liquid engines.
			- Added new API methods to control flow of Flight Data
				- SetDataRateLimit()
				- SetDataCap()
			- Changed failure checks to be a constant chance of failure, rather than increasing towards MTBF
			- Added Travis CI integration for continuous integration testing of commits, and automated builds.
			- TestFlight configs are now built in JSON and then compiled to standard ModuleManager config format upon build and release.  This standardizes the configs, as well as makes them easier to write by removing redundancy and allowing re-use of setups.
* 2015-0126: 0.4.0e7 (jwvanderbeck) for KSP 1.0.2 PRE-RELEASE
	+ Experimental Release
		- This is an experimental release of a development branch.  This version is released to allow people to test upcoming changes and should be considered unstable and buggy.  Do not use an experimental release in any save you care about.
	+ Change Log
		- Added new API methods to control flow of Flight Data
			- SetDataRateLimit()
			- SetDataCap()
* 2015-0111: 0.3.0 (jwvanderbeck) for KSP 1.0.2 PRE-RELEASE
	+ Alpha Development Release
		- This is an early alpha development release and thus should be assumed to be buggy, and capable of breaking your game and game saves.  Please do not test this in a game save that you care about!
		- IMPORTANT NOTE Due to many changes in how settings are handled, and stored, as well as the removal and addition of different settings than previous releases, please completely delete any previous install of TestFlight before installing this version.  In addition it is _highly recommended_ to start a new save game for this release.
	+ Highlights
		- Brand new TestFlight GUI
		- Configurable Master Status Display gives you all the details on your parts you want, and nothing more
		- Settings GUI lets you change TestFlight settings easily in game
		- In Flight HUD gives you a compact view of the most critical information
		- Rebuilt underlying persistent handling to hopefully be more reliable
	+ All new TestFlight GUI
		- [Image of blah](http://i.imgur.com/SwjKCQl.png)
			- New Master Status Display is highly configurable and automatically scrolls to hand craft with lots of parts.  You can turn on/off all data displays with the exception of the part name (which you can shorten) and the Repair/Acknowledge buttons. _NOTE: The Momentary Reliability data is a temporary placeholder and will never contain any data in this release_
			- New tooltip for repair requirements uses color highlighting to let you quickly see which conditions are met (green), which are not(red), and which are not met but optional (orange).
			- You can set the size of the main MSD to one of three preset sizes, Small, Normal, or Large which will adjust how tall the window is and how many parts you can see before scrolling.
			- MSD can be filtered to show only failed parts.  Repairing or Acknowledging a failure will remove it from the list.
			- New In Flight HUD provides a compact status display that shows only failed parts, and shows only the name of the part and the buttons to repair or acknowledge the failure.  Part coloring in this HUD quickly identifies the severity of the failure (Green = minor, orange = normal, red = critical).
			- MSD can be docked, or unlocked and moved
	+ Change Log
			- Added entirely new Master Status Display (MSD) for TestFlight
			- Added settings window for configuring TestFlight settings in game
			- Added ability to independently toggle on or off various pieces of part status in the MSD
			- Added new compact in flight HUD that can be toggled on/off and positioned as desired
			- MSD can be either docked, or unlocked and moved around
			- MSD now scrolls if there are too many parts to fit
			- MSD height is adjustable
			- Settings pane broken into multiple pages so as to not require a huge window
			- Repair Requirements tooltip is now color coded for clarity and quick assimilation of data
			- Fixed spelling error in settings dialog
			- Added button to "acknowledge" a failure.  This will clear it from the Flight HUD and the MSD if set to show only failed parts, but will not repair the failure.  It will still remain in the full MSD list (If the show only failed parts setting is OFF)
			- Added the failure title to the tooltip of the Flight HUD
			- Rebuilt ScenarioModule to provide a more reliable data store
* 2015-0102: 0.2.1 (jwvanderbeck) for KSP 1.0.2 PRE-RELEASE
	+ This is an alpha release and thus should be assumed to be buggy, and capable of breaking your game and game saves.
		- Fixed Master Status Display not showing some failures
		- Fixed (hopefully) configs for Stock parts
* 2015-0108: 0.2.1e2 (jwvanderbeck) for KSP 1.0.2 PRE-RELEASE
	+ This is an EXPERIMENTAL release.  Experimental releases are very much "development snapshots" and are released for the express purpose of getting user feedback or testing on a very specific bug or feature that is being worked on.  If testing an experimental release, please limit feedback to the scope of that release.
	+ This is an alpha release and thus should be assumed to be buggy, and capable of breaking your game and game saves.
	+ Experimental release of the new reworked GUI.  This is still very much a WIP.
	+ This release implements the new TestFlight GUI skin, addresses issues in Experimental 1, and adds a new compact Flight HUD.
		- New TestFlight GUI Theme designed for clarity
		- Settings pane is now split into multiple "sections", each of which can be selected from the drop down list at the top of the settings pane.
		- The Master Status Display now has a maximum height for display of the part status.  If too many parts need to be displayed, the GUI will start to scroll instead.
		- Added scroll view for Part Display
		- Added filter to show only failed parts in Master Status Display
		- Added setting to set size of scroll view in one of three increments, Small, Normal, or Large
		- Added setting to hide/show flight data on part
		- Added setting to hide/show resting reliability on part
		- Added setting to hide/show momentary reliability on part
		- Added setting to hide/show part status text
		- Added setting to truncate/shorten display names for parts
		- Added setting to lock/unlock the Master Status Display window
		- Added setting to enable/disable the compact Flight HUD
		- Added new compact Flight HUD which displays _only_ the parts that have failed, and a repair button.  Part names are colored for quick identification of the severity of the failure.  Green = Minor, Yellow = Normal, Red = Critical
		- Moving the Master Status Display (after unlocking it) now saves the window's position
		- Moving the Flight HUD save's the windows position
* 2014-1231: 0.2.0 (jwvanderbeck) for KSP 1.0.2 PRE-RELEASE
	+ This is an alpha release and thus should be assumed to be buggy, and capable of breaking your game and game saves.
		- New Recorder module, FlightDataRecorder_Resources, only records flight data while the part has stored resources.
		- New Failure module, TestFlightFailure_ResourceLeak, leaks a named or random resource in the part.  Initial leak amount, and amount per second can be configured in config node
		- Changes to ITestFlightFailure interface to allow mod authors of Failure modules more flexability
		- Added Tooltips to UI part status that indicate repair requirements for part
		- Don't poll any parts on a new vessel until at least 10 seconds after mission start
		- Made MasterStatusDisplay GUI window a bit wider
		- Documentation updates
		- Fix to bug preventing REPAIR{} nodes from loading and persisting  properly
		- Updated all existing failure modules to use new failure API interface
		- Removed old TestFlightFailure_LiquidFuelLeak Failure module.  Use the new TestFlightFailure_ResourceLeak instead
		- All new configs to apply TestFlight to Stock Engines and Fuel Tanks.  Many thanks to JeffreyCor for the help here.
		- Changed calculation for base reliability based on flight data.  Now uses only one variable, reliabilityMultiplier with higher numbers being easier to obtain 100% reliability and lower numbers being easier.  Value of 1 puts 100% reliability at 10,000 units of flight data
		- Implemented repair systems, as well as initial repair requirements.  Note that some repairs have a part they require for repair.  These parts can't be made, yet, but are not required.  They are optional and give a repair bonus if present.  These parts will soon be available through my companion AddOn MaterialPrinter.
* 2014-1228: 0.1.0 (jwvanderbeck) for KSP 1.0.2 PRE-RELEASE
	+ Very first public alpha release of TestFlight.  Some things to note:
		- Future versions will break save games.  Don't install this in a save you care about
		- There are bound to be tons of bugs.  Please report them using the issue tracker on GitHub
		- Contains only a small amount of failure modules.  More will be added in the future
		- There is no in game UI for changing the settings.  That can currently only be done by hand editing the settings.cfg file.  Obviously a UI will be added in the future
		- There are two major modes of operation - All Vessels, and Active Vessel Only.  Active Vessel Only is the only mode that has received any testing at this point.
		- Configs are included to add the TestFlight system to some of the Squad engines and fuel tanks.  More parts can be included if you desire by making your own configs.  In the future more parts will be included.
		- The included ZIP file contains some extraneous Mac OSX files.  Sorry about that, but at the time of this release only my Mac was available.  I'll clean this up for future releases.
		- At this time I have only tested KSP under Mac OSX.  The included files should work for any build of course, but no testing on other platforms has been done.
