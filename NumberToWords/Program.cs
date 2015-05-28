using System;
using Microsoft.International;
using Microsoft.International.Formatters;

namespace NumberToWords
{
    public class Program
    {

        public static void Main(string[] args)
        {
            int i = 10;

            Microsoft.International.FormatCultureInfo cultureInfo = new FormatCultureInfo("es-ES");

            Console.WriteLine(string.Format(cultureInfo,"{0:L}",i));
            Console.ReadLine();
        }

    }
}
