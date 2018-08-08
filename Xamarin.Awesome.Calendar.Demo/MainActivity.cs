using Android.App;
using Android.OS;
using Com.Archit.Calendardaterangepicker.Customviews;

namespace Xamarin.Awesome.Calendar.Demo
{
    [Activity(Label = "Xamarin.Awesome.Calendar.Demo", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            DateRangeCalendarView calendarView = FindViewById<DateRangeCalendarView>(Resource.Id.calendar);
        }
    }
}

