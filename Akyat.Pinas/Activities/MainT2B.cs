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
using Akyat.Pinas.ORM;
using System.IO;
using SQLite;

namespace Akyat.Pinas.Activities
{
    [Activity(Theme = "@style/Theme.NoTitle",Label = "MainT2B")]
    public class MainT2B : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MainT2BLayout);
            // Create your application here

            LinearLayout layoutLists = FindViewById<LinearLayout>(Resource.Id.layoutList);
            DBItineraryRepository dbr = new DBItineraryRepository();

            TextView Apo = FindViewById<TextView>(Resource.Id.Apo);
            Apo.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name","Apo");
                StartActivity(intent);
            };


            TextView AltoPeak = FindViewById<TextView>(Resource.Id.AltoPeak);
            AltoPeak.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "Alto Peak");
                StartActivity(intent);
            };
            TextView Arayat = FindViewById<TextView>(Resource.Id.Arayat);
            Arayat.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "Arayat");
                StartActivity(intent);
            }; TextView Banoi = FindViewById<TextView>(Resource.Id.Banoi);
            Banoi.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "Banoi");
                StartActivity(intent);
            }; TextView Batolusong = FindViewById<TextView>(Resource.Id.Batolusong);
            Batolusong.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "Batolusong");
                StartActivity(intent);
            }; TextView Batulao = FindViewById<TextView>(Resource.Id.Batulao);
            Batulao.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "Batulao");
                StartActivity(intent);
            }; TextView Binacayan = FindViewById<TextView>(Resource.Id.Binacayan);
            Binacayan.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "Binacayan");
                StartActivity(intent);
            }; TextView Candalaga = FindViewById<TextView>(Resource.Id.Candalaga);
            Candalaga.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "Candalaga");
                StartActivity(intent);
            }; TextView Cristobal = FindViewById<TextView>(Resource.Id.Cristobal);
            Cristobal.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "Cristobal");
                StartActivity(intent);
            }; TextView DulangDulang = FindViewById<TextView>(Resource.Id.DulangDulang);
            DulangDulang.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "Dulang Dulang");
                StartActivity(intent);
            }; TextView GuitingGuiting = FindViewById<TextView>(Resource.Id.GuitingGuiting);
            GuitingGuiting.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "GuitingGuiting");
                StartActivity(intent);
            }; TextView Halcon = FindViewById<TextView>(Resource.Id.Halcon);
            Halcon.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "Halcon");
                StartActivity(intent);
            }; TextView Hamiguitan = FindViewById<TextView>(Resource.Id.Hamiguitan);
            Hamiguitan.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "Hamiguitan");
                StartActivity(intent);
            }; TextView HibokHibok = FindViewById<TextView>(Resource.Id.HibokHibok);
            HibokHibok.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "HibokHibok");
                StartActivity(intent);
            }; TextView Kalatungan = FindViewById<TextView>(Resource.Id.Kalatungan);
            Kalatungan.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "Kalatungan");
                StartActivity(intent);
            }; TextView Kanlaon = FindViewById<TextView>(Resource.Id.Kanlaon);
            Kanlaon.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "Kanlaon");
                StartActivity(intent);
            }; TextView Kitanglad = FindViewById<TextView>(Resource.Id.Kitanglad);
            Kitanglad.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "Kitanglad");
                StartActivity(intent);
            }; TextView Lubog = FindViewById<TextView>(Resource.Id.Lubog);
            Lubog.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "Lubog");
                StartActivity(intent);
            }; TextView Maculot = FindViewById<TextView>(Resource.Id.Maculot);
            Maculot.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "Maculot");
                StartActivity(intent);
            }; TextView Madjaas = FindViewById<TextView>(Resource.Id.Madjaas);
            Madjaas.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "Madjaas");
                StartActivity(intent);
            }; TextView Makiling = FindViewById<TextView>(Resource.Id.Makiling);
            Makiling.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "Makiling");
                StartActivity(intent);
            }; TextView ManabuPeak = FindViewById<TextView>(Resource.Id.ManabuPeak);
            ManabuPeak.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "ManabuPeak");
                StartActivity(intent);
            }; TextView Mantalingajan = FindViewById<TextView>(Resource.Id.Matalingajan);
            Mantalingajan.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "Mantalingajan");
                StartActivity(intent);
            }; TextView Marami = FindViewById<TextView>(Resource.Id.Marami);
            Marami.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "Marami");
                StartActivity(intent);
            }; TextView Matutum = FindViewById<TextView>(Resource.Id.Matutum);
            Matutum.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "Matutum");
                StartActivity(intent);
            }; TextView Napulak = FindViewById<TextView>(Resource.Id.Napulak);
            Napulak.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "Napulak");
                StartActivity(intent);
            }; TextView OsmenaPeak = FindViewById<TextView>(Resource.Id.OsmenaPeak);
            OsmenaPeak.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "Osmena Peak");
                StartActivity(intent);
            }; TextView Pamitinan = FindViewById<TextView>(Resource.Id.Pamitinan);
            Pamitinan.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "Pamitinan");
                StartActivity(intent);
            }; TextView PicoDeLoro = FindViewById<TextView>(Resource.Id.PicoDeLoro);
            PicoDeLoro.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "PicoDeLoro");
                StartActivity(intent);
            }; TextView Pulag = FindViewById<TextView>(Resource.Id.Pulag);
            Pulag.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "Pulag");
                StartActivity(intent);
            }; TextView Romelo = FindViewById<TextView>(Resource.Id.Romelo);
            Romelo.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "Romelo");
                StartActivity(intent);
            }; TextView Taal = FindViewById<TextView>(Resource.Id.Taal);
            Taal.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "Taal");
                StartActivity(intent);
            }; TextView Talamitam = FindViewById<TextView>(Resource.Id.Talamitam);
            Talamitam.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "Talamitam");
                StartActivity(intent);
            }; TextView Talomo = FindViewById<TextView>(Resource.Id.Talomo);
            Talomo.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "Talomo");
                StartActivity(intent);
            };
            TextView TarakRidge = FindViewById<TextView>(Resource.Id.TarakRidge);
            TarakRidge.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "TarakRidge");
                StartActivity(intent);
            };
            TextView TayakHill = FindViewById<TextView>(Resource.Id.TayakHill);
            TayakHill.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "TayakHill");
                StartActivity(intent);
            };
            TextView TresMarias = FindViewById<TextView>(Resource.Id.TresMarias);
            TresMarias.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "TresMarias");
                StartActivity(intent);
            };
            TextView Ulap = FindViewById<TextView>(Resource.Id.Ulap);
            Ulap.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "Ulap");
                StartActivity(intent);
            };
            TextView Victoria = FindViewById<TextView>(Resource.Id.Victoria);
            Victoria.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "Victoria");
                StartActivity(intent);
            };
            TextView WhitePeak = FindViewById<TextView>(Resource.Id.WhitePeak);
            WhitePeak.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(listsActivity));
                intent.PutExtra("name", "WhitePeak");
                StartActivity(intent);
            };
          






        }

    }
}