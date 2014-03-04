using NimbleTouchMvvm;
using Samples.ViewModel.PersonDetails;

namespace SamplesTouch.ViewControllers.PersonDetails
{
	public partial class PersonDetailsViewController : PageViewController<PersonParameters, PersonViewModel>
	{
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
		    lblName.Text = ViewModel.PersonName;
		    btnPrev.Hidden = !ViewModel.HasPreviousPerson;
		    btnNext.Hidden = !ViewModel.HasNextPerson;
		}

        partial void btnNextOnClick(MonoTouch.Foundation.NSObject sender)
        {
        }

        partial void btnPrevOnClick(MonoTouch.Foundation.NSObject sender)
        {
        }    
    }
}

