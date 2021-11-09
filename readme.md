# Cross platform Blazor Desktop example

This sample shows a Blazor Desktop (using the offical APIs coming in .NET 6) app running in both a web browser and in a WinForms and WPF wrapper. This uses the default Blazor Server template as an example which is a bit prettier than the one on the .NET 6 Preview 2 announcement post.

Code shared between the Blazor Desktop app and the Blazor Server apps is in the WebviewAppShared Razor class library.

![docs/blazor-desktop-xplat.gif](docs/blazor-desktop-xplat.gif)

Because you now have the power of Chromium you can now do cool WebGL things like this inside WPF and WinForms apps:

![docs/blazor-desktop-xplat-water.gif](docs/blazor-desktop-xplat-water.gif)

To run it open ```/BlazorDesktopTest.sln``` in Visual Studio 2022 .NET 6 SDK installed. You can then F5 the BlazorDesktopTest and BlazorWinFormsApp projects. 

Updated for .NET 6 RTM and the official ```Microsoft.AspNetCore.Components.WebView``` nuget package on 9th November 2021.

Contains a snazzy WebGL water demo from https://github.com/evanw/webgl-water. No way could I write this!