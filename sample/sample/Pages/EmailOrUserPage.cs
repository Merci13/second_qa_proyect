using System;


using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;
namespace sample.Pages
{
    public class EmailOrUserPage : BasePage
    {
        readonly Query userOrEmailTextField;
        readonly Query nextButton;
        readonly Query passwordTextField;
        readonly Query logInButton;
     



        protected override PlatformQuery Trait => new PlatformQuery
        {


            Android = x => x.Id("user_layout")

        };

        public EmailOrUserPage()
        {
            if (OnAndroid)
            {

                userOrEmailTextField = x => x.Id("user");
                nextButton = x => x.Id("authenticate");
                passwordTextField = x => x.Id("password");
                logInButton = x => x.Id("authenticate");
             

            }
        }

        public void addTextToEmailOrUserNameTextField() {
            app.WaitForElement(userOrEmailTextField);
            app.EnterText("xamarintestproyectjorgeramiro@test.com"); //use your email to make the log in
            app.WaitForElement(nextButton);
            app.Tap(nextButton);
            addPassword();

            //xamarintestproyectjorgeramiro@test.com

            //here the tester needs to click on the continue button
            // app.Repl();
            //addPassword();

        }
        //this section could appear, sometimes during creating this test apper this window
        public void addPassword() {
                app.WaitForElement(passwordTextField);
            app.EnterText("10a29b38c");//pasword for this account: 10a29b38c
            app.WaitForElement(logInButton);
            app.Tap(logInButton);
           // it will create a new board
          
        }

       
        
    }
}
