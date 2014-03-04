using Nimble.ViewModel;

namespace NimbleTouch.Core.Starters
{
    /// <summary>
    /// Base class for Pages. Handles the passing of parameters and creation of view models.
    /// </summary>
    /// <typeparam name="TParameters">The type of the parameters to pass to the page.</typeparam>
    /// <typeparam name="TViewModel">The type of the viewmodel for the page.</typeparam>
    public abstract class PageViewController<TParameters, TViewModel> : NIViewController,IPageViewController<TParameters>
        where TViewModel:IViewModel<TParameters>, new()
    {
        /// <summary>
        /// The viewodel for the view controller.
        /// </summary>
        public TViewModel ViewModel { get; set; }

        /// <summary>
        /// Sets the parameters that should be passed in to the PageViewController. 
        /// Based on the Parameters the ViewModel for the Page is created, and the ViewModel property is set
        /// </summary>
        /// <param name="parameters"></param>
        public void SetParameters(TParameters parameters)
        {
            ViewModel = new TViewModel();
            ViewModel.ViewModelDidLoad(parameters);
        }
    }
}