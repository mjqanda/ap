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

namespace Akyat.Pinas.MountainActivities
{
    [Activity(Theme = "@style/Theme.NoTitle", Label = "ayaasAct")]
    public class ayaasAct : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ayaasLayout);
            // Create your application here
        }
    }
}