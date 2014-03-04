using System.Collections.Generic;
using Samples.Model;
using Samples.ViewModel;

namespace Samples.ViewControllers.PersonList
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