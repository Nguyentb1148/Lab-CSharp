using System;
using System.Globalization;

namespace Lab_CSharp.Exercises_1
{
    public class DateModifier
    {
        public static int DifferenceDate(string date1String, string date2String)
        {
            DateTime date1 = DateTime.ParseExact(date1String, "yyyy M d", CultureInfo.InvariantCulture);
            Console.WriteLine(date1);
            DateTime date2 = DateTime.ParseExact(date2String, "yyyy M d", CultureInfo.InvariantCulture);
            Console.WriteLine(date2);
            var difference = date1 - date2;
           
            Console.WriteLine(difference);
            return Math.Abs(difference.Days);
        }
    }
}