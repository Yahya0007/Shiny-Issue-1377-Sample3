//using CommunityToolkit.Maui;
using DevExpress.Maui;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Compatibility.Hosting;
using Shiny;
//using Syncfusion.Maui.Core.Hosting;

namespace StaffApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>()
                .UseShiny()
            .ConfigureEffects((effects) =>
                {
                    effects.AddCompatibilityEffects(AppDomain.CurrentDomain.GetAssemblies());
                })                ;

            DevExpress.Maui.CollectionView.Initializer.Init();
            DevExpress.Maui.Controls.Initializer.Init();
            DevExpress.Maui.Editors.Initializer.Init();

            builder.Services.AddPush<PushDelegate>(
#if ANDROID
    new Shiny.Push.FirebaseConfig(
        false, // false to ignore embedded configuration
        "1:33retretret796911:android:b23148rtrerte50c1a", // appid
        "33676796911", // sender id/project_number
        "app-maui-3-1", // project_id
        "AIzaerewwerewmGEreretrGcrtret_ertrekLQs0" // api_key
    )
#endif

);
            return builder.Build();
        }
    }
}