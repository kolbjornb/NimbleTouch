#region

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Samples;

#endregion

namespace SamplesTouch
{
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        // class-level declarations
        private UINavigationController _navigationController;
        private SamplesViewController _viewController;
        private UIWindow _window;

        //
        // This method is invoked when the application has loaded and is ready to run. In this
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            _window = new UIWindow(UIScreen.MainScreen.Bounds);

            _viewController = new SamplesViewController();
            _navigationController = new UINavigationController(_viewController);

            _window.RootViewController = _navigationController;
            _window.MakeKeyAndVisible();

            return true;
        }
    }
}