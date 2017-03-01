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
    [Activity(Label = "EssentialsAct")]
    public class EssentialsAct : Activity
    {
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.essentials);

            Button btnLnt = FindViewById<Button>(Resource.Id.lntBtn);
            Button btnFirstaid = FindViewById<Button>(Resource.Id.firstaidBtn);

            btnLnt.Click += BtnLnt_Click;
            btnFirstaid.Click += BtnFirstaid_Click;

            // Create your application here
        }

        private void BtnLnt_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(LeaveNoTraceAct));
            StartActivity(intent);
            OverridePendingTransition(Resource.Animation.slide_right, Resource.Animation.fade_out);
        }

        private void BtnFirstaid_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(FirstAidAct));
            StartActivity(intent);
            OverridePendingTransition(Resource.Animation.slide_right, Resource.Animation.fade_out);
        }

        public override void OnBackPressed()
        {
            Finish();
            OverridePendingTransition(Resource.Animation.slide_left, Resource.Animation.fade_out);
        }

    }
    
}