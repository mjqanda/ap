using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace Akyat.Pinas.Activities
{
    [Activity(Label = "SnakeBiteAct")]
    public class SnakeBiteAct : Activity
    {
        TextView vsbtitle,vsbtitledesc, vdescription1, vdescription2, vdescription3, vdescription4, vdescription5, vdescription6, vdescription7, vdescription8, vdescription9, vdescription10;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            RequestWindowFeature(WindowFeatures.NoTitle);
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.snakebiteLayout);
            // Create your application here
            FindViews();

            Android.Content.Intent i = this.Intent;

            string sbtitle = i.Extras.GetString("TITLE");
            string sbtitledesc = i.Extras.GetString("TITLEDESC");
            string sbdesc1 = i.Extras.GetString("Description1");
            string sbdesc2 = i.Extras.GetString("Description2");
            string sbdesc3 = i.Extras.GetString("Description3");
            string sbdesc4 = i.Extras.GetString("Description4");
            string sbdesc5 = i.Extras.GetString("Description5");
            string sbdesc6 = i.Extras.GetString("Description6");
            string sbdesc7 = i.Extras.GetString("Description7");
            string sbdesc8 = i.Extras.GetString("Description8");
            string sbdesc9 = i.Extras.GetString("Description9");
            string sbdesc10 = i.Extras.GetString("Description10");


            vsbtitle.Text = sbtitle;
            vsbtitledesc.Text = sbtitledesc;
            vdescription1.Text = sbdesc1;
            vdescription2.Text = sbdesc2;
            vdescription3.Text = sbdesc3;
            vdescription4.Text = sbdesc4;
            vdescription5.Text = sbdesc5;
            vdescription6.Text = sbdesc6;
            vdescription7.Text = sbdesc7;
            vdescription8.Text = sbdesc8;
            vdescription9.Text = sbdesc9;
            vdescription10.Text = sbdesc10;
        }
        public override void OnBackPressed()
        {
            Finish();
            OverridePendingTransition(Resource.Animation.slide_left, Resource.Animation.fade_out);
        }
        private void FindViews()
        {
            vsbtitle = FindViewById<TextView>(Resource.Id.sbtitle);
            vsbtitledesc = FindViewById<TextView>(Resource.Id.sbdesc);
            vdescription1 = FindViewById<TextView>(Resource.Id.sbdesc1);
            vdescription2= FindViewById<TextView>(Resource.Id.sbdesc2);
            vdescription3 = FindViewById<TextView>(Resource.Id.sbdesc3);
            vdescription4 = FindViewById<TextView>(Resource.Id.sbdesc4);
            vdescription5 = FindViewById<TextView>(Resource.Id.sbdesc5);
            vdescription6 = FindViewById<TextView>(Resource.Id.sbdesc6);
            vdescription7 = FindViewById<TextView>(Resource.Id.sbdesc7);
            vdescription8 = FindViewById<TextView>(Resource.Id.sbdesc8);
            vdescription9 = FindViewById<TextView>(Resource.Id.sbdesc9);
            vdescription10 = FindViewById<TextView>(Resource.Id.sbdesc10);
        }
    }
}