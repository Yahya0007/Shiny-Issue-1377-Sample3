using CommunityToolkit.Mvvm.Messaging;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;
using StaffApp.Resources.Styles;
using StaffApp.ViewModels;
using StaffApp.Views;

using System;

namespace StaffApp
{
    public partial class App
    {
        public App()
        {
            InitializeComponent();

            PushRegistration.CheckPermission();

            Current.MainPage = new AppShell();

        }

    }
}
