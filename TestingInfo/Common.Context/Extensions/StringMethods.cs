﻿using Common.Context.LineIndents;
using Common.Context.StringFormatters;

namespace Common.Context.Extensions
{
    public static class StringMethods
    {
        public static string ToIndentadLineBlock(this string str)
        {
            string s = "";
            LineIndent.Current.Increase();
            s += StringFormatter.Current.FormatWithLineBreaks(str);
            LineIndent.Current.Decrease();
            return s;
        }

        public static string ToIndentadLineBlock(this string str, int indentLength)
        {
            string s = "";
            LineIndent.Current.Increase();
            s += StringFormatter.Current.FormatWithLineBreaks(str, indentLength);
            LineIndent.Current.Decrease();
            return s;
        }
    }
}
