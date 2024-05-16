using Microsoft.Extensions.Logging;
using Pure_Harmony_App.Pages;
using Pure_Harmony_App.Views.Template;

namespace Pure_Harmony_App
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<LoginView>();
            builder.Services.AddSingleton<PatientSignupPage>();
            builder.Services.AddSingleton<MedicalProfessionalSignupPage>();
            return builder.Build();
          

        }
    }
}
