using System;
using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Views.InputMethods;
using Android.Widget;
using Akyat.Pinas;
using SQLite;
using Akyat.Pinas.ORM;
using System.IO;
using Android.Renderscripts;
using Java.Security;

namespace Akyat.Pinas
{
    [Activity(Label = "MountainList!")]
    public class MountainListAct : Activity
    {
        private List<Mountain> mMountains = new List<Mountain>();
        private List<Mountain> mMountainsTemp = new List<Mountain>();
        private ListView mListView;
        private EditText mSearch;
        private LinearLayout mContainer;
        private Mountain mt = null;
        private Intent i = null;
        private bool mAnimatedDown, mIsAnimating;
        private MountainsAdapter mAdapter;
        private Context context;
       
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            oncreate();

        }

        private void oncreate()
        {
            int position = Intent.GetIntExtra("mtDataPos", 177);

            if (position == 177)
            {
                //SetContentView(Resource.Layout.mountainListLayout);
                //mListView = FindViewById<ListView>(Resource.Id.listView);
                //mSearch = FindViewById<EditText>(Resource.Id.etSearch);
                //mContainer = FindViewById<LinearLayout>(Resource.Id.llContainer);
                ViewHolder();
                mSearch.TextChanged += mSearch_TextChanged;
                mListView.FastScrollEnabled = true;
                mListView.ScrollingCacheEnabled = false;

                mMountains = MountainsData.MountainList;
                mMountainsTemp = mMountains.ToList();


                //mAdapter.GetView(this,Resource.Layout.ml_model, mMountains);
                mSearch.Alpha = 0;
                mContainer.BringToFront();

                mAdapter = new MountainsAdapter(this, Resource.Layout.ml_model, mMountains);
                mListView.Adapter = mAdapter;


                int start = mListView.FirstVisiblePosition;
                int end = mListView.LastVisiblePosition;
                int numberOfVisibleItems = end - start + 1;

                if (numberOfVisibleItems == 40)
                {
                    mListView.ItemClick += mListView_ItemClick;
                }
                else
                {
                    mListView.ItemClick += SearchClick;
                }

            }
            else
            {
                //SetContentView(Resource.Layout.mountainListLayout);
                //mListView = FindViewById<ListView>(Resource.Id.listView);
                //mSearch = FindViewById<EditText>(Resource.Id.etSearch);
                //mContainer = FindViewById<LinearLayout>(Resource.Id.llContainer);
                ViewHolder();
                mMountainsTemp = mMountains.ToList();
                mSearch.TextChanged += mSearch_TextChanged;
                mListView.ScrollingCacheEnabled = false;
                mListView.FastScrollEnabled = true;
                mMountains = MountainsData.MountainList;
                mListView.ItemClick += mListView_ItemClick;
                //mAdapter.GetView(this,Resource.Layout.ml_model, mMountains);
                mSearch.Alpha = 0;
                mContainer.BringToFront();


                mAdapter = new MountainsAdapter(this, Resource.Layout.ml_model, mMountains);
                mListView.Adapter = mAdapter;

                int start = mListView.FirstVisiblePosition;
                int end = mListView.LastVisiblePosition;
                int numberOfVisibleItems = end - start + 1;

                if (numberOfVisibleItems == 40)
                {
                    mListView.ItemClick += mListView_ItemClick;
                }
                else
                {
                    mListView.ItemClick += SearchClick;
                }

                OpenDetailActivitys(position);
            }
        }

