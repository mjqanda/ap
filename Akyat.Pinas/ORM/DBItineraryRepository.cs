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
            output += "Creating database if it doesnt exist.";
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ormItinerary.db3");

            var db = new SQLiteConnection(dbPath);
            output += "\nDatabase Created...";
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
                string result = "table created successfully..";
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
                db.Insert(name);
                db.Insert(itinerary);
                return "Record Added";
            }
            catch(Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

    }
}