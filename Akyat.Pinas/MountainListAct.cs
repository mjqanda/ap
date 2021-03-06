﻿using System;
using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Views.InputMethods;
using Android.Widget;


namespace Akyat.Pinas
{
    [Activity(Label = "MountainList!")]
    public class MountainListAct : Activity
    {
        private List<Mountain> mMountains;
        private List<Mountain> mMountainsTemp;
        private ListView mListView;
        private EditText mSearch;
        private LinearLayout mContainer;
        private Mountain mt = null;
        private Intent i = null;
        private bool mAnimatedDown, mIsAnimating;
        private MountainsAdapter mAdapter;
        private Context context;
        protected MountainsService mountainsRepository;
       
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            oncreate();
        }

        private void oncreate()
        {
            int position = Intent.GetIntExtra("mtDataPos", 177);
            mountainsRepository = new MountainsService();
            if (position == 177)
            {
                ViewHolder();
                mSearch.TextChanged += mSearch_TextChanged;
                mListView.FastScrollEnabled = true;
                mListView.ScrollingCacheEnabled = false;
                mMountains = mountainsRepository.GetAllMountains();
                mMountainsTemp = mMountains.ToList();
                mSearch.Alpha = 0;
                mContainer.BringToFront();
                mAdapter = new MountainsAdapter(this, Resource.Layout.ml_model, mMountains);
                mListView.Adapter = mAdapter;
                ItemClickMethod();
            }
            else
            {
                ViewHolder();
                mSearch.TextChanged += mSearch_TextChanged;
                mListView.ScrollingCacheEnabled = false;
                mListView.FastScrollEnabled = true;
                mMountains = mountainsRepository.GetAllMountains();
                mMountainsTemp = mMountains.ToList();
                mListView.ItemClick += mListView_ItemClick;
                mSearch.Alpha = 0;
                mContainer.BringToFront();
                mAdapter = new MountainsAdapter(this, Resource.Layout.ml_model, mMountains);
                mListView.Adapter = mAdapter;
                ItemClickMethod();
                OpenDetailActivitys(position);
            }
        }
        
