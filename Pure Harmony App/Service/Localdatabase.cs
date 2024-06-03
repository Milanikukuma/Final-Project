using Newtonsoft.Json;
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

            _dbConnection.CreateTable<User>();
            _dbConnection.CreateTable<UserType>();

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
            if (_dbConnection.Table<UserType>().Count() == 0)
            {
                _dbConnection.Insert(new UserType { TypeName = "Patient" });
                _dbConnection.Insert(new UserType { TypeName = "MedicalProfessional" });
            }
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

        // Removed the incorrect usage of GetUserTypes here

        public List<UserType> GetUserTypes()
        {
            return _dbConnection.Table<UserType>().ToList();
        }

    }
}
