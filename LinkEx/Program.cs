using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n************ Query an Array ***********\n");
            Console.ResetColor();
            string[] counties = new string[]
            
            {

              "Antrim",
              "Armagh",
              "Carlow",
              "Cavan",
              "Clare",
              "Cork",
              "Derry",
              "Donegal",
              "Down",
              "Dublin",
              "Fermanagh",
              "Galway",
              "Kerry",
              "Kildare",
              "Kilkenny",
              "Laois",
              "Leitrim",
              "Limerick",
              "Longford",
              "Louth",
              "Mayo",
              "Meath",
              "Monaghan",
              "Offaly",
              "Roscommon",
              "Sligo",
              "Tipperary",
              "Tyrone",
              "Waterford",
              "Westmeath",
              "Wexford",
              "Wicklow"
              
            };

            var result =
                from c in counties
                where c.StartsWith("w".ToUpper())
                select c;

            foreach(string s in result)
            {
                Console.WriteLine(s);
            }


            
            








            Console.ReadLine();
        }
    }
}
