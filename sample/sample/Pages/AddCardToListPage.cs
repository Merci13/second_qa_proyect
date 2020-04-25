using System;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;


namespace sample.Pages
{
    public class AddCardToListPage : BasePage
    {
        readonly Query addCardButton;
        readonly Query nameCardTextField;
        readonly Query saveCardButton;


        protected override PlatformQuery Trait => new PlatformQuery
        {


            Android = x => x.Id("drag_delegate")

        };


        public AddCardToListPage()
        {
            if (OnAndroid)
            {

                addCardButton = x => x.Id("add_button");
                nameCardTextField = x => x.Id("card_name_edit_text");
                saveCardButton = x => x.Id("confirm");


            }
        }


        public void AddCardToListTestAction() {

            app.WaitForElement(addCardButton);
            app.Tap(addCardButton);
            app.WaitForElement(nameCardTextField);
            app.EnterText("testCard");
            app.WaitForElement(saveCardButton);
            app.Tap(saveCardButton);
           // app.Repl();

        }
    }
}
