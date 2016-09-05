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

namespace Akyat.Pinas.MountainsActivities
{
    [Activity(Theme = "@style/Theme.NoTitle", Label = "daraitanAct")]
    public class daraitanAct : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.daraitanLayout);
            // Create your application here
        }
    }
}