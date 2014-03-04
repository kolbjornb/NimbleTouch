#region

using System;
using System.Collections.Generic;
using System.Drawing;
using MonoTouch.UIKit;
using NimbleTouchMvvm;
using Samples.Model;
using Samples.ViewModel.PersonDetails;
using Samples.ViewModel.PersonList;
using SamplesTouch.ViewControllers.PersonDetails;

#endregion

namespace SamplesTouch.ViewControllers.PersonList
{
    public partial class PersonListViewController : PageViewController<PersonListParameters, PersonListViewModel>
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            IList<Person> persons = ViewModel.Persons;

            for (int i = 0; i < persons.Count; i++)
            {
                var person = persons[i];


                NIButton btnPerson = new NIButton(new RectangleF(0, i*25, 250, 21));
                btnPerson.Text =  person.Name;

                btnPerson.SetOnClick((sender, args) =>
                    {
                        PersonParameters param = new PersonParameters(person.Id);
                        StartPage<PersonDetailsViewController, PersonParameters>(param);
                    });

                vwPersons.AddSubview(btnPerson);
            }
        }
    }


    public class NIButton : UIButton
    {
        public NIButton(RectangleF rectangleF):base(rectangleF)
        {
            BackgroundColor =UIColor.Orange;
            SetTitleColor(UIColor.Black, UIControlState.Normal);
        }

        public void SetOnClick(EventHandler notification)
        {
            AddTarget(notification,UIControlEvent.TouchUpInside);
        }


        public string Text
        {
            get { return base.Title(UIControlState.Normal); }
            set { base.SetTitle(value, UIControlState.Normal); }
        }
    }
}