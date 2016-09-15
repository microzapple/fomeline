using System;
using FomeLine.Auth;
using FomeLine.iOS;
using Xamarin.Auth;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(LoginPage), typeof(LoginPageRendereriOs))]
namespace FomeLine.iOS
{
    public class LoginPageRendereriOs : PageRenderer
    {
        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

            var auth = new Xamarin.Auth.OAuth2Authenticator(
                "1014438478778-bjg3gtmogejgahvjbnj2p97lgrps031e.apps.googleusercontent.com",
                "VfalyPULwbc18OY5luxyI44n",
                "openid email",
                new Uri("https://accounts.google.com/o/oauth2/auth"),
                new Uri("https://fomeline.ozielguimaraes.net/"),
                new Uri("https://accounts.google.com/o/oauth2/token"));

            //        var auth = new OAuth2Authenticator(clientId: "1014438478778-bjg3gtmogejgahvjbnj2p97lgrps031e.apps.googleusercontent.com",
            //scope: "https://www.googleapis.com/auth/userinfo.email",
            //authorizeUrl: new Uri("https://accounts.google.com/o/oauth2/auth"),
            //redirectUrl: new Uri("https://www.googleapis.com/plus/v1/people/me"),
            //getUsernameAsync: null);


            auth.Completed += (sender, eventArgs) =>
            {
                // We presented the UI, so it's up to us to dimiss it on iOS.
                App.SuccessFulLoginAction.Invoke();

                if (eventArgs.IsAuthenticated)
                {
                    // Use eventArgs.Account to do wonderful things
                    App.SaveToken(eventArgs.Account.Properties["access_token"]);
                }
                else
                {
                    // The user cancelled
                    Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Não autenticado", "O login foi cancelado", "OK");
                }
            };

            PresentViewController(auth.GetUI(), true, null);
        }
    }
}