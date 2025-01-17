using System;
using Xamarin.UITest;

namespace UITest
{
    static class AppManager
    {
        const string apkPath = "‎../apk/Trello.apk";
        static IApp app;
        public static IApp App
        {
            get
            {
                if (app == null)
                    throw new NullReferenceException("'AppManager.App' not set. Call 'AppManager.StartApp()' before trying to access it.");
                return app;
            }
        }

        static Platform? platform;
        public static Platform Platform
        {
            get
            {
                if (platform == null)
                    throw new NullReferenceException("'AppManager.Platform' not set.");
                return platform.Value;
            }

            set
            {
                platform = value;
            }
        }
                    // Used to run a .apk file:
                    //.ApkFile("path/to/file.apk")

        public static void StartApp()
        {
            if (Platform == Platform.Android)
            {
                app = ConfigureApp
                    .Android
                    .ApkFile(apkPath)
                    .StartApp();
            }

            //if (Platform == Platform.iOS)
            //{
            //    app = ConfigureApp
            //        .iOS
            //        // Used to run a .app file on an ios simulator:
            //        //.AppBundle("path/to/file.app")
            //        // Used to run a .ipa file on a physical ios device:
            //        //.InstalledApp("com.company.bundleid")
            //        .StartApp();
            //}
        }
    }
}