namespace Samples.Model
{
    public class Person
    {
        public Person(string name)
        {
            Name = name;
        }

        public int Id
        {
            get { return Name.GetHashCode(); }
        }

        public string Name { get; private set; }
    }
}