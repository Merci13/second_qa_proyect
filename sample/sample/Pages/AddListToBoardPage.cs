using System;

using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;
namespace sample.Pages
{

    public class AddListToBoardPage : BasePage
    {


        readonly Query addListToBoardButton;
        readonly Query editingCardList;
        readonly Query approveListButton;
    
      







        protected override PlatformQuery Trait => new PlatformQuery
        {


            Android = x => x.Id("toolbar_title")

        };
        public AddListToBoardPage()
        {
            if (OnAndroid)
            {
                addListToBoardButton = x => x.Id("add_list_button");
                editingCardList = x => x.Id("editing_toolbar_title");
                approveListButton = x => x.Id("confirm");

            }
        }


        public void AddListToBoardAction() {
           
            app.WaitForElement(addListToBoardButton);
            app.Tap(addListToBoardButton);
            app.WaitForElement(editingCardList);
            app.EnterText("testList");
            app.WaitForElement(approveListButton);
            app.Tap(approveListButton);
             app.Repl();


        }

    }
}
