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

namespace Akyat.Pinas
{
    class Mountain
    {
        public string MtName { get; set; }
        public string MASL { get; set; }
        public string Difficulty { get; set;}
        public int ImgResourceId { get; set; }
    }
}