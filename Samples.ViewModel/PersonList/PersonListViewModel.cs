using System.Collections.Generic;
using Samples.Model;

namespace Samples.ViewModel.PersonList
{
    public class PersonListViewModel : SampleViewModelBase<PersonListParameters>
    {
        public IList<Person> Persons { get; private set; }

        public override void ViewModelDidLoad(PersonListParameters parameters)
        {
            //Load all persons
            Persons = PersonService.GetAllPersons();
        }
    }
}