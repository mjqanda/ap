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

namespace Akyat.Pinas.Activities
{
    [Activity(Theme = "@style/Theme.NoTitle",Label = "AboutUsAct", NoHistory = true)]
    public class AboutUsAct : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            RequestWindowFeature(WindowFeatures.NoTitle);

            SetContentView(Resource.Layout.aboutUsLayout);
            Button buttoo = FindViewById<Button>(Resource.Id.button1);
            base.OnCreate(savedInstanceState);
            buttoo.Click += Buttoo_Click;
            // Create your application here
        }

        private void Buttoo_Click(object sender, EventArgs e)
        {
            Finish();
        }
    }
}