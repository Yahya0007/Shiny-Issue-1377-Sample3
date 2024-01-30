using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DevExpress.Data.Linq.Helpers;
using Shiny.Push;
using StaffApp;


public class PushDelegate : IPushDelegate
{
    public Task OnEntry(PushNotification notification)
    {

        string Title = "";
        string Message = "";

        try
        {
            Title = notification.Notification?.Title ?? "Empty Title";
            Message = notification.Notification?.Message ?? "Empty Message";

        }
        catch (Exception ex)
        {
        }

        MainThread.BeginInvokeOnMainThread(async () =>
        {
            await Application.Current.MainPage.DisplayAlert(
                Title,
                Message,
                "OK");
        });

        return null;
    }

    public async Task OnReceived(PushNotification notification)
    {
        string Title="";
        string Message = "";

        try
        {
            Title = notification.Notification?.Title ?? "Empty Title";
            Message = notification.Notification?.Message ?? "Empty Message";

        }
        catch (Exception ex)
        {
        }

        MainThread.BeginInvokeOnMainThread(async () =>
        {
            await Application.Current.MainPage.DisplayAlert(
                Title,
                Message,
                "OK");
        });

    }

    public async Task OnTokenRefreshed(string token)
    {
        Preferences.Set("PushNotificationsToken", token);

        await Shell.Current.DisplayAlert("OnTokenRefreshed", "Token: " + token, "OK");

    }
}