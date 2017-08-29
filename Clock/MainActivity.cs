using Android.App;
using Android.OS;

namespace Clock
{
	[Activity(Label = "Clock", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Android.Support.V4.App.FragmentActivity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Main);

            //array of fragments and populate it with an object of each of the three clock fragments
            var fragments = new Android.Support.V4.App.Fragment[] {
                new TimeFragment(),
                new StopwatchFragment(),
                new AboutFragment(),
            };

            var clockAdapter = new ClockAdapter(
                base.SupportFragmentManager, //value from the SupportFragmentManager property you inherit from the FragmentActivity base class
                fragments);
            //Reference to ViewPager where will show the fragments
            var viewPager = FindViewById<Android.Support.V4.View.ViewPager>(Resource.Id.viewPager);
            //set ours Adapter
            viewPager.Adapter = clockAdapter;
        }
    }
}