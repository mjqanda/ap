using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using System.Data;
using System.IO;
using SQLite;
namespace Akyat.Pinas.ORM
{
   
    [Table("Itinerary")]

  

    public class itineraryClass
    {
      
        [PrimaryKey, MaxLength(50)]
        public string MountainName { get; set; }

        [MaxLength(10000)]
        public string Itinerary { get; set; }
    }
}