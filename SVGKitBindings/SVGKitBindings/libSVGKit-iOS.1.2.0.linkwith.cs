using System;
using ObjCRuntime;

[assembly: LinkWith ("libSVGKit-iOS.1.2.0.a", 
	LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s, 
	SmartLink = true,
	Frameworks="QuartzCore CoreText CoreGraphics CoreImage UIKit",
	Linkerflags="-lxml2 -ObjC",
	ForceLoad = true)]
