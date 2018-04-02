﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_TestFrameWork.Configuration
{
    public class AppConfigReader : IConfig
    {
        public BrowserType GetBrowser()
        {
            string browser = ConfigurationManager.AppSettings.Get("Browser");
            return (BrowserType)Enum.Parse(typeof(BrowserType), browser);
        }

        public string GetUserName()
        {
            return ConfigurationManager.AppSettings.Get("UserName");
        }

        public string GetPassword()
        {
            return ConfigurationManager.AppSettings.Get("Password");
        }

        public string GetWebSite()
        {
            return ConfigurationManager.AppSettings.Get("WebSite");
        }

        public string GetScreenshotStorage()
        {
            return ConfigurationManager.AppSettings.Get("ScreenshotStorage");
        }
    }
}
