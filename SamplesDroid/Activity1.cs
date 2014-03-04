#region

using Android.App;
using Android.OS;
using Android.Widget;
using NimbleDroidMvvm;
using Samples.ViewModel.PersonList;
using SamplesDroid.Activities;

#endregion

namespace SamplesDroid
{
    [Activity(Label = "SamplesDroid", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : NIActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate
                {
                    StartPage<PersonListPage, PersonListParameters>(new PersonListParameters());

                };
        }
    }
}