using Android.App;
using Android.OS;
using Android.Widget;
using Akyat.Pinas;
using Akyat.Pinas.ORM;
using Android.Content;

namespace Akyat.Pinas
{
    [Activity(Label = "DetailActivity", Theme = "@style/Theme.NoTitle")]
    public class DetailActivity : Activity
    {
        private TextView dmtname, dmtloc1, dmtloc2, ddesc1, ddesc2, dtrail1, dtrail2, dite1, dite2;
        private ImageView dmtimg;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.detailLayout);

            dmtname = FindViewById<TextView>(Resource.Id.mtname);
            dmtimg = FindViewById<ImageView>(Resource.Id.mtimg);
            dmtloc1 = FindViewById<TextView>(Resource.Id.mtlocation1);
            dmtloc2 = FindViewById<TextView>(Resource.Id.mtlocation2);
            ddesc1 = FindViewById<TextView>(Resource.Id.description1);
            ddesc2 = FindViewById<TextView>(Resource.Id.description2);
            dtrail1 = FindViewById<TextView>(Resource.Id.trail1);
            dtrail2 = FindViewById<TextView>(Resource.Id.trail2);
            dite1 = FindViewById<TextView>(Resource.Id.iterenary1);
            dite2 = FindViewById<TextView>(Resource.Id.iterenary2);

            Android.Content.Intent i = this.Intent;
            string name = i.Extras.GetString("MTNAME");
            int img = i.Extras.GetInt("IMG");
            string loc01 = i.Extras.GetString("MTLOC01");
            string loc02 = i.Extras.GetString("MTLOC02");
            string desc01 = i.Extras.GetString("DESC01");
            string desc02 = i.Extras.GetString("DESC02");
            string trail01 = i.Extras.GetString("TRAIL01");
            string trail02 = i.Extras.GetString("TRAIL02");
            string ite01 = i.Extras.GetString("ITERENARY01");
            string ite02 = i.Extras.GetString("ITERENARY02");

            dmtname.Text = name;
            dmtimg.SetImageResource(img);
            dmtloc1.Text = loc01;
            dmtloc2.Text = loc02;
            ddesc1.Text = desc01;
            ddesc2.Text = desc02;
            dtrail1.Text = trail01;
            dtrail2.Text = trail02;
            dite1.Text = ite01;
            dite2.Text = ite02;


            Button btnItinerary = FindViewById<Button>(Resource.Id.btnItinerary);
            btnItinerary.Click += ((sender, e) =>
            {
                DBItineraryRepository dbr = new DBItineraryRepository();
                var result = dbr.CreateDB();
                Toast.MakeText(this, result, ToastLength.Short).Show();



                var intent = new Intent(this, typeof(itineraryAct));
                intent.PutExtra("name", name);
                StartActivity(intent);

            });


        }
    }
}