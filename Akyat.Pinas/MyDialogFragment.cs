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
    [Activity(Label = "MyDialogFragment")]
    public class MyDialogFragment : DialogFragment
    {
        ImageView imgf;

        public static MyDialogFragment newInstance()
        {
            MyDialogFragment f = new MyDialogFragment();
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

            imgf = v.FindViewById<ImageView>(Resource.Id.imageFragment);

            int image = this.Arguments.GetInt("IMG1");

            imgf.SetImageResource(image);

            return v;
        }
    }
}