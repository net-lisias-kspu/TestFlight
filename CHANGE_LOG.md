# Test Flight :: Change log

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
