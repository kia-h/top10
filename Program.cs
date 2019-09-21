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
            foreach (Country country in countries)
            {
                Console.WriteLine($"{ country.Population} : { country.Name}");
            }
            Console.ReadKey();
        }
    }
}
