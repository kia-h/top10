using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace top10
{

    public static class TestExt
    {
        public static string M1(this string str)
        {
            return str.ToUpper();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string str = "heloo world";
            Console.WriteLine("uisng static method.staticMethod "+TestExt.M1(str)  );


            Console.WriteLine("using extension method version " + str.M1()); ;
            //string filePath = @"C:\Users\kia.heydari\source\repos\top10\Pop.csv";
            //CsvReader reader = new CsvReader(filePath);
            //Country[] countries = reader.ReadFirstNCountries(10);
            //List<Country> countriesAll = reader.ReadFirstAllCountries();

            ////to read top 10 from array
            //foreach (Country country in countries)
            //{
            //    Console.WriteLine($"{ country.Population} : { country.Name}");
            //}

            ////to read from list
            //foreach (Country country in countriesAll)
            //{
            //    Console.WriteLine($"{ country.Population} : { country.Name}");
            //}

            Console.ReadKey();
        }
    }
}
