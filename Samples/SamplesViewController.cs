#region

using MonoTouch.Foundation;
using NimbleTouch.Core.Starters;
using Samples.ViewControllers.Nibs;
using Samples.ViewControllers.PersonList;

#endregion

namespace Samples
{
    public partial class SamplesViewController : NIViewController
    {
        partial void btnStartOnClick(NSObject sender)
        {
            var parameters = new PersonListParameters();
            StartPage<PersonListViewController, PersonListParameters>(parameters);
        }

        partial void btnStart2OnClick(NSObject sender)
        {
            PresentViewController(new NibsViewController(), true, () => { });
        }
    }
}