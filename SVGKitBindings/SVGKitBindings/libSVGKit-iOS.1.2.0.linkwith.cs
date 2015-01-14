using System;
using ObjCRuntime;

[assembly: LinkWith ("libSVGKit-iOS.1.2.0.a", LinkTarget.ArmV7 | LinkTarget.Simulator | LinkTarget.Arm64 | LinkTarget.Simulator64, SmartLink = true, ForceLoad = true)]
