using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XconApp.Infrastructures
{
    public static class StringExtenstions
    {
        public static string ToDashCase(this string text)
        {
            return string.IsNullOrEmpty(text) ? "" : text.ToLowerInvariant().Replace(' ', '-');
        }
    }
}