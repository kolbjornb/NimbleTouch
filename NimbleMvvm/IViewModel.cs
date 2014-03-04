namespace Nimble.Core
{
    /// <summary>
    /// Interface for the generic View models. 
    /// </summary>
    /// <typeparam name="TParameters"></typeparam>
    public interface IViewModel<in TParameters>
    {
        /// <summary>
        /// Implement this method and populate the view model to the default state the view model
        /// should have based on the parameters.
        /// </summary>
        /// <param name="parameters"></param>
        void ViewModelDidLoad(TParameters parameters);
    }
}