        private void mListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            int itemPosition = e.Position;
            OpenDetailActivity(itemPosition);
        }
        private void SearchClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            int itemPosition = e.Position;
            OpenDetailForSearch(itemPosition);
        }
        private void OpenDetailActivity(int pos)
        {
            mt = mMountains[pos];
            //mt = mMountainsTemp[pos];

            i = new Intent(this, typeof(DetailActivity));
            
            i.PutExtra("IMG0", mt.MtImg00);
            i.PutExtra("IMG1", mt.MtImg01);
            i.PutExtra("IMG2", mt.MtImg02);
            i.PutExtra("IMG3", mt.MtImg03);
            i.PutExtra("IMG4", mt.MtImg04);
            i.PutExtra("IMG5", mt.MtImg05);
            i.PutExtra("MTNAME", mt.MtName);
            i.PutExtra("LOCATION", mt.Location);
            i.PutExtra("JUMPOFF", mt.JumpOff);
            i.PutExtra("DESCRIPTION", mt.Description);
            i.PutExtra("BACKGROUND", mt.Background);
            i.PutExtra("ITINERARY", mt.Itinerary);
            i.PutExtra("PRACTICALITIES", mt.Practicalities);
            i.PutExtra("ATTIRE", mt.Attire);
            i.PutExtra("TTB", mt.Ttb);
            i.PutExtra("VV", mt.Vid);
            StartActivity(i);
            Finish();
        }

        private void OpenDetailForSearch(int pos)
        {
            //mt = mMountains[pos];
            mt = mMountainsTemp[pos];

            i = new Intent(this, typeof(DetailActivity));

            i.PutExtra("IMG0", mt.MtImg00);
            i.PutExtra("IMG1", mt.MtImg01);
            i.PutExtra("IMG2", mt.MtImg02);
            i.PutExtra("IMG3", mt.MtImg03);
            i.PutExtra("IMG4", mt.MtImg04);
            i.PutExtra("IMG5", mt.MtImg05);
            i.PutExtra("MTNAME", mt.MtName);
            i.PutExtra("LOCATION", mt.Location);
            i.PutExtra("JUMPOFF", mt.JumpOff);
            i.PutExtra("DESCRIPTION", mt.Description);
            i.PutExtra("BACKGROUND", mt.Background);
            i.PutExtra("ITINERARY", mt.Itinerary);
            i.PutExtra("PRACTICALITIES", mt.Practicalities);
            i.PutExtra("ATTIRE", mt.Attire);
            i.PutExtra("TTB", mt.Ttb);
            i.PutExtra("VV", mt.Vid);
            StartActivity(i);
            Finish();
        }
        private void OpenDetailActivitys(int pos)
        {
            mt = mMountains[pos];



            i = new Intent(this, typeof(DetailActivity));

            i.PutExtra("IMG0", mt.MtImg00);
            i.PutExtra("IMG1", mt.MtImg01);
            i.PutExtra("IMG2", mt.MtImg02);
            i.PutExtra("IMG3", mt.MtImg03);
            i.PutExtra("IMG4", mt.MtImg04);
            i.PutExtra("IMG5", mt.MtImg05);
            i.PutExtra("MTNAME", mt.MtName);
            i.PutExtra("LOCATION", mt.Location);
            i.PutExtra("JUMPOFF", mt.JumpOff);
            i.PutExtra("DESCRIPTION", mt.Description);
            i.PutExtra("BACKGROUND", mt.Background);
            i.PutExtra("ITINERARY", mt.Itinerary);
            i.PutExtra("PRACTICALITIES", mt.Practicalities);
            i.PutExtra("ATTIRE", mt.Attire);
            i.PutExtra("TTB", mt.Ttb);
            i.PutExtra("VV", mt.Vid);
            i.PutExtra("imFromMap", "OKAY");
            StartActivity(i);
            Finish();
        }
        void mSearch_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            
            List<Mountain> searchedMountains = (from mountain in mMountains
                                                where mountain.MtName.Contains(mSearch.Text, StringComparison.OrdinalIgnoreCase)
                                                select mountain).ToList<Mountain>();

            mAdapter = new MountainsAdapter(this, Resource.Layout.ml_model, searchedMountains);
            mListView.Adapter = mAdapter;
           // mMountainsTemp = searchedMountains.ToList();
       //     mListView.ItemClick += SearchClick;
          
            RunOnUiThread(() => mAdapter.NotifyDataSetChanged());
        }
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.actionbar, menu);
            return base.OnCreateOptionsMenu(menu);
        }
        public override void OnBackPressed()
        {
          
            var intent = new Intent(this, typeof(Activities.MainMenuAct));
           
            StartActivity(intent);
            List<Mountain> filteredMountains = (mMountains.OrderBy(mountain => mountain.MtName)).ToList();
            mAdapter.Update(filteredMountains);
            RunOnUiThread(() => mAdapter.NotifyDataSetChanged());
            intent.SetFlags(ActivityFlags.ClearTop);
            Finish();
        }
        public override bool OnOptionsItemSelected(IMenuItem item)
        {

            int id = item.ItemId;
            if (id == Resource.Id.action1)
            {
                List<Mountain> filteredMountains = (mMountains.OrderBy(mountain => mountain.MtName)).ToList<Mountain>();
               
                mAdapter = new MountainsAdapter(this, Resource.Layout.ml_model, filteredMountains);
                mListView.Adapter = mAdapter;
                mMountainsTemp = filteredMountains.ToList();
                RunOnUiThread(() => mAdapter.NotifyDataSetChanged());
            }
            else if (id == Resource.Id.action2)
            {
                List<Mountain> filteredMountains = (mMountains.OrderByDescending(mountain => mountain.MtName)).ToList<Mountain>();
               
                mAdapter = new MountainsAdapter(this, Resource.Layout.ml_model, filteredMountains);
                mListView.Adapter = mAdapter;
                mMountainsTemp = filteredMountains.ToList();
                RunOnUiThread(() => mAdapter.NotifyDataSetChanged());
            }
            else if (id == Resource.Id.action3)
            {
                List<Mountain> filteredMountains = (mMountains.OrderBy(mountain => mountain.Masl)).ToList<Mountain>();
              

                mAdapter = new MountainsAdapter(this, Resource.Layout.ml_model, filteredMountains);
                mListView.Adapter = mAdapter;
                mMountainsTemp = filteredMountains.ToList();
                RunOnUiThread(() => mAdapter.NotifyDataSetChanged()); 
            }
            else if (id == Resource.Id.action4)
            {
                List<Mountain> filteredMountains = (mMountains.OrderByDescending(mountain => mountain.Masl)).ToList<Mountain>();
         
                mAdapter = new MountainsAdapter(this, Resource.Layout.ml_model, filteredMountains);
                mListView.Adapter = mAdapter;
                mMountainsTemp = filteredMountains.ToList();
                RunOnUiThread(() => mAdapter.NotifyDataSetChanged()); 
            }
            else if (id == Resource.Id.action5)
            {
                List<Mountain> filteredMountains = (mMountains.OrderBy(mountain => mountain.Difficulty)).ToList<Mountain>();
               

                mAdapter = new MountainsAdapter(this, Resource.Layout.ml_model, filteredMountains);
                mListView.Adapter = mAdapter;
                mMountainsTemp = filteredMountains.ToList();
                RunOnUiThread(() => mAdapter.NotifyDataSetChanged());
            }
            else if (id == Resource.Id.action6)
            {
                List<Mountain> filteredMountains = (mMountains.OrderByDescending(mountain => mountain.Difficulty)).ToList<Mountain>();
           

                mAdapter = new MountainsAdapter(this, Resource.Layout.ml_model, filteredMountains);
                mListView.Adapter = mAdapter;
                mMountainsTemp = filteredMountains.ToList();
              
                RunOnUiThread(() => mAdapter.NotifyDataSetChanged());
            }
            else if (id == Resource.Id.action7) //show LUZON
            {
                List<Mountain> filteredMountains = (from mountain in mMountains
                                                    where mountain.Island == 1
                                                    orderby mountain.MtName
                                                    select mountain).ToList<Mountain>();

                mAdapter = new MountainsAdapter(this, Resource.Layout.ml_model, filteredMountains);
                mListView.Adapter = mAdapter;
                mMountainsTemp = filteredMountains.ToList();
                RunOnUiThread(() => mAdapter.NotifyDataSetChanged());
            }
            else if (id == Resource.Id.action8) //show Visayas
            {
                List<Mountain> filteredMountains = (from mountain in mMountains
                                                    where mountain.Island == 2
                                                    orderby mountain.MtName
                                                    select mountain).ToList<Mountain>();

                mAdapter = new MountainsAdapter(this, Resource.Layout.ml_model, filteredMountains);
                mListView.Adapter = mAdapter;
                mMountainsTemp = filteredMountains.ToList();
            
                RunOnUiThread(() => mAdapter.NotifyDataSetChanged());
            }
            else if (id == Resource.Id.action9) //show Mindanao
            {
                List<Mountain> filteredMountains = (from mountain in mMountains
                                                    where mountain.Island == 3
                                                    orderby mountain.MtName
                                                    select mountain).ToList<Mountain>();

                mAdapter = new MountainsAdapter(this, Resource.Layout.ml_model, filteredMountains);
                mListView.Adapter = mAdapter;
                mMountainsTemp = filteredMountains.ToList();
                RunOnUiThread(() => mAdapter.NotifyDataSetChanged());
            }
        
            else if (id == Resource.Id.action10)
            {
                List<Mountain> filteredMountains = (from mountain in mMountains
                                                    where mountain.Difficulty <= 4
                                                    orderby mountain.MtName
                                                    select mountain).ToList<Mountain>();

                mAdapter = new MountainsAdapter(this, Resource.Layout.ml_model, filteredMountains);
                mListView.Adapter = mAdapter;
                mMountainsTemp = filteredMountains.ToList();
                RunOnUiThread(() => mAdapter.NotifyDataSetChanged());
            }
            else if (id == Resource.Id.action11)
            {
                List<Mountain> filteredMountains = (from mountain in mMountains
                                                    where mountain.Difficulty >= 4
                                                    orderby mountain.MtName
                                                    select mountain).ToList<Mountain>();

                mAdapter = new MountainsAdapter(this, Resource.Layout.ml_model, filteredMountains);
                mListView.Adapter = mAdapter;
                mMountainsTemp = filteredMountains.ToList();
                RunOnUiThread(() => mAdapter.NotifyDataSetChanged());
            }

            switch (item.ItemId)
            {
                case Resource.Id.search:
                    //Search icon has been clicked
                    mSearch.Visibility = ViewStates.Visible;
                    if (mIsAnimating)   
                    {
                        return true;
                    }
                    if (!mAnimatedDown)
                    {
                        //Listview is up
                        MyAnimation anim = new MyAnimation(mListView, mListView.Height - mSearch.Height);
                        anim.Duration = 500;
                        mListView.StartAnimation(anim);
                        anim.AnimationStart += anim_AnimationStartDown;
                        anim.AnimationEnd += anim_AnimationEndDown;
                        mContainer.Animate().TranslationYBy(mSearch.Height).SetDuration(500).Start();
                    }
                    else
                    {
                        //Listview is down
                        MyAnimation anim = new MyAnimation(mListView, mListView.Height + mSearch.Height);
                        anim.Duration = 500;
                        mListView.StartAnimation(anim);
                        anim.AnimationStart += anim_AnimationStartUp;
                        anim.AnimationEnd += anim_AnimationEndUp;
                        mContainer.Animate().TranslationYBy(-mSearch.Height).SetDuration(500).Start();
                    }
                    mAnimatedDown = !mAnimatedDown;
                    return true;
                default:
                    return base.OnOptionsItemSelected(item);
            }
        }
     
        private void ViewHolder()
        {
            SetContentView(Resource.Layout.mountainListLayout);
            mListView = FindViewById<ListView>(Resource.Id.listView);
            mSearch = FindViewById<EditText>(Resource.Id.etSearch);
            mContainer = FindViewById<LinearLayout>(Resource.Id.llContainer);
        }
        void anim_AnimationEndUp(object sender, Android.Views.Animations.Animation.AnimationEndEventArgs e)
        {
            mIsAnimating = false;
            mSearch.ClearFocus();
            InputMethodManager inputManager = (InputMethodManager)this.GetSystemService(Context.InputMethodService);
            inputManager.HideSoftInputFromWindow(this.CurrentFocus.WindowToken, HideSoftInputFlags.NotAlways);
        }
        void anim_AnimationEndDown(object sender, Android.Views.Animations.Animation.AnimationEndEventArgs e)
        {
            mIsAnimating = false;
        }
        void anim_AnimationStartDown(object sender, Android.Views.Animations.Animation.AnimationStartEventArgs e)
        {
            mIsAnimating = true;
            mSearch.Animate().AlphaBy(1.0f).SetDuration(500).Start();
        }
        void anim_AnimationStartUp(object sender, Android.Views.Animations.Animation.AnimationStartEventArgs e)
        {
            mIsAnimating = true;
            mSearch.Animate().AlphaBy(-1.0f).SetDuration(300).Start();
        }
    }
}

