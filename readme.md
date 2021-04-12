# Cross platform Blazor Desktop example

This sample shows a Blazor Desktop (using the offical APIs coming in .NET 6) app running in both a web browser and in an early version of the official WinForms wrapper. This uses the default Blazor Server template as an example which is a bit prettier than the one on the .NET 6 Preview 2 announcement post.

Code shared between the Blazor Desktop app and the Blazor Server apps is in the WebviewAppShared Razor class library.

![docs/blazor-desktop-xplat.gif](docs/blazor-desktop-xplat.gif)

To run it open ```/BlazorDesktopTest.sln``` in Visual Studio 16.10 Preview 1 with the .NET 6 Preview 3 SDK installed and "Enable Preview .NET SDKs" turned on. You can then F5 the BlazorDesktopTest and BlazorWinFormsApp projects. 

Updated for .NET 6 Preview 3 and the official ```Microsoft.AspNetCore.Components.WebView``` nuget package on 12th April 2021.