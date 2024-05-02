﻿using Pure_Harmony_App.Pages;

namespace Pure_Harmony_App
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnPatientClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUpPageOfPatient());
        }

        private void OnHealthProfessionalClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUpPageOfHealthProfessional());
        }
    }


}


