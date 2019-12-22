using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsoniaLiteraria04.Helper
{
    public class UserLocalData
    {
        private static ISettings AppSettings => CrossSettings.Current;

        public static string userToken
        {
            get => AppSettings.GetValueOrDefault(DataKey.userToken.ToString(), string.Empty);
            set => AppSettings.AddOrUpdateValue(DataKey.userToken.ToString(), value);
        }

        public static string userEmail
        {
            get => AppSettings.GetValueOrDefault(Data.userEmail.ToString(), string.Empty);
            set => AppSettings.AddOrUpdateValue(Data.userEmail.ToString(), value);
        }

        public static string userUID
        {
            get => AppSettings.GetValueOrDefault(Key.userUID.ToString(), string.Empty);
            set => AppSettings.AddOrUpdateValue(Key.userUID.ToString(), value);
        }

        public static void removeDataAll()
        {
            AppSettings.Remove(DataKey.userToken.ToString());
            AppSettings.Remove(Data.userEmail.ToString());
            AppSettings.Remove(Key.userUID.ToString());
        }
    }

    public enum DataKey
    {
        userToken
    }

    public enum Data
    {
        userEmail
    }

    public enum Key
    {
        userUID
    }
}
