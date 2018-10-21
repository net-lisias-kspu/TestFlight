# Test Flight :: Change log

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
