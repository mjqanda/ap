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
        private TextView tmtname, tmtloc, tjumpoff, tdesc, tbackground, titinerary, tpracticalities;
        private ImageView mtimg;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.detailLayout);

            FindViews();

            Android.Content.Intent i = this.Intent;
            string iname = i.Extras.GetString("MTNAME");
            int iimg = i.Extras.GetInt("IMG");
            string ilocation = i.Extras.GetString("LOCATION");
            string ijumpoff = i.Extras.GetString("JUMPOFF");
            string idescription = i.Extras.GetString("DESCRIPTION");
            string ibackground = i.Extras.GetString("BACKGROUND");
            string iitinerary = i.Extras.GetString("ITINERARY");
            string ipracticalities = i.Extras.GetString("PRACTICALITIES");
           

            tmtname.Text = iname;
            mtimg.SetImageResource(iimg);
            tmtloc.Text = ilocation;
            tjumpoff.Text = ijumpoff;
            tdesc.Text = idescription;
            tbackground.Text = ibackground;
            titinerary.Text = iitinerary;
            tpracticalities.Text = ipracticalities;
         


            Button btnItinerary = FindViewById<Button>(Resource.Id.btnItinerary);
            btnItinerary.Click += ((sender, e) =>
            {
                DBItineraryRepository dbr = new DBItineraryRepository();
                var result = dbr.CreateDB();
                Toast.MakeText(this, result, ToastLength.Short).Show();



                var intent = new Intent(this, typeof(ItineraryAct));
                intent.PutExtra("name", iname);
                StartActivity(intent);

            });
        }

        private void FindViews()
        {
            tmtname = FindViewById<TextView>(Resource.Id.mtname);
            mtimg = FindViewById<ImageView>(Resource.Id.mtimg);
            tmtloc = FindViewById<TextView>(Resource.Id.locationtxt);
            tjumpoff = FindViewById<TextView>(Resource.Id.jumpofftxt);
            tdesc = FindViewById<TextView>(Resource.Id.descriptiontxt);
            tbackground = FindViewById<TextView>(Resource.Id.backgroundtxt);
            titinerary = FindViewById<TextView>(Resource.Id.itinerarytxt);
            tpracticalities = FindViewById<TextView>(Resource.Id.practicalitiestxt);

        }
    }
}