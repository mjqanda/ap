using Android.App;
using Android.OS;
using Android.Widget;
using Akyat.Pinas;
using Akyat.Pinas.ORM;
using Android.Content;
using Android.Graphics;

namespace Akyat.Pinas
{
    [Activity(Label = "DetailActivity", Theme = "@style/Theme.NoTitle")]
    public class DetailActivity : Activity
    {
        private TextView tmtname, tmtloc, tjumpoff, tdesc, tbackground, titinerary, tpracticalities,tattire,tttb,tsga,tsgt,tnote;
        private ImageView mtimg0, mtimg1, mtimg2, mtimg3, mtimg4, mtimg5;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.detailLayout);


            FindViews();
            Typeface tf = Typeface.CreateFromAsset(Assets, "REFSAN.TTF");
            tmtname.SetTypeface(tf, TypefaceStyle.Normal);
            tmtloc.SetTypeface(tf, TypefaceStyle.Normal);
            tjumpoff.SetTypeface(tf, TypefaceStyle.Normal);
            tdesc.SetTypeface(tf, TypefaceStyle.Normal);
            tbackground.SetTypeface(tf, TypefaceStyle.Normal);
            titinerary.SetTypeface(tf, TypefaceStyle.Normal);
            tpracticalities.SetTypeface(tf, TypefaceStyle.Normal);
            tattire.SetTypeface(tf, TypefaceStyle.Normal);
            tttb.SetTypeface(tf, TypefaceStyle.Normal);
            tsga.SetTypeface(tf, TypefaceStyle.Normal);
            tsgt.SetTypeface(tf, TypefaceStyle.Normal);
            tnote.SetTypeface(tf, TypefaceStyle.Normal);



            Android.Content.Intent i = this.Intent;
            string iname = i.Extras.GetString("MTNAME");
            int iimg0 = i.Extras.GetInt("IMG0");
            int iimg1 = i.Extras.GetInt("IMG1");
            int iimg2 = i.Extras.GetInt("IMG2");
            int iimg3 = i.Extras.GetInt("IMG3");
            int iimg4 = i.Extras.GetInt("IMG4");
            int iimg5 = i.Extras.GetInt("IMG5");
            string ilocation = i.Extras.GetString("LOCATION");
            string ijumpoff = i.Extras.GetString("JUMPOFF");
            string idescription = i.Extras.GetString("DESCRIPTION");
            string ibackground = i.Extras.GetString("BACKGROUND");
            string iitinerary = i.Extras.GetString("ITINERARY");
            string ipracticalities = i.Extras.GetString("PRACTICALITIES");
            string iattire = i.Extras.GetString("ATTIRE");
            string ittb = i.Extras.GetString("TTB");
            string inote = i.Extras.GetString("NOTE");

            tmtname.Text = iname;
            mtimg0.SetImageResource(iimg0);
            mtimg1.SetImageResource(iimg1);
            mtimg2.SetImageResource(iimg2);
            mtimg3.SetImageResource(iimg3);
            mtimg4.SetImageResource(iimg4);
            mtimg5.SetImageResource(iimg5);
            tmtloc.Text = ilocation;
            tjumpoff.Text = ijumpoff;
            tdesc.Text = idescription;
            tbackground.Text = ibackground;
            titinerary.Text = iitinerary;
            tpracticalities.Text = ipracticalities;
            tattire.Text = iattire;
            tttb.Text = ittb;
            tnote.Text = inote;
         


            Button btnItinerary = FindViewById<Button>(Resource.Id.btnItinerary);
            btnItinerary.Click += ((sender, e) =>
            {
                DBItineraryRepository dbr = new DBItineraryRepository();
                var result = dbr.CreateTable();
                
                var intent = new Intent(this, typeof(itineraryAct));
                intent.PutExtra("name", iname);
              
                StartActivity(intent);

            });
        }

        private void FindViews()
        {
            tmtname = FindViewById<TextView>(Resource.Id.mtname);
            mtimg0 = FindViewById<ImageView>(Resource.Id.mtimg00); 
            mtimg1 = FindViewById<ImageView>(Resource.Id.mtimg01);
            mtimg2 = FindViewById<ImageView>(Resource.Id.mtimg02);
            mtimg3 = FindViewById<ImageView>(Resource.Id.mtimg03);
            mtimg4 = FindViewById<ImageView>(Resource.Id.mtimg04);
            mtimg5 = FindViewById<ImageView>(Resource.Id.mtimg05);
            tmtloc = FindViewById<TextView>(Resource.Id.locationtxt);
            tjumpoff = FindViewById<TextView>(Resource.Id.jumpofftxt);
            tdesc = FindViewById<TextView>(Resource.Id.descriptiontxt);
            tbackground = FindViewById<TextView>(Resource.Id.backgroundtxt);
            titinerary = FindViewById<TextView>(Resource.Id.itinerarytxt);
            tpracticalities = FindViewById<TextView>(Resource.Id.practicalitiestxt);
            tattire = FindViewById<TextView>(Resource.Id.attiretxt);
            tttb = FindViewById<TextView>(Resource.Id.ttbtxt);
            tsga = FindViewById<TextView>(Resource.Id.sgatxt);
            tsgt = FindViewById<TextView>(Resource.Id.sgttxt);
            tnote = FindViewById<TextView>(Resource.Id.notetxt);
        }
    }
}