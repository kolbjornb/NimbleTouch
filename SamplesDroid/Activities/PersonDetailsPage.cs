#region

using Android.App;
using Android.OS;
using NimbleDroidMvvm;
using Samples.ViewModel.PersonDetails;

#endregion

namespace SamplesDroid.Activities
{
    [Activity(Label = "Person Details")]
    public class PersonDetailsPage : PageActivity<PersonParameters,PersonViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.PersonDetailsLayout);

        }
    }
}