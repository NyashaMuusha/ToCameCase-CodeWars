using System;
using System.Data.SqlTypes;
using System.Globalization;
using System.Threading;

namespace CamelCase
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CamelCase("The_lover-boy");
        }
        public static string CamelCase(string str)
        {
            var upperCaseString = "";
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textinfo = cultureInfo.TextInfo;
            for (int i = 0; i < str.Length; i++)
            {
           
                if (str[0] == char.ToUpper(str[0]))
                {
                     upperCaseString = textinfo.ToTitleCase(str)
                        .Replace("_","")
                        .Replace("-","");
                }
                else
                {
                    upperCaseString= textinfo.ToTitleCase(str)
                        .Replace("_", "")
                        .Replace("-", "");
                  
                    for (int a = 0; a < upperCaseString.Length; a ++)
                    {
                        var newString = Char.ToLower(upperCaseString[0]) + upperCaseString.Substring(1);
                        upperCaseString = newString;
                    }
                }
            }
            return upperCaseString;
        }
        
    }
}
        
  