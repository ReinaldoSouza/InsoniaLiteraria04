using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace InsoniaLiteraria04.Constantes
{
    public class AppConstants
    {
        public static string AppId
        {
            get
            {
                switch (Device.RuntimePlatform)
                {
                    case Device.Android:
                        return "ca-app-pub-9129739278119852~4059994623";
                    default:
                        return "ca-app-pub-9129739278119852~4059994623";
                }
            }
        }

        /// <summary>
        /// These Ids are test Ids from https://developers.google.com/admob/android/test-ads
        /// </summary>
        /// <value>The banner identifier.</value>
        public static string BannerId
        {

            get
            {
                switch (Device.RuntimePlatform)
                {
                    case Device.Android:
                        return "ca-app-pub-9129739278119852/4399740126";
                    default:
                        return "ca-app-pub-9129739278119852/4399740126";
                }
            }
        }

        /// <summary>
        /// These Ids are test Ids from https://developers.google.com/admob/android/test-ads
        /// </summary>
        /// <value>The Interstitial Ad identifier.</value>
        public static string InterstitialAdId
        {
            get
            {
                switch (Device.RuntimePlatform)
                {
                    case Device.Android:
                        return "ca-app-pub-9129739278119852/3651858567";
                    default:
                        return "ca-app-pub-9129739278119852/3651858567";
                }
            }
        }
    }
}