        private void ItemClickMethod()
        {
            int start = mListView.FirstVisiblePosition;
            int end = mListView.LastVisiblePosition;
            int numberOfVisibleItems = end - start + 1;

            if (numberOfVisibleItems >= 40)
            {
                mListView.ItemClick += mListView_ItemClick;
            }
            else
            {
                mListView.ItemClick += SearchClick;
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
            i.PutExtra("IMGD1", mt.ImgDesc01);
            i.PutExtra("IMGD2", mt.ImgDesc02);
            i.PutExtra("IMGD3", mt.ImgDesc03);
            i.PutExtra("IMGD4", mt.ImgDesc04);
            i.PutExtra("IMGD5", mt.ImgDesc05);
            i.PutExtra("VIDD", mt.VidDesc);
            i.PutExtra("IMGD0", mt.ImgDesc00);
            StartActivity(i);
            OverridePendingTransition(Resource.Animation.slide_right, Resource.Animation.fade_out);
            Finish();
        }

        private void OpenDetailForSearch(int pos)
        {
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
            i.PutExtra("IMGD1", mt.ImgDesc01);
            i.PutExtra("IMGD2", mt.ImgDesc02);
            i.PutExtra("IMGD3", mt.ImgDesc03);
            i.PutExtra("IMGD4", mt.ImgDesc04);
            i.PutExtra("IMGD5", mt.ImgDesc05);
            i.PutExtra("VIDD", mt.VidDesc);
            i.PutExtra("IMGD0", mt.ImgDesc00);
            StartActivity(i);
            OverridePendingTransition(Resource.Animation.slide_right, Resource.Animation.fade_out);
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
            i.PutExtra("IMGD1", mt.ImgDesc01);
            i.PutExtra("IMGD2", mt.ImgDesc02);
            i.PutExtra("IMGD3", mt.ImgDesc03);
            i.PutExtra("IMGD4", mt.ImgDesc04);
            i.PutExtra("IMGD5", mt.ImgDesc05);
            i.PutExtra("VIDD", mt.VidDesc);
            i.PutExtra("IMGD0", mt.ImgDesc00);
            i.PutExtra("imFromMap", "OKAY");
            StartActivity(i);
            OverridePendingTransition(Resource.Animation.fade_in, Resource.Animation.fade_out);
            Finish();
        }
        void mSearch_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            List<Mountain> searchedMountains = (from mountain in mMountains
                                                where mountain.MtName.Contains(mSearch.Text, StringComparison.OrdinalIgnoreCase)
                                                select mountain).ToList<Mountain>();

            mAdapter = new MountainsAdapter(this, Resource.Layout.ml_model, searchedMountains);
            mListView.Adapter = mAdapter;
            mMountainsTemp = searchedMountains.ToList();
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
            OverridePendingTransition(Resource.Animation.slide_left, Resource.Animation.fade_out);
            List<Mountain> filteredMountains = (mMountains.OrderBy(mountain => mountain.MtName)).ToList();
            mAdapter.Update(filteredMountains);
            RunOnUiThread(() => mAdapter.NotifyDataSetChanged());
            intent.SetFlags(ActivityFlags.ClearTop);
            Finish();
        }
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action1) //Show all mountains
            {
                List<Mountain> filteredMountains = (mMountains.OrderBy(mountain => mountain.MtName)).ToList<Mountain>();
                mAdapter = new MountainsAdapter(this, Resource.Layout.ml_model, filteredMountains);
                mListView.Adapter = mAdapter;
                mMountainsTemp = filteredMountains.ToList();
                RunOnUiThread(() => mAdapter.NotifyDataSetChanged());
            }
            else if (id == Resource.Id.action2) //Show mountains Z-A
            {
                List<Mountain> filteredMountains = (mMountains.OrderByDescending(mountain => mountain.MtName)).ToList<Mountain>();
                mAdapter = new MountainsAdapter(this, Resource.Layout.ml_model, filteredMountains);
                mListView.Adapter = mAdapter;
                mMountainsTemp = filteredMountains.ToList();
                RunOnUiThread(() => mAdapter.NotifyDataSetChanged());
            }
            else if (id == Resource.Id.action3) //Sort Elevation (lowest to highest)
            {
                List<Mountain> filteredMountains = (mMountains.OrderBy(mountain => mountain.Masl)).ToList<Mountain>();
                mAdapter = new MountainsAdapter(this, Resource.Layout.ml_model, filteredMountains);
                mListView.Adapter = mAdapter;
                mMountainsTemp = filteredMountains.ToList();
                RunOnUiThread(() => mAdapter.NotifyDataSetChanged()); 
            }
            else if (id == Resource.Id.action4) //Sort Elevation (highest to lowest)
            {
                List<Mountain> filteredMountains = (mMountains.OrderByDescending(mountain => mountain.Masl)).ToList<Mountain>();
         
                mAdapter = new MountainsAdapter(this, Resource.Layout.ml_model, filteredMountains);
                mListView.Adapter = mAdapter;
                mMountainsTemp = filteredMountains.ToList();
                RunOnUiThread(() => mAdapter.NotifyDataSetChanged()); 
            }
            else if (id == Resource.Id.action5) //Sort Difficulty from easiest
            {
                List<Mountain> filteredMountains = (mMountains.OrderBy(mountain => mountain.Difficulty)).ToList<Mountain>();
                mAdapter = new MountainsAdapter(this, Resource.Layout.ml_model, filteredMountains);
                mListView.Adapter = mAdapter;
                mMountainsTemp = filteredMountains.ToList();
                RunOnUiThread(() => mAdapter.NotifyDataSetChanged());
            }
            else if (id == Resource.Id.action6) //Sort Difficulty from most difficult
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
        
            else if (id == Resource.Id.action10) // show dayhike mountains
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
            else if (id == Resource.Id.action11) // show overnight mountains
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

