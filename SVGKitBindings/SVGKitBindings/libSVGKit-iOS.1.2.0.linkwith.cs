using System;
using ObjCRuntime;

[assembly: LinkWith ("libSVGKit-iOS.1.2.0.a", 
	LinkTarget.ArmV7 | LinkTarget.Simulator | LinkTarget.Arm64 | LinkTarget.Simulator64, 
	SmartLink = true,
	Frameworks="QuartzCore CoreText CoreGraphics CoreImage UIKit",
	Linkerflags="-lxml2 -ObjC",
	ForceLoad = true)]
