using Nimble.ViewModel;
using Samples.Model;

namespace Samples.ViewModel
{
    /// <summary>
    /// Base class for all view models in the Sample project. Should give access
    /// to the Model. I.e. by providing access to a Service layer.
    /// </summary>
    /// <typeparam name="TParameters"></typeparam>
    public abstract class SampleViewModelBase<TParameters>:IViewModel<TParameters> 
    {
        public abstract void ViewModelDidLoad(TParameters parameters);

        public PersonService PersonService
        {
            get { return new PersonService(); }
        }
    }
}