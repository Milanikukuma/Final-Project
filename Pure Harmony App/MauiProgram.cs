﻿using Microsoft.Extensions.Logging;
using Pure_Harmony_App.Pages;
using Pure_Harmony_App.Service;
using Pure_Harmony_App.ViewModels;
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
            builder.Services.AddTransient<LoginView>();
            builder.Services.AddTransient<PatientSignUpPage>();
            
            builder.Services.AddSingleton<Localdatabase>();
            
            builder.Services.AddTransient<LoginViewModel>();
            builder.Services.AddTransient<SignUpViewModel>();


            return builder.Build();
          

        }
    }
}
