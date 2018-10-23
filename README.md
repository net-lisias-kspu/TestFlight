# Test Flight /L Unofficial

TestFlight is an add-on for Kerbal Space Program that simulates the effect of increasing the reliability of your space hardware through flight testing.﻿ Unofficial fork by Lisias.


## In a Hurry

* [Latest Release](https://github.com/net-lisias-kspu/TestFlight/releases)
	+ [Binaries](https://github.com/net-lisias-kspu/TestFlight/tree/Archive)
* [Source](https://github.com/net-lisias-kspu/TestFlight)
* [Project's README](https://github.com/net-lisias-kspu/TestFlight/blob/master/README.md)
* [Change Log](./CHANGE_LOG.md)
* [TODO](./TODO.md) list


## Description

Flight testing comes to KSP!

TestFlight is an add-on for Kerbal Space Program that simulates the effect of increasing the reliability of your space hardware through flight testing.﻿

Wikipedia defines [Flight Testing](https://en.wikipedia.org/wiki/Flight_test) as:

> Flight testing is a branch of aeronautical engineering that develops and gathers data during flight of an aircraft, or atmospheric testing of launch vehicles and reusable spacecraft, and then analyzes the data to evaluate the aerodynamic flight characteristics of the vehicle in order to validate the design, including safety aspects.

> The flight test phase accomplishes two major tasks:  1) finding and fixing any aircraft design problems and then 2) verifying and documenting the vehicle capabilities for government certification or customer acceptance. The flight test phase can range from the test of a single new system for an existing aircraft to the complete development and certification of a new aircraft, launch vehicle, or reusable spacecraft. Therefore, the duration of a flight test program can vary from a few weeks to many years.

In a nutshell TestFlight is a persistent, parts based research and reliability program. Your parts start out with an inherent failure rate that might be quite high on some parts, and quite low on others. As you fly those parts, you gain flight data. If the parts fail, and they will, then one of many failure modes can occur, some that can be repaired and some that can't. Either way you will accumulate data from failures and repairs as well. All this data is transmitted back to your spaceport, and the next time you fly the same hardware it will have a lower failure rate based on how much flight data you collected in the previous flight. This happens on a per part basis, along with RealFuels integration so that if you use RealFuels to change the engine to a different config derivative, that derivative will be tracked as well.

### Compatiblity

Kerbal Space Program : 1.0.5 (x86 only - Windows x64 is not supported.  Please don't give bug reports.  Linux x64 is fine, and Windows x64 should be ok come KSP 1.1)

[RealismOverhaul](https://forum.kerbalspaceprogram.com/threads/99966-0-90-Realism-Overhaul-7-0-7-2015-032) : v8 or later of RealismOverhaul is supported. The TestFlight configs for RO are managed by that project and come installed with RO, so simply download the TestFlight Core plugin.

Stock: As of TestFlight v1.3, there is a TestFlight Config Pack for Stock parts as well, for those who want to experience TestFlight without playing RealismOverhaul. Be sure to download and install the TestFlight Config Pack for Stock, found in the GitHub release of TestFlight, or linked on KerbalStuff.

[Kerbal Construction Time](https://forum.kerbalspaceprogram.com/threads/92377-0-90-Kerbal-Construction-Time-1-1-2-%2812-27-14%29-Unrapid-Planned-Assembly) (KCT): TestFlight does work with KCT, however be aware that any flight data gathered while inside a KCT sim will be lost when you exit the sim. I am working with magico13 to provide tighter integration of TestFlight with KCT. Update: KCT now has some limited interaction to allow you to disable failures during a sim for testing.


## Installation

To install, place the GameData folder inside your Kerbal Space Program folder.

**REMOVE ANY OLD VERSIONS OF THE PRODUCT BEFORE INSTALLING**.

### Dependencies

* Module Manager


### Licensing
This work is licensed under CC BY-NC-SA 4.0. See [here](./LICENSE).

Please note the copyrights and trademarks in [NOTICE](./NOTICE).


## UPSTREAM

* [Aghatorn](https://forum.kerbalspaceprogram.com/index.php?/profile/99662-agathorn/): UPSTREAM
	+ [Forum](https://forum.kerbalspaceprogram.com/index.php?/topic/99043-122-testflight-v180-01-may-2017-bring-flight-testing-to-ksp/)
	+ [GitHub](https://github.com/KSP-RO/TestFlight)
