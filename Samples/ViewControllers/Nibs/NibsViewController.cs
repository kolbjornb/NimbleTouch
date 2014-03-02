#region

using MonoTouch.UIKit;

#endregion

namespace Samples.ViewControllers.Nibs
{
    public partial class NibsViewController : UIViewController
    {
        //public NibsViewController () : base ("NibsViewController", null)
        //{
        //}

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
        }
    }
}