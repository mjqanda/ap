using System;


using System.Data;
using System.IO;
using SQLite;
namespace Akyat.Pinas.ORM
{
    class DBItineraryRepository
    {
        // create database
        public string CreateDB()
        {
            var output = "";
            output += "";
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ormItinerary.db3");

            var db = new SQLiteConnection(dbPath);
            output += "";
            return output;
        }
        //create table.
        public string CreateTable()
        {
            try
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ormItinerary.db3");

                var db = new SQLiteConnection(dbPath);

                db.CreateTable<itineraryClass>();
                string result = "";
                return result;
            }
            catch(Exception ex)
            {
                return "Error: " + ex.Message;

            }
        }
        // insert record
        public string InsertRecord(string name, string itinerary)
        {
            try
            {
              
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ormItinerary.db3");

                var db = new SQLiteConnection(dbPath);
                itineraryClass item = new itineraryClass();

                item.MountainName = name;
               item.Itinerary = itinerary;
                
                db.Insert(item);
                return "Record Added";
            }
            catch(Exception ex)
            {
                return "You have already added your Itinerary";
            }
        }

        public string GetRecord(string name)
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ormItinerary.db3");
            var db = new SQLiteConnection(dbPath);
            string output = "";

            var item = db.Get<itineraryClass>(name);

           
                output += "\n" + item.Itinerary;
            
            return output;
        }
        public string UpdateRecord(string name, string itinerary)
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ormItinerary.db3");
            var db = new SQLiteConnection(dbPath);

            var item = db.Get<itineraryClass>(name);

            item.Itinerary = itinerary;
            db.Update(item);
            return "record updated";
        }

        public string CreateDBChecklist()
        {
            var output = "";
            output += "";
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ormChecklist.db3");

            var db = new SQLiteConnection(dbPath);
            output += "";
            return output;
        }

        public string CreateTableChecklist()
        {
            try
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ormChecklist.db3");

                var db = new SQLiteConnection(dbPath);

                db.CreateTable<checklistClass>();
                string result = "";
                return result;
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;

            }
        }

        public string InsertRecordChecklist(string name, string value)
        {
            try
            {

                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ormChecklist.db3");

                var db = new SQLiteConnection(dbPath);
                checklistClass item = new checklistClass();

                item.ChecklistName = name;
                item.Value = value;

                db.Insert(item);
                return "Checklist Saved";
            }
            catch (Exception ex)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ormChecklist.db3");
                var db = new SQLiteConnection(dbPath);

                var item = db.Get<checklistClass>(name);

                item.Value = value;
                db.Update(item);
                return "Checklist Saved";
            }
        }

        public string GetRecordChecklist(string name)
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ormChecklist.db3");
            var db = new SQLiteConnection(dbPath);
          string outputValue;

            var item = db.Get<checklistClass>(name);


            outputValue = item.Value;

            return outputValue;
        }


        public string CreateDBSettings()
        {
            var output = "";
            output += "";
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ormSettings.db3");

            var db = new SQLiteConnection(dbPath);
            output += "";
            return output;
        }
        public string CreateTableSettings()
        {
            try
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ormSettings.db3");

                var db = new SQLiteConnection(dbPath);

                db.CreateTable<settingsClass>();
                string result = "";
                return result;
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;

            }
        }
        public string InsertRecordSettings(string type, string value)
        {
            try
            {

                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ormSettings.db3");

                var db = new SQLiteConnection(dbPath);
                settingsClass item = new settingsClass();

                item.Maptype = type;
                item.Value = value;

                db.Insert(item);
                return "Settings Saved";
            }
            catch (Exception ex)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ormSettings.db3");
                var db = new SQLiteConnection(dbPath);

                var item = db.Get<settingsClass>(type);

                item.Value = value;
                db.Update(item);
                return "Settings Saved";
            }
        }

        public string GetRecordSettings(string type)
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ormSettings.db3");
            var db = new SQLiteConnection(dbPath);
            string outputValue;

            var item = db.Get<settingsClass>(type);


            outputValue = item.Value;

            return outputValue;
        }


    }
}