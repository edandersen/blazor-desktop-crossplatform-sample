// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Windows.Forms;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using WebviewAppShared;
using WebviewAppTest;
using WebviewAppTest.Data;

namespace BlazorWinFormsApp
{
    public partial class Form1 : Form
    {
        private readonly AppState _appState = new();

        public Form1()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddWindowsFormsBlazorWebView();
            serviceCollection.AddSingleton<AppState>(_appState);

            serviceCollection.AddSingleton<WeatherForecastService>();

            InitializeComponent();

            blazorWebView1.HostPage = @"wwwroot\index.html";
            blazorWebView1.Services = serviceCollection.BuildServiceProvider();
            blazorWebView1.RootComponents.Add<App>("#app");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                owner: this,
                text: $"Current counter value is: {_appState.Counter}",
                caption: "Counter");
        }
    }

    //Helpful guide on Winforms: https://docs.microsoft.com/en-us/aspnet/core/blazor/hybrid/tutorials/windows-forms?view=aspnetcore-6.0
}
