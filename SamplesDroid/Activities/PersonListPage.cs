#region

using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Widget;
using NimbleDroidMvvm;
using Samples.Model;
using Samples.ViewModel.PersonDetails;
using Samples.ViewModel.PersonList;

#endregion

namespace SamplesDroid.Activities
{
    [Activity(Label = "PersonList")]
    public class PersonListPage : PageActivity<PersonListParameters,PersonListViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.PersonListLayout);

            IList<Person> persons = ViewModel.Persons;
            foreach (var person in persons)
            {
                Button button = new Button(this);
                button.Text = person.Name;
                Person person1 = person;
                button.Click += (sender, args) => StartPage<PersonDetailsPage, PersonParameters>(new PersonParameters(person1.Id));
            }
        }
    }
}