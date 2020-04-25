using System;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;
namespace sample.Pages
{
    public class DeletingCurrentCardPage : BasePage
    {
        readonly Query moreOptionesButton;
        readonly Query deleteTextOption;
        readonly Query deleteButton;

        protected override PlatformQuery Trait => new PlatformQuery
        {


            Android = x => x.Id("drag_delegate")

        };

        public DeletingCurrentCardPage()
        {
            if (OnAndroid)
            {
                moreOptionesButton = x => x.Marked("More options");
                deleteTextOption = x => x.Marked("Delete");
                deleteButton = x => x.Id("button1");
      


            }
        }

        public void DeleteCard() {
            app.WaitForElement(moreOptionesButton);
            app.Tap(moreOptionesButton);
            app.WaitForElement(deleteTextOption);
            app.Tap(deleteTextOption);
            app.WaitForElement(deleteButton);
            app.Tap(deleteButton);
           // app.Repl();



        }

    }
}
