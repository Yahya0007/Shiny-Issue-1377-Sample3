using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Shiny;
using Shiny.Hosting;
using Shiny.Push;
using StaffApp;

public static class PushRegistration
{
    public static async Task CheckPermission()
    {
        var push = Host.Current.Services.GetService<IPushManager>();
        var result = await push.RequestAccess();

        if (result.Status == AccessState.Available)
        {
            var token = result.RegistrationToken;

            Debug.WriteLine("Token: " + token);

            Preferences.Set("PushNotificationsToken", token);

            await Shell.Current.DisplayAlert("OnTokenRefreshed", "Token: " + token, "OK");

        }
    }
}