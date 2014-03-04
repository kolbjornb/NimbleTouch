using System.Linq;
using Samples.Model;
using Samples.ViewModel;

namespace Samples.ViewControllers.PersonDetails
{
    public class PersonViewModel : SampleViewModelBase<PersonParameters>
    {
        public Person Person { get; set; }

        public string PersonName
        {
            get { return Person.Name; }
        }

        public bool HasPreviousPerson
        {
            get { return PersonService.GetAllPersons().First().Id != Person.Id; }
        }

        public bool HasNextPerson
        {
            get { return PersonService.GetAllPersons().Last().Id != Person.Id; }
        }

        public override void ViewModelDidLoad(PersonParameters parameters)
        {
            Person = PersonService.GetPerson(parameters.PersonId);
        }
    }
}