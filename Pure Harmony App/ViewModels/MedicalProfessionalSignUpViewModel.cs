using Microsoft.Maui;
using Pure_Harmony_App.Models;
using Pure_Harmony_App.Service;
using System;

namespace Pure_Harmony_App.ViewModels
{
    public class MedicalProfessionalSignUpViewModel
    {
        private Localdatabase _localdatabase;

        public MedicalProfessionalSignUpViewModel(Localdatabase localdatabase)
        {
            _localdatabase = localdatabase;
        }

        public User newMedicalProfessional { get; private set; }

        public async Task SignUpMedicalProfessionalAsync(string name, string password, string email, string phoneNumber, string gender, string physicalAddress, DateTime dateOfBirth)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phoneNumber) ||
                string.IsNullOrEmpty(physicalAddress))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Please fill all fields", "OK");
                return;
            }

            var newUser = new MedicalProfessional()
            {
                Name = name,
                Password = password, // Hash passwords in a real application!
                Email = email,
                PhoneNumber = phoneNumber,
                Gender = gender,
                PhysicalAddress = physicalAddress,
                DateOfBirth = dateOfBirth,
                CreatedDate = DateTime.Now,
            };

            _localdatabase.InsertUser(newMedicalProfessional);
        }
    }
}
