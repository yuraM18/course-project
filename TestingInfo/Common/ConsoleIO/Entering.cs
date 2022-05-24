using System;
using System.Text.RegularExpressions;

namespace Common.ConsoleIO
{
    public static class Entering
    {
        public static string format = "{0,40}: ";

        public static int EnterInt32(string prompt)
        {
            while (true)
            {
                try
                {
                    Console.Write(format, prompt);
                    string s = Console.ReadLine();
                    s = s.Replace('.', ',');
                    int value = int.Parse(s);
                    return value;
                }
                catch { Console.WriteLine("Некоректно вказане число"); }
            }
        }

        public static DateTime DateTime(string prompt)
        {
            while (true)
            {
                try
                {
                    Console.Write(format, prompt);
                    string s = Console.ReadLine();
                    s = s.Replace('.', ',');
                    string pattern = @"([0-2]\d|3[01])\.(0\d|1[012])\.(\d{4}) ([0-1]\d|2[0-3])(:[0-5]\d)(\d{2})";
                    if (!Regex.IsMatch(s, pattern, RegexOptions.IgnoreCase))
                    {
                        DateTime date = Convert.ToDateTime(s);
                        return date;
                    }
                }
                catch { Console.WriteLine("Некоректна дата dd.mm.yyyy hh:mm:ss"); }

            }

        }

        public static int EnterInt32(string prompt,
            int min, int max = int.MaxValue)
        {
            while (true)
            {
                int value = EnterInt32(prompt);
                if (value >= min && value <= max)
                {
                    return value;
                }
                Console.WriteLine("Введіть значення в межах від {0} до {1}", min, max);
            }
        }

        public static string EnterString(string prompt)
        {
            Console.Write(format, prompt);
            string s = Console.ReadLine();
            return s.Trim();
        }

        public static string EnterStringOrNull(string prompt)
        {
            Console.Write(format, prompt);
            string s = Console.ReadLine();
            s = s.Trim();
            return s == "" ? null : s;
        }

        public static double? EnterNullableDouble(string prompt)
        {
            Console.Write(format, prompt);
            string s = Console.ReadLine();
            return (s == "") ? (double?)null : Convert.ToDouble(s);
        }

        public static decimal? EnterNullableDecimal(string prompt)
        {
            Console.Write(format, prompt);
            string s = Console.ReadLine();
            return (s == "") ? (decimal?)null : Convert.ToDecimal(s);
        }

        public static DateTime? EnterNullableDate(string prompt)
        {
            Console.Write(format, prompt);
            string s = Console.ReadLine();
            return (s == "") ? (DateTime?)null : Convert.ToDateTime(s);
        }

        public static bool? EnterNullableBoolean(string prompt)
        {
            Console.Write(format, prompt + "(+,-)");
            string s = Console.ReadLine();
            return (s == "") ? (bool?)null :
                (s == "+") ? true : false;
        }
    }
}
