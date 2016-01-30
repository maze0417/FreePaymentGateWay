using System;
using System.Configuration;

namespace FreePayment.Core.Helpers
{
    public class AppConfigHelper
    {
        public static T AppSetting<T>(string key, T defaultValue, Func<string, T> converter = null)
        {
            if (converter == null) converter = v => (T)Convert.ChangeType(v, typeof(T));
            var value = ConfigurationManager.AppSettings[key];
            return value == null ? defaultValue : converter(value);
        }
    }
}