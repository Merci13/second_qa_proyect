using System;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;
namespace sample.Pages
{


    public class EditNameOfCardTestPage : BasePage
    {
        readonly Query cardTest;
        readonly Query confirmButton;
        readonly Query testNameField;

        protected override PlatformQuery Trait => new PlatformQuery
        {


            Android = x => x.Id("drag_delegate")

        };

        public EditNameOfCardTestPage()
        {
            if (OnAndroid)
            {
                cardTest = x => x.Marked("testCard");
                confirmButton = x => x.Id("confirm");
                testNameField = x => x.Text("testCard");




            }
        }


        public void EditingCardInTheList()
        {
            app.WaitForElement(cardTest);
            app.Tap(cardTest); 
       
      
          //  app.Tap(x => x.Text("testCard").Index(1));
            app.Tap((testNameField)); //no supe como agregar el index aqui
            app.ClearText();
            app.EnterText("CardTestEdited");
            app.Tap(confirmButton);
           // app.Repl();

        }


    }
}
