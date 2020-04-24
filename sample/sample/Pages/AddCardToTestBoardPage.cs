using System;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace sample.Pages
{
    public class AddCardToTestBoardPage : BasePage
    {

 

        readonly Query plusButton;
        readonly Query addBoardButton;

        readonly Query boardNameTextField;
        readonly Query createBoardButton;

        protected override PlatformQuery Trait => new PlatformQuery
        {


            Android = x => x.Id("boards_container")

        };
        public AddCardToTestBoardPage()
        {
            if (OnAndroid)
            {
                plusButton = x => x.Id("add_fab");
                addBoardButton = x => x.Id("add_board_fab");
                boardNameTextField = x => x.Id("board_name");
                createBoardButton = x => x.Id("create_board");

            }
        }

        public void ClickTestBoard() {
            
            app.WaitForElement(plusButton);
            app.Tap(plusButton);
            app.WaitForElement(addBoardButton);
            app.Tap(addBoardButton);
            AddBoard();
        }

        public void AddBoard()
        {
          
            app.WaitForElement(boardNameTextField);
            app.EnterText("test");
            app.WaitForElement(createBoardButton);
            app.Tap(createBoardButton);
           // app.Repl();

        }

    }
}
