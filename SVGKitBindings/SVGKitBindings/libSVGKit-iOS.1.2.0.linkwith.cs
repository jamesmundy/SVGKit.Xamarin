using System;
using ObjCRuntime;

[assembly: LinkWith ("libSVGKit-iOS.1.2.0.a", 
	LinkTarget.ArmV7 | LinkTarget.Simulator | LinkTarget.Arm64 | LinkTarget.Simulator64, 
	SmartLink = false,
	Frameworks="QuartzCore CoreText CoreGraphics CoreImage UIKit",
	LinkerFlags="-lxml2 -ObjC",
	ForceLoad = true)]
