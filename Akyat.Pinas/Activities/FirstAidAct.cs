using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Akyat.Pinas.Adapters;
using Akyat.Pinas.Models;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Akyat.Pinas.Activities
{
    [Activity(Label = "FirstAidAct")]
    public class FirstAidAct : Activity
    {
        //TextView title, vdesc00, vdesc001, vdesc002, vdesc003, vdesc004, vdesc005, vdesc006,
        //    vdesc01, vdesc011, vdesc012, vdesc013, vdesc014, vdesc015,
        //    vdesc02, vdesc021, vdesc022, vdesc023, vdesc024, vdesc025;
        //ImageView vimg001, vimg002, vimg003, vimg004, vimg005,
        //    vimg011, vimg012, vimg013, vimg014, vimg015,
        //    vimg021, vimg022, vimg023, vimg024, vimg025;
        private ListView mListView;
        private List<FirstAid> mFirstAid;
        private FirstAidAdapter mAdapter;
        protected MountainsService mountainsRepository;

        Activity activity = new Activity();
        protected MountainsService firstaidRepository;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            
           // activity = firstaidRepository.GetFirstAidData();
            base.OnCreate(savedInstanceState);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.firstaidLayout);
            mListView = FindViewById<ListView>(Resource.Id.faidlistview);
            //ViewHolder();
            // Create your application here
            mFirstAid = mountainsRepository.GetFirstAidData();
            mAdapter = new FirstAidAdapter(this, Resource.Layout.firstaidModel, mFirstAid);
            mListView.Adapter = mAdapter;
        }
        public override void OnBackPressed()
        {
            Finish();
            OverridePendingTransition(Resource.Animation.slide_left, Resource.Animation.fade_out);
        }

        //private void ViewHolder()
        //{
        //    title = FindViewById<TextView>(Resource.Id.title);

        //    vdesc00 = FindViewById<TextView>(Resource.Id.desc00);
        //    vdesc001 = FindViewById<TextView>(Resource.Id.desc001);
        //    vdesc002 = FindViewById<TextView>(Resource.Id.desc002);
        //    vdesc003 = FindViewById<TextView>(Resource.Id.desc003);
        //    vdesc004 = FindViewById<TextView>(Resource.Id.desc004);
        //    vdesc005 = FindViewById<TextView>(Resource.Id.desc005);
        //    vdesc006 = FindViewById<TextView>(Resource.Id.desc006);

        //    vdesc01 = FindViewById<TextView>(Resource.Id.desc01);
        //    vdesc011 = FindViewById<TextView>(Resource.Id.desc011);
        //    vdesc012 = FindViewById<TextView>(Resource.Id.desc012);
        //    vdesc013 = FindViewById<TextView>(Resource.Id.desc013);
        //    vdesc014 = FindViewById<TextView>(Resource.Id.desc014);
        //    vdesc015 = FindViewById<TextView>(Resource.Id.desc015);

        //    vdesc02 = FindViewById<TextView>(Resource.Id.desc02);
        //    vdesc021 = FindViewById<TextView>(Resource.Id.desc021);
        //    vdesc022 = FindViewById<TextView>(Resource.Id.desc022);
        //    vdesc023 = FindViewById<TextView>(Resource.Id.desc023);
        //    vdesc024 = FindViewById<TextView>(Resource.Id.desc024);
        //    vdesc025 = FindViewById<TextView>(Resource.Id.desc025);

        //    vimg001 = FindViewById<ImageView>(Resource.Id.img001);
        //    vimg002 = FindViewById<ImageView>(Resource.Id.img002);
        //    vimg003 = FindViewById<ImageView>(Resource.Id.img003);
        //    vimg004 = FindViewById<ImageView>(Resource.Id.img004);
        //    vimg005 = FindViewById<ImageView>(Resource.Id.img005);

        //    vimg011 = FindViewById<ImageView>(Resource.Id.img011);
        //    vimg012 = FindViewById<ImageView>(Resource.Id.img012);
        //    vimg013 = FindViewById<ImageView>(Resource.Id.img013);
        //    vimg014 = FindViewById<ImageView>(Resource.Id.img014);
        //    vimg015 = FindViewById<ImageView>(Resource.Id.img015);

        //    vimg021 = FindViewById<ImageView>(Resource.Id.img021);
        //    vimg022 = FindViewById<ImageView>(Resource.Id.img022);
        //    vimg023 = FindViewById<ImageView>(Resource.Id.img023);
        //    vimg024 = FindViewById<ImageView>(Resource.Id.img024);
        //    vimg025 = FindViewById<ImageView>(Resource.Id.img025);
        //}
    }
}