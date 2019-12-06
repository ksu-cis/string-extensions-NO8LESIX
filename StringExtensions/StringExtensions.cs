using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ExtensionMethods
{
    public static class StringExtensions
    {



        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?', '!', ',' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static string Capitalize(this String str)
        {
            string first = str[0].ToString().ToUpper();

            //return first + str.Substring(1);
            return (str[0].ToString().ToUpper() + str.Substring(1));
        }

        public static string DeCapitalize(this String str)
        {
            str = (str[0].ToString().ToLower() + str.Substring(1));
            return (str[0].ToString().ToLower() + str.Substring(1));
        }

        public static string Titleize(this String title)
        {
            List<string> articles = new List<string> { "a", "an", "the" };

            title.Split(new char[] { ' ', '.', '?', '!', ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> parts = new List<string>(title.Split(new char[] { ' ', '.', '?', '!', ',' }, StringSplitOptions.RemoveEmptyEntries));
            if (articles.Contains(parts[0].ToLower()))
            {

                string first = parts[0];
                parts.RemoveAt(0);
                parts.Add(", ");
                parts.Add(first);

                while (articles.Contains(parts[0].ToLower()))
                {
                    first = parts[0];
                    parts.RemoveAt(0);
                    parts.Add("  ");
                    parts.Add(first);
                }


            }

            return parts.Aggregate((acc, part) => acc + part + " ").TrimEnd();

        }










    }
}
