# Test Flight :: Change log

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
