using System.Collections.Generic;
using System.Linq;

namespace Samples.Model
{
    public class PersonService
    {
        private const string persons = @"Thomas Mann,Ayn Rand,Agnar Mykle,Henrik Ibsen,Jan Ove Knausgård,Fyodor Dostoevsky,Jean-Paul Sartre,Robert Musil";

        private IList<Person> _persons;

        public PersonService()
        {
             _persons =  LoadPersons(persons);
        }

        private IList<Person> LoadPersons(string namesCommaSeparated)
        {
            IList<Person> retList = new List<Person>();

            string[] names = namesCommaSeparated.Split(',');
            for (int i = 0; i < names.Length; i++)
            {
                string name = (string) names[i].Trim();
                retList.Add(new Person(name));
            }

            return retList;
        }

        public IList<Person> GetAllPersons()
        {
            return _persons;
        }



        public Person GetPerson(int personId)
        {
            return GetAllPersons().SingleOrDefault(p => p.Id == personId);
        }

    }
}