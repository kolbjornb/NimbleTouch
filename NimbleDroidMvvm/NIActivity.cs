#region

using Android.App;

#endregion

namespace NimbleDroidMvvm
{
    /// <summary>
    /// The base class for all our ViewControllers. 
    /// </summary>
    public class NIActivity : Activity
    {
        /// <summary>
        /// Creates a PageViewController with the specified type and parameters, populates the page view model,
        /// and opens the Page. If The current page has a NavigationController the starting page is pushed 
        /// to that navigation controller, otherwise it is opened with PresentViewController.
        /// 
        /// If there is a nib file with the same name as the ViewController type in the default bundle,
        /// that nib file will be loaded for the view controller created. 
        /// </summary>
        /// <typeparam name="TViewController">Type of the page view controller to create.</typeparam>
        /// <typeparam name="TParameters">Type of the parameters to pass to the created page.</typeparam>
        /// <param name="parameters"></param>
        /// <param name="justCreate">Set this to true if you just want to create the viewcontroller and not open it yet.</param>
        /// <returns>The started viewcontroller</returns>
        public TViewController StartPage<TViewController, TParameters>(TParameters parameters, bool justCreate = false)
            where TViewController : NIActivity, IPageActivity<TParameters>, new()
        {
            //Create the controller and set the parameters.
            TViewController controller = new TViewController();
            controller.SetParameters(parameters);

            //TODO: OPEN ACTIVITY

            return controller;
        }
    }
}