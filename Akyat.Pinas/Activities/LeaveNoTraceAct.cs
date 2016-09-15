using Android.App;
using Android.OS;
using Android.Views;

namespace Akyat.Pinas.Activities
{
    [Activity( Label = "LeaveNoTraceAct" )]
    public class LeaveNoTraceAct : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.leaveNoTrace);
            // Create your application here
        }
    }
}