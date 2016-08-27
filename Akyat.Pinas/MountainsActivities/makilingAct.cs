using Android.App;
using Android.OS;

namespace Akyat.Pinas.MountainsActivities
{
    [Activity(Theme = "@style/Theme.NoTitle", Label = "makilingAct")]
    public class makilingAct : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.makilingLayout);
            // Create your application here
            
        }
    }
}