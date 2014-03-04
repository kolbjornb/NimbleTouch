// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//

using MonoTouch.Foundation;

namespace SamplesTouch
{
	[Register ("SamplesViewController")]
	partial class SamplesViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton btnStart { get; set; }

		[Action ("btnStart2OnClick:")]
		partial void btnStart2OnClick (MonoTouch.Foundation.NSObject sender);

		[Action ("btnStartOnClick:")]
		partial void btnStartOnClick (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (btnStart != null) {
				btnStart.Dispose ();
				btnStart = null;
			}
		}
	}
}
