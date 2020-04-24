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
                logInButton = x => x.Text("Log in");

            }
        }

        public void addTextToEmailOrUserNameTextField() {
            app.WaitForElement(userOrEmailTextField);
            app.EnterText("xxtestforxamarinxx@gmail.com"); //use your email to make the log in
            app.WaitForElement(nextButton);
            app.Tap(nextButton);
            app.Repl();
            addPassword();

        }

        public void addPassword() {
                app.WaitForElement(passwordTextField);
            app.EnterText("10a29b38c");//pasword for this account: 10a29b38c
            app.WaitForElement(logInButton);
            app.Tap(logInButton);


        }

        
    }
}
