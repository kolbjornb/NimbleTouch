#region

using MonoTouch.Foundation;
using NimbleTouchMvvm;
using Samples.ViewModel.PersonList;
using SamplesTouch.ViewControllers.PersonList;

#endregion

namespace SamplesTouch
{
    public partial class SamplesViewController : NIViewController
    {
        partial void btnStartOnClick(NSObject sender)
        {
            var parameters = new PersonListParameters();
            StartPage<PersonListViewController, PersonListParameters>(parameters);
        }
    }
}