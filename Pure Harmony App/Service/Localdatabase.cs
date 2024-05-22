using Pure_Harmony_App.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
            _dbConnection.CreateTable<UserType>();
            _dbConnection.CreateTable<MedicalProfessional>();

            SeedDatabase();
        }

        public string GetDatabasePath()
        {
            string filename = "Medicaldata.db";
            string pathToDb = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            return Path.Combine(pathToDb, filename);
        }

        public void SeedDatabase()
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
            }

            if (_dbConnection.Table<MedicalProfessional>().Count() == 0)
            {
                MedicalProfessional medicalProfessional = new MedicalProfessional()
                {
                    MedicalProfessionalID = 0,
                    Name = "",
                    Specialty = "",



                };
            }
            if(_dbConnection.Table<UserType>().Count() == 0)
            {
                UserType userType = new UserType()
                {
                    UserTypeId = 1,
                    TypeName = "user",
                };
                _dbConnection.Insert(userType);
            };
        }

        // CRUD operations for User table

       

        public List<User> GetAllUsers()
        {
            return _dbConnection.Table<User>().ToList();
        }

        public User GetUserById(int userId)
        {
            return _dbConnection.Table<User>().Where(u => u.UserID == userId).FirstOrDefault();
        }
        public void InsertUser(User user)
        {
            _dbConnection.Insert(user);
        }


      /*ublic void GetUserTypeId(int UserTypeId)
        {
            return _dbConnection.Table<UserType>().Where(u => u.UserTypeId == GetUserTypeId).FirstOrDefault();
        }
      */
        
        public void UpdateUser(User user)
        {
            _dbConnection.Update(user);
        }

        public void DeleteUser(int userId)
        {
            _dbConnection.Delete<User>(userId);
        }

        public User ValidateUserNameAndPassword(string Email, string password)
        {
            return _dbConnection.Table<User>().Where(x => x.Email == Email && x.Password == password).FirstOrDefault();
        }
    }
}
