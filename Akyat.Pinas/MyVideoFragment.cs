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

namespace Akyat.Pinas
{
    [Activity(Label = "MyVideoFragment")]
    public class MyVideoFragment : DialogFragment
    {
        VideoView imgf;

        public static MyVideoFragment newInstance()
        {
            MyVideoFragment f = new MyVideoFragment();
            return f;
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetStyle(DialogFragmentStyle.NoTitle, Android.Resource.Style.ThemeBlackNoTitleBarFullScreen);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View v = inflater.Inflate(Resource.Layout.fragment_dialog, container, false);

            imgf = v.FindViewById<VideoView>(Resource.Id.videoFragment);

            string video = this.Arguments.GetString("VID");

            imgf.SetVideoURI(Android.Net.Uri.Parse(video));
           
            return v;
        }
    }
}