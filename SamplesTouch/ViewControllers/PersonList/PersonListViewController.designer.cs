// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//

using MonoTouch.Foundation;

namespace SamplesTouch.ViewControllers.PersonList
{
	[Register ("PersonListViewController")]
	partial class PersonListViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIView vwPersons { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (vwPersons != null) {
				vwPersons.Dispose ();
				vwPersons = null;
			}
		}
	}
}
