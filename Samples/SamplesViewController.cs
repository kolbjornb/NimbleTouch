#region

using MonoTouch.Foundation;
using NimbleTouch.Core.Starters;
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

    }
}