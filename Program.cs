using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace top10
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\kia.heydari\source\repos\top10\Pop.csv";
            CsvReader reader = new CsvReader(filePath);
            Country[] countries = reader.ReadFirstNCountries(10);
            List<Country> countriesAll = reader.ReadFirstAllCountries();

            //to read top 10 from array
            foreach (Country country in countries)
            {
                Console.WriteLine($"{ country.Population} : { country.Name}");
            }

            //to read from list
            foreach (Country country in countriesAll)
            {
                Console.WriteLine($"{ country.Population} : { country.Name}");
            }

            Console.ReadKey();
        }
    }
}
