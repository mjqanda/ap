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
using Java.Security;
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
            string button = Intent.GetStringExtra("button");
            Apo.Click += (sender, e) =>
            {
               if (button == "ttb") { 
                var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "APO");
                    StartActivity(intent);
                }

               else if (button == "iti")
               {
                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "APO");
                    StartActivity(intent);
                }
               
                SlideRightAnim();
            };

            TextView AltoPeak = FindViewById<TextView>(Resource.Id.AltoPeak);
            AltoPeak.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "ALTO PEAK");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "ALTO PEAK");
                    StartActivity(intent);
                }

                SlideRightAnim();
            };
            TextView Arayat = FindViewById<TextView>(Resource.Id.Arayat);
            Arayat.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "ARAYAT");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "ARAYAT");
                    StartActivity(intent);
                }

                SlideRightAnim();
            }; TextView Banoi = FindViewById<TextView>(Resource.Id.Banoi);
            Banoi.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "BANOI");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "BANOI");
                    StartActivity(intent);
                }

                SlideRightAnim();
            }; TextView Batolusong = FindViewById<TextView>(Resource.Id.Batolusong);
            Batolusong.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "BATOLUSONG");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "BATOLUSONG");
                    StartActivity(intent);
                }

                SlideRightAnim();
            }; TextView Batulao = FindViewById<TextView>(Resource.Id.Batulao);
            Batulao.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "BATULAO");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "BATULAO");
                    StartActivity(intent);
                }

                SlideRightAnim();
            }; TextView Binacayan = FindViewById<TextView>(Resource.Id.Binacayan);
            Binacayan.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "BINACAYAN");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "BINACAYAN");
                    StartActivity(intent);
                }

                SlideRightAnim();
            }; TextView Candalaga = FindViewById<TextView>(Resource.Id.Candalaga);
            Candalaga.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "CANDALAGA");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "CANDALAGA");
                    StartActivity(intent);
                }

                SlideRightAnim();
            }; TextView Cristobal = FindViewById<TextView>(Resource.Id.Cristobal);
            Cristobal.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "CRISTOBAL");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "CRISTOBAL");
                    StartActivity(intent);
                }

                SlideRightAnim();
            }; TextView DulangDulang = FindViewById<TextView>(Resource.Id.DulangDulang);
            DulangDulang.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "DULANG-DULANG");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "DULANG-DULANG");
                    StartActivity(intent);
                }

                SlideRightAnim();
            }; TextView GuitingGuiting = FindViewById<TextView>(Resource.Id.GuitingGuiting);
            GuitingGuiting.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "GUITING-GUITING");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "GUITING-GUITING");
                    StartActivity(intent);
                }

                SlideRightAnim();
            }; TextView Halcon = FindViewById<TextView>(Resource.Id.Halcon);
            Halcon.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "HALCON");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "HALCON");
                    StartActivity(intent);
                }

                SlideRightAnim();
            }; TextView Hamiguitan = FindViewById<TextView>(Resource.Id.Hamiguitan);
            Hamiguitan.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "HAMIGUITAN");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "HAMIGUITAN");
                    StartActivity(intent);
                }

                SlideRightAnim();
            }; TextView HibokHibok = FindViewById<TextView>(Resource.Id.HibokHibok);
            HibokHibok.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "HIBOKHIBOK");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "HIBOKHIBOK");
                    StartActivity(intent);
                }

                SlideRightAnim();
            }; TextView Kalatungan = FindViewById<TextView>(Resource.Id.Kalatungan);
            Kalatungan.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "KALATUNGAN");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "KALATUNGAN");
                    StartActivity(intent);
                }

                SlideRightAnim();
            }; TextView Kanlaon = FindViewById<TextView>(Resource.Id.Kanlaon);
            Kanlaon.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "KANLAON");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "KANLAON");
                    StartActivity(intent);
                }

                SlideRightAnim();
            };

            TextView Kitanglad = FindViewById<TextView>(Resource.Id.Kitanglad);
            Kitanglad.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "KITANGLAD");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "KITANGLAD");
                    StartActivity(intent);
                }

                SlideRightAnim();
            };

            TextView Lubog = FindViewById<TextView>(Resource.Id.Lubog);
            Lubog.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "LUBOG");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "LUBOG");
                    StartActivity(intent);
                }

                SlideRightAnim();
            };

            TextView Maculot = FindViewById<TextView>(Resource.Id.Maculot);
            Maculot.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "MACULOT");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "MACULOT");
                    StartActivity(intent);
                }

                SlideRightAnim();
            };

            TextView Madjaas = FindViewById<TextView>(Resource.Id.Madjaas);
            Madjaas.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "MADJAAS");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "MADJAAS");
                    StartActivity(intent);
                }

                SlideRightAnim();
            };

            TextView Makiling = FindViewById<TextView>(Resource.Id.Makiling);
            Makiling.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "MAKILING");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "MAKILING");
                    StartActivity(intent);
                }

                SlideRightAnim();
            };

            TextView ManabuPeak = FindViewById<TextView>(Resource.Id.ManabuPeak);
            ManabuPeak.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "MANABU PEAK");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "MANABU PEAK");
                    StartActivity(intent);
                }

                SlideRightAnim();
            };

            TextView Mantalingajan = FindViewById<TextView>(Resource.Id.Matalingajan);
            Mantalingajan.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "MATALINGAJAN");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "MATALINGAJAN");
                    StartActivity(intent);
                }

                SlideRightAnim();
            }; TextView Marami = FindViewById<TextView>(Resource.Id.Marami);
            Marami.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "MARAMI");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "MARAMI");
                    StartActivity(intent);
                }

                SlideRightAnim();
            }; TextView Matutum = FindViewById<TextView>(Resource.Id.Matutum);
            Matutum.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "MATUTUM");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "MATUTUM");
                    StartActivity(intent);
                }

                SlideRightAnim();
            }; TextView Napulak = FindViewById<TextView>(Resource.Id.Napulak);
            Napulak.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "NAPULAK");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "NAPULAK");
                    StartActivity(intent);
                }

                SlideRightAnim();
            }; TextView OsmenaPeak = FindViewById<TextView>(Resource.Id.OsmenaPeak);
            OsmenaPeak.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "OSMEÑA PEAK");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "OSMEÑA PEAK");
                    StartActivity(intent);
                }

                SlideRightAnim();
            }; TextView Pamitinan = FindViewById<TextView>(Resource.Id.Pamitinan);
            Pamitinan.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "PAMITINAN");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "PAMITINAN");
                    StartActivity(intent);
                }

                SlideRightAnim();
            }; TextView PicoDeLoro = FindViewById<TextView>(Resource.Id.PicoDeLoro);
            PicoDeLoro.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "PICO DE LORO");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "PICO DE LORO");
                    StartActivity(intent);
                }

                SlideRightAnim();
            }; TextView Pulag = FindViewById<TextView>(Resource.Id.Pulag);
            Pulag.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "PULAG");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "PULAG");
                    StartActivity(intent);
                }

                SlideRightAnim();
            }; TextView Romelo = FindViewById<TextView>(Resource.Id.Romelo);
            Romelo.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "ROMELO");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "ROMELO");
                    StartActivity(intent);
                }

                SlideRightAnim();
            }; TextView Taal = FindViewById<TextView>(Resource.Id.Taal);
            Taal.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "TAAL VOLCANO");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "TAAL VOLCANO");
                    StartActivity(intent);
                }

                SlideRightAnim();
            }; TextView Talamitam = FindViewById<TextView>(Resource.Id.Talamitam);
            Talamitam.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "TALAMITAM");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "TALAMITAM");
                    StartActivity(intent);
                }

                SlideRightAnim();
            }; TextView Talomo = FindViewById<TextView>(Resource.Id.Talomo);
            Talomo.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "TALOMO");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "TALOMO");
                    StartActivity(intent);
                }

                SlideRightAnim();
            };
            TextView TarakRidge = FindViewById<TextView>(Resource.Id.TarakRidge);
            TarakRidge.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "TARAK RIDGE");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "TARAK RIDGE");
                    StartActivity(intent);
                }

                SlideRightAnim();
            };
            TextView TayakHill = FindViewById<TextView>(Resource.Id.TayakHill);
            TayakHill.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "TAYAK HILL");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "TAYAK HILL");
                    StartActivity(intent);
                }

                SlideRightAnim();
            };
            TextView TresMarias = FindViewById<TextView>(Resource.Id.TresMarias);
            TresMarias.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "TRES MARIAS");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "TRES MARIAS");
                    StartActivity(intent);
                }

                SlideRightAnim();
            };
            TextView Ulap = FindViewById<TextView>(Resource.Id.Ulap);
            Ulap.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "ULAP");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "ULAP");
                    StartActivity(intent);
                }

                SlideRightAnim();
            };
            TextView Victoria = FindViewById<TextView>(Resource.Id.Victoria);
            Victoria.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "VICTORIA");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "VICTORIA");
                    StartActivity(intent);
                }

                SlideRightAnim();
            };
            TextView WhitePeak = FindViewById<TextView>(Resource.Id.WhitePeak);
            WhitePeak.Click += (sender, e) =>
            {
                if (button == "ttb")
                {
                    var intent = new Intent(this, typeof(listsActivity));
                    intent.PutExtra("name", "WHITE PEAK");
                    StartActivity(intent);
                }

                else if (button == "iti")
                {

                    var intent = new Intent(this, typeof(itineraryAct));
                    intent.PutExtra("name", "WHITE PEAK");
                    StartActivity(intent);
                }

                SlideRightAnim();
            };
        }

        public override void OnBackPressed()
        {
            Finish();
            OverridePendingTransition(Resource.Animation.slide_left, Resource.Animation.fade_out);
        }
        private void SlideRightAnim()
        {
            OverridePendingTransition(Resource.Animation.slide_right, Resource.Animation.fade_out);
        }
    }
}