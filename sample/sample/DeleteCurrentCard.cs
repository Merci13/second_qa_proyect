using System;
using NUnit.Framework;
using sample.Pages;
using Xamarin.UITest;

namespace sample
{

    //Fixture used for Android
    [TestFixture(Platform.Android)]
    public class DeleteCurrentCard : BaseTestFixture
    {
        public DeleteCurrentCard(Platform platform) : base(platform)
        {
        }

        [Test]
        public void DeleteCurrentCardTest() {
            new LoginPage().SelectLoginButton();
            // new EmailOrUserPage().SelectLoginButton();
            new EmailOrUserPage().addTextToEmailOrUserNameTextField();
            new AddCardToTestBoardPage().ClickTestBoard();
            new AddListToBoardPage().AddListToBoardAction();
            new AddCardToListPage().AddCardToListTestAction();
            new EditNameOfCardTestPage().EditingCardInTheList();
            new DeletingCurrentCardPage().DeleteCard();



        }



    }
}
