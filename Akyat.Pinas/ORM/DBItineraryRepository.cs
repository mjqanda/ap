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
                return "Itinerary Added";
            }
            catch(Exception ex)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ormItinerary.db3");
                var db = new SQLiteConnection(dbPath);

                var item = db.Get<itineraryClass>(name);

                item.Itinerary = itinerary;
                db.Update(item);
                return "Itinerary Updated";
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
            return "Itinerary Updated";
        }

        public string CreateDBChecklist()
        {
            var output = "";
            output += "";
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ormItinerary.db3");
            var db = new SQLiteConnection(dbPath);
            output += "";
            return output;
        }

        public string CreateTableChecklist()
        {
            try
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ormItinerary.db3");

                var db = new SQLiteConnection(dbPath);

                db.CreateTable<ChecklistClass>();
                string result = "";
                return result;
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;

            }
        }

        public string InsertRecordChecklist(string name, 
            string backpackValue,
            string bootsValue,
            string plasticbagValue,
            string toiletriesValue,
            string outdoorclothesValue,
            string trailfoodValue,
            string packedlunchValue,
            string trailwaterValue,
            string firstaidkitValue,
            string survivalkitValue,
            string messkitValue,
            string drinkingcupValue,
            string spoonforkValue,
       
            string identificationValue,
            string whistleValue,
            string raingearValue,
            string jacketValue,
            string sunprotectionValue,
            string flashlightValue,
            string multitoolValue,
            string mobilephoneValue,
            string camerabatteriesValue,
            string trekkingpoleValue,
            string blanketValue,
            string extraclothesValue,
            string sandalsValue,
            string campwaterValue,
            string precookfoodValue,
            string riceValue,
            string tyingstringValue,
            string stovefuelValue,
            string lighterValue,
            string matchesValue,
            string boloValue,
            string mapcompassValue,
            string stoveValue,
            string cooksetValue,
            string flagValue,
            string tentValue,
            string groundsheetValue,
            string ropeValue,
            string trowelValue,
            string othersValue  )
        {
            try
            {

                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ormItinerary.db3");

                var db = new SQLiteConnection(dbPath);
                ChecklistClass item = new ChecklistClass();

                 item.Name = name;
                item.backpackValue = backpackValue;
                item.bootsValue = bootsValue;
                item.plasticbagValue = plasticbagValue;
                item.toiletriesValue = toiletriesValue;
                item.outdoorclothesValue = outdoorclothesValue;
                item.trailfoodValue = trailfoodValue;
                item.packedlunchValue = packedlunchValue;
                item.trailwaterValue = trailwaterValue;
                item.firstaidkitValue = firstaidkitValue;
                item.survivalkitValue = survivalkitValue;
                item.messkitValue = messkitValue;
                item.drinkingcupValue = drinkingcupValue;
                item.spoonforkValue = spoonforkValue;
                item.identificationValue = identificationValue;
                item.whistleValue = whistleValue;
                item.raingearValue = raingearValue;
                item.jacketValue = jacketValue;
                item.sunprotectionValue = sunprotectionValue;
                item.flashlightValue = flashlightValue;
                item.multitoolValue = multitoolValue;
                item.mobilephoneValue = mobilephoneValue;
                item.camerabatteriesValue = camerabatteriesValue;
                item.trekkingpoleValue = trekkingpoleValue;
                item.blanketValue = blanketValue;
                item.extraclothesValue = extraclothesValue;
                item.sandalsValue = sandalsValue;
                item.campwaterValue = campwaterValue;
                item.precookfoodValue = precookfoodValue;
                item.riceValue = riceValue;
                item.tyingstringValue = tyingstringValue;
                item.stovefuelValue = stovefuelValue;
                item.lighterValue = lighterValue;
                item.matchesValue = matchesValue;
                item.boloValue = boloValue;
                item.mapcompassValue = mapcompassValue;
                item.stoveValue = stoveValue;
                item.cooksetValue = cooksetValue;
                item.flagValue = flagValue;
                item.tentValue = tentValue;
                item.groundsheetValue = groundsheetValue;
                item.ropeValue = ropeValue;
                item.trowelValue = trowelValue;
                item.othersValue = othersValue;




                db.Insert(item);
                return "Checklist Saved";
            }
            catch (Exception ex)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ormItinerary.db3");
                var db = new SQLiteConnection(dbPath);

                var item = db.Get<ChecklistClass>(name);

                item.Name = name;
                item.backpackValue = backpackValue;
                item.bootsValue = bootsValue;
                item.plasticbagValue = plasticbagValue;
                item.toiletriesValue = toiletriesValue;
                item.outdoorclothesValue = outdoorclothesValue;
                item.trailfoodValue = trailfoodValue;
                item.packedlunchValue = packedlunchValue;
                item.trailwaterValue = trailwaterValue;
                item.firstaidkitValue = firstaidkitValue;
                item.survivalkitValue = survivalkitValue;
                item.messkitValue = messkitValue;
                item.drinkingcupValue = drinkingcupValue;
                item.spoonforkValue = spoonforkValue;
                item.identificationValue = identificationValue;
                item.whistleValue = whistleValue;
                item.raingearValue = raingearValue;
                item.jacketValue = jacketValue;
                item.sunprotectionValue = sunprotectionValue;
                item.flashlightValue = flashlightValue;
                item.multitoolValue = multitoolValue;
                item.mobilephoneValue = mobilephoneValue;
                item.camerabatteriesValue = camerabatteriesValue;
                item.trekkingpoleValue = trekkingpoleValue;
                item.blanketValue = blanketValue;
                item.extraclothesValue = extraclothesValue;
                item.sandalsValue = sandalsValue;
                item.campwaterValue = campwaterValue;
                item.precookfoodValue = precookfoodValue;
                item.riceValue = riceValue;
                item.tyingstringValue = tyingstringValue;
                item.stovefuelValue = stovefuelValue;
                item.lighterValue = lighterValue;
                item.matchesValue = matchesValue;
                item.boloValue = boloValue;
                item.mapcompassValue = mapcompassValue;
                item.stoveValue = stoveValue;
                item.cooksetValue = cooksetValue;
                item.flagValue = flagValue;
                item.tentValue = tentValue;
                item.groundsheetValue = groundsheetValue;
                item.ropeValue = ropeValue;
                item.trowelValue = trowelValue;
                item.othersValue = othersValue;


                db.Update(item);
                return "Checklist Saved";
            }
        }

        public object GetRecordChecklist(string name)
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ormItinerary.db3");
            var db = new SQLiteConnection(dbPath);
          string outputValue= "";

            var item = db.Get<ChecklistClass>(name);


       //     outputValue = item.Value;

            return item;
        }
        public object GetRecordPapel()
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ormItinerary.db3");
            var db = new SQLiteConnection(dbPath);
            string outputValue = "";

            var items = db.Table<ChecklistClass>();
            // var items = db.Query<ChecklistClass>("SELECT ChecklistName FROM Checklist");
         //   var other = db.Query<ChecklistClass>("SELECT Value From Checklist WHERE ChecklistName = ?", "others");
            

          //  foreach (var item in items)
          //  {
          //    outputValue += item.ChecklistName + "\n";
               
         //   }
        //    foreach(var item in other)
        //    { 
         //   outputValue += "Others: " + "\n" + item.Value;
        //    }

            return items;
        }


        public string CreateDBSettings()
        {
            var output = "";
            output += "";
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ormItinerary.db3");

            var db = new SQLiteConnection(dbPath);
            output += "";
            return output;
        }
        public string CreateTableSettings()
        {
            try
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ormItinerary.db3");

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

                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ormItinerary.db3");

                var db = new SQLiteConnection(dbPath);
                settingsClass item = new settingsClass();

                item.Maptype = type;
                item.Value = value;

                db.Insert(item);
                return "Settings Saved";
            }
            catch (Exception ex)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ormItinerary.db3");
                var db = new SQLiteConnection(dbPath);

                var item = db.Get<settingsClass>(type);

                item.Value = value;
                db.Update(item);
                return "Settings Saved";
            }
        }

        public string GetRecordSettings(string type)
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ormItinerary.db3");
            var db = new SQLiteConnection(dbPath);
            string outputValue;

            var item = db.Get<settingsClass>(type);


            outputValue = item.Value;

            return outputValue;
        }


       
            
        }
        










    
}





