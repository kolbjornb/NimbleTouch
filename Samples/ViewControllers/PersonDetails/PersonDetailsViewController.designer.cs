// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace Samples.ViewControllers.PersonDetails
{
	[Register ("PersonDetailsViewController")]
	partial class PersonDetailsViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton btnNext { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnPrev { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblName { get; set; }

		[Action ("btnNextOnClick:")]
		partial void btnNextOnClick (MonoTouch.Foundation.NSObject sender);

		[Action ("btnPrevOnClick:")]
		partial void btnPrevOnClick (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (lblName != null) {
				lblName.Dispose ();
				lblName = null;
			}

			if (btnPrev != null) {
				btnPrev.Dispose ();
				btnPrev = null;
			}

			if (btnNext != null) {
				btnNext.Dispose ();
				btnNext = null;
			}
		}
	}
}
