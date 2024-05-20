using Pure_Harmony_App.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;

namespace Pure_Harmony_App.Service
{
    public class Localdatabase
    {
        private SQLiteConnection _dbConnection;

        public Localdatabase()
        {
            _dbConnection = new SQLiteConnection(GetDatabasePath());
            _dbConnection.CreateTable<Patient>();
            _dbConnection.CreateTable<User>();

            SeedPatientDatabase();
        }

        public string GetDatabasePath()
        {
            string filename = "Medicaldata.db";
            string pathToDb = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            return Path.Combine(pathToDb, filename);
        }

        public void SeedPatientDatabase()
        {
            if (_dbConnection.Table<Patient>().Count() == 0)
            {
                Patient patient = new Patient()
                {
                    FirstName = "John",
                    LastName = "Doe",
                    DateOfBirth = new DateTime(1980, 5, 15),
                    Gender = Gender.Male,
                    Email = "john.doe@example.com",
                    PhoneNumber = "123-456-7890",
                    Address = "123 Main Street, Anytown, USA"
                };

                _dbConnection.Insert(patient);

                // You can add more patients here if needed
            }
        }

        public void AddPatient(Patient patient)
        {
            _dbConnection.Insert(patient);
        }

        public List<Patient> GetAllPatients()
        {
            return _dbConnection.Table<Patient>().ToList();
        }

        public Patient GetPatientById(int PatientId)
        {
            return _dbConnection.Table<Patient>().Where(p => p.PatientID == PatientId).FirstOrDefault();
        }

        public void UpdatePatient(Patient patient)
        {
            _dbConnection.Update(patient);
        }

        public void DeletePatient(int PatientId)
        {
            _dbConnection.Delete<Patient>(PatientId);
        }

        public User ValidateUserNameAndPassword(string userName, string password)
        {
           var user =  _dbConnection.Table<User>().Where(x => x.Username == userName && x.Password == password).FirstOrDefault();

            return user;
        }
        
    }
}
