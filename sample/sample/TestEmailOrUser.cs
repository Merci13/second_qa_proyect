﻿using System;
using NUnit.Framework;
using sample.Pages;
using Xamarin.UITest;

namespace sample
{
    //Fixture used for Android
    [TestFixture(Platform.Android)]
    public class TestEmailOrUser : BaseTestFixture
    {
        public TestEmailOrUser(Platform platform): base(platform)
        {


        }
         [Test]
        public void ClickNextButtonToLogIn()
        {
     
            new LoginPage().SelectLoginButton();
            // new EmailOrUserPage().SelectLoginButton();
            new EmailOrUserPage().addTextToEmailOrUserNameTextField();
           //   app.Repl();
           

        }



    }//end
}
