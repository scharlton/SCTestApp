using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Serialization;
using NUnit.Framework;
using UITest3.Base;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace UITest3
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests : BasePage
    {
        IApp app;
        Platform platform;
        static string _entryField = "NoResourceEntry-4";
        readonly Func<AppQuery, AppQuery> PasswordField;

        protected override PlatformQuery Trait => throw new NotImplementedException();

        public Tests(Platform platform)
        {
            PasswordField = x => x.Id("android-password-field");

            this.platform = platform;

        }
        public string MyMethod()
        {
            return string.Empty;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void WelcomeTextIsDisplayed()
        {
            //app.Repl();

            string _updatedText = "Updated Val";

            //app.Screenshot("App Initialized");
            //app.Tap(c => c.Marked(_entryField));
            //app.Screenshot("Entry box ready for text");
            //app.EnterText(c => c.Marked(_entryField), "Hello!");
            //app.Tap(c => c.Marked(_entryField));
            //app.Screenshot("Post text entry");

            AppResult[] results = app.WaitForElement(c => c.Marked(_entryField));
            AppResult t1 = results.FirstOrDefault(x => x.Label == "Balooon");

            Assert.AreEqual(_updatedText, t1.Text);

        }
        //app.Screenshot("Welcome screen.");

        //Assert.AreSame(_updatedText, app.)

        //Assert.IsTrue(results.Any());
    }
}
