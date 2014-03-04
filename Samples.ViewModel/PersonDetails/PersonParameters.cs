namespace Samples.ViewModel.PersonDetails
{
    public class PersonParameters
    {
        public int PersonId { get; private set; }
        public PersonParameters(int personId)
        {
            PersonId = personId;
        }
    }
}