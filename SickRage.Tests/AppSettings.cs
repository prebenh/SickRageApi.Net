﻿using System.Configuration;

namespace SickRage.Tests
{
    public static class AppSettings
    {
        public static string Url
        {
            get { return ConfigurationManager.AppSettings["Url"]; }
        }

        public static string ApiKey
        {
            get { return ConfigurationManager.AppSettings["ApiKey"]; }
        }
    }
}