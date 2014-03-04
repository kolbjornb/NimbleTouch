using Samples.Model;

namespace Samples
{
    public static class ServiceLocator
    {
        static ServiceLocator()
        {
            PersonService = new PersonService();
        }

        public static PersonService PersonService { get; set; }
    }

}