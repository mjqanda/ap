using System;
using System.Collections.Generic;
using System.Linq;
using Akyat.Pinas.MountainsActivities;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using System.IO;
using Android.Runtime;
using Android.Support.V4.View;

namespace Akyat.Pinas.Activities
{
    [Activity(Label = "MountainListsAct")]
    public class MountainListsAct : Activity
    {
        private List<Mountain> mMountains;
        private ListView mListView;
        private SearchView Sview;
        private LinearLayout vContainer;
        private MountainsAdapter adapter;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            RequestWindowFeature(WindowFeatures.NoTitle);

            SetContentView(Resource.Layout.mList);
            mListView = FindViewById<ListView>(Resource.Id.listView);
            Sview = FindViewById<SearchView>(Resource.Id.sv);
            vContainer = FindViewById<LinearLayout>(Resource.Id.llContainer);

      
            mMountains = new List<Mountain>();
            mMountains.Add(new Mountain() { MtName = "Mt. BATLUAO", MASL = "830 MASL", Difficulty = "3/9", ImgResourceId = Resource.Drawable.batulao});
            mMountains.Add(new Mountain() { MtName = "Mt. TALAMITAM", MASL = "630 MASL", Difficulty = "2/9", ImgResourceId = Resource.Drawable.talamitam});
            mMountains.Add(new Mountain() { MtName = "Mt. MAKILING", MASL = "1090 MASL", Difficulty = "5/9", ImgResourceId = Resource.Drawable.makiling});
            mMountains.Add(new Mountain() { MtName = "Mt. CRISTOBAL", MASL = "1480 MASL", Difficulty = "5/9", ImgResourceId = Resource.Drawable.cristobal});
            mMountains.Add(new Mountain() { MtName = "Mt. ULAP", MASL = "1846 MASL", Difficulty = "3/9", ImgResourceId = Resource.Drawable.ulap});
            adapter = new MountainsAdapter(this, Resource.Layout.ml_model,mMountains );
            mListView.Adapter = adapter;
           // Sview.QueryTextChange += Sview_QueryTextChange;
            mListView.ItemClick += (s, e) =>
            {
                Intent myIntent;
                switch (e.Position)
                {
                    case 0:
                        myIntent = new Intent(this, typeof(batulaoAct));
                        StartActivity(myIntent);
                        break;
                    case 1:
                        myIntent = new Intent(this, typeof(talamitamAct));
                        StartActivity(myIntent);
                        break;
                    case 2:
                        myIntent = new Intent(this, typeof(makilingAct));
                        StartActivity(myIntent);
                        break;
                    case 3:
                        myIntent = new Intent(this, typeof(cristobalAct));
                        StartActivity(myIntent);
                        break;
                    case 4:
                        myIntent = new Intent(this, typeof(ulapAct));
                        StartActivity(myIntent);
                        break;
                }
            };

        }
       
        //public override bool OnCreateOptionsMenu(IMenu menu)
        //{

        //    var item = menu.FindItem(Resource.Id.sv);

        //    var searchView = MenuItemCompat.GetActionView(item);
        //    Sview = searchView.JavaCast<SearchView>();

        //    Sview.QueryTextChange += (s, e) => adapter.Filter.InvokeFilter(e.NewText);

        //    Sview.QueryTextSubmit += (s, e) =>
        //    {
        //        // Handle enter/search button on keyboard here
        //        Toast.MakeText(this, "Searched for: " + e.Query, ToastLength.Short).Show();
        //        e.Handled = true;
        //    };

        //    MenuItemCompat.SetOnActionExpandListener(item, new SearchViewExpandListener(adapter));

        //    return true;
        //}

        //void Sview_QueryTextChange(object sender, SearchView.QueryTextChangeEventArgs e)
        //{

        //    List<Mountain> searchedFriends = (from mountain in mMountains
        //                                      where
        //        mountain.MtName.Contains(Sview.Text, StringComparison.OrdinalIgnoreCase).List<Mountain>();

        //    adapter = new MountainsAdapter(this, Resource.Layout.ml_model, searchedFriends);
        //    mListView.Adapter = adapter;
        //    //adapter.Filter.InvokeFilter("");
        //}

        //public override bool OnCreateOptionsMenu(IMenu menu)
        //{
        //    MenuInflater.Inflate(Resource.Menu.actionbar, menu);
        //    return base.OnCreateOptionsMenu(menu);
        //}
    }
}