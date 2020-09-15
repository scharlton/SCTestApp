using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest3
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;
        static string _entryField = "NoResourceEntry-4";

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void WelcomeTextIsDisplayed()
        {
            app.Repl();

            app.Screenshot("App Initialized");
            //app.Tap(c => c.Marked(_entryField));
            //app.Screenshot("Entry box ready for text");
            //app.EnterText(c => c.Marked(_entryField), "Hello!");
            //app.Tap(c => c.Marked(_entryField));
            //app.Screenshot("Post text entry");
            AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to Xamarin.Forms!"));
            //app.Screenshot("Welcome screen.");

            //Assert.IsTrue(results.Any());
        }
    }
}
