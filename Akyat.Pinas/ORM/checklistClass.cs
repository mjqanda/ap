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
    [Table("Checklist")]
    public class ChecklistClass
    {

        [PrimaryKey, MaxLength(50)]
        public string ChecklistName { get; set; }

        [MaxLength(1)]
        public string Value { get; set; }
    }
}