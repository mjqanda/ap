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

namespace Akyat.Pinas
{
    [Activity(Label = "MountainList!")]
    public class MountainListAct : Activity
    {
        private List<Mountain> mMountains;
        private ListView mListView;
        private EditText mSearch;
        private LinearLayout mContainer;
        private Mountain mt = null;
        private Intent i = null;
        private bool mAnimatedDown;
        private bool mIsAnimating;
        private MountainsAdapter mAdapter;
    

      

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.mountainListLayout);
            mListView = FindViewById<ListView>(Resource.Id.listView);
            mSearch = FindViewById<EditText>(Resource.Id.etSearch);
            mContainer = FindViewById<LinearLayout>(Resource.Id.llContainer);

            mSearch.Alpha = 0;
            mContainer.BringToFront();
            mSearch.TextChanged += mSearch_TextChanged;
            //mListView.FastScrollEnabled = true;
            mMountains = MountainsData.MountainList;
            mListView.ItemClick += mListView_ItemClick;
           

            mAdapter = new MountainsAdapter(this, Resource.Layout.ml_model, mMountains);
            mListView.Adapter = mAdapter;
        }

        private void mListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            int itemPosition = e.Position;
            OpenDetailActivity(itemPosition);
        }

        private void OpenDetailActivity(int pos)
        {
            mt = mMountains[pos];
            i = new Intent(this, typeof(DetailActivity));
            
            i.PutExtra("IMG", mt.MtImg00);
            i.PutExtra("MTNAME", mt.MtName);
            i.PutExtra("LOCATION", mt.Location);
            i.PutExtra("JUMPOFF", mt.JumpOff);
            i.PutExtra("DESCRIPTION", mt.Description);
            i.PutExtra("BACKGROUND", mt.Background);
            i.PutExtra("ITINERARY", mt.Itinerary);
            i.PutExtra("PRACTICALITIES", mt.Practicalities);
            
            StartActivity(i);
        }
       
        void mSearch_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {

            List<Mountain> searchedMountains = (from mountain in mMountains
                                                where mountain.MtName.Contains(mSearch.Text, StringComparison.OrdinalIgnoreCase)
                                                //|| mountain.Masl.Contains(mSearch.Text)
                                                select mountain).ToList();

            mAdapter.Update(searchedMountains);         
            RunOnUiThread(() => mAdapter.NotifyDataSetChanged());
            
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.actionbar, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {

            int id = item.ItemId;
            if (id == Resource.Id.action1)
            {
                List<Mountain> filteredMountains = (mMountains.OrderBy(mountain => mountain.MtName)).ToList();
                mAdapter.Update(filteredMountains);
                RunOnUiThread(() => mAdapter.NotifyDataSetChanged());

            }
            else if (id == Resource.Id.action2)
            {
                List<Mountain> filteredMountains = (mMountains.OrderByDescending(mountain => mountain.MtName).ToList());
                mAdapter.Update(filteredMountains);
                RunOnUiThread(() => mAdapter.NotifyDataSetChanged());
                

            }
            else if (id == Resource.Id.action3)
            {
                List<Mountain> filteredMountains = (mMountains.OrderBy(mountain => mountain.Masl)).ToList();
                mAdapter.Update(filteredMountains);
                RunOnUiThread(() => mAdapter.NotifyDataSetChanged()); 

            }
            else if (id == Resource.Id.action4)
            {
                List<Mountain> filteredMountains = (mMountains.OrderByDescending(mountain => mountain.Masl)).ToList();
                mAdapter.Update(filteredMountains);
                RunOnUiThread(() => mAdapter.NotifyDataSetChanged()); 
                
            }
            else if (id == Resource.Id.action5)
            {
                List<Mountain> filteredMountains = (mMountains.OrderBy(mountain => mountain.Difficulty)).ToList();
                mAdapter.Update(filteredMountains);
                RunOnUiThread(() => mAdapter.NotifyDataSetChanged());

            }
            else if (id == Resource.Id.action6)
            {
                List<Mountain> filteredMountains = (mMountains.OrderByDescending(mountain => mountain.Difficulty)).ToList();
                mAdapter.Update(filteredMountains);
                RunOnUiThread(() => mAdapter.NotifyDataSetChanged());

            }
            else if (id == Resource.Id.action7)
            {
                Toast.MakeText(this, "Coming Soon", ToastLength.Short).Show();
            }


            switch (item.ItemId)
            {
                case Resource.Id.search:
                    //Search icon has been clicked
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

