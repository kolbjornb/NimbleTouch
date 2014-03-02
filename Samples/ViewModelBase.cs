using NimbleTouch.Core.Starters;
using Samples.Model;

namespace Samples
{
    /// <summary>
    /// Base class for all view models in the Sample project. Should give access
    /// to the Model. I.e. by providing access to a Service layer
    /// </summary>
    /// <typeparam name="TParameters"></typeparam>
    public abstract class SampleViewModelBase<TParameters>:IViewModel<TParameters> 
    {
        public abstract void ViewModelDidLoad(TParameters parameters);

        public PersonService PersonService
        {
            get { return ServiceLocator.PersonService; }
        }
    }

    public static class ServiceLocator
    {
        static ServiceLocator()
        {
            PersonService = new PersonService();
        }

        public static PersonService PersonService { get; set; }
    }

}