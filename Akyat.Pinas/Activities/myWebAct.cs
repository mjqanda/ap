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
using Android.Webkit;

namespace Akyat.Pinas.Activities
{
    [Activity(Label = "myWebAct",Theme = "@style/Theme.NoTitle")]
    public class myWebAct : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.myWebViewLayout);
            WebView localWebView = FindViewById<WebView>(Resource.Id.WebView);
            localWebView.SetWebViewClient(new WebViewClient()); // stops request going to Web Browser
            localWebView.Settings.LoadWithOverviewMode = true;
            localWebView.Settings.UseWideViewPort = true;
            localWebView.LoadUrl("http://google.com/+SuchithM");
            // Create your application here
        }
    }
}