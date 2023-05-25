using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab16
{
    internal class cs2
    {
        public static void task_2()
        {
            string[] cities = { "New York", "Los Angeles", "Chicago", "Houston", "Boston", "Atlanta", "Miami", "Novocherkassk", "Amsterdam" };

            //Отримати весь масив міст
            var allCities = from city in cities
                            select city;

            //міста з довжиною назви, що дорівнює заданому
            int nameLength = 5;
            var citiesLength = from city in cities
                                   where city.Length == nameLength
                                   select city;

            //міста, назви яких починаються з літери A
            var citiesWithA = from city in cities
                                      where city.StartsWith("A")
                                      select city;

            //міста, назви яких закінчуються літерою M
            var citiesEndingM = from city in cities
                                    where city.EndsWith("m")
                                    select city;

            //міста, назви яких починаються з літери N і закінчуються літерою K
            var citiesStartsN_endingK = from city in cities
                                                    where city.StartsWith("N") && city.EndsWith("k")
                                                    select city;

            //міста, назви яких починаються з Ne. Результат відсортований за спаданням
            var citiesWithNe = from city in cities
                                       where city.StartsWith("Ne")
                                       orderby city descending
                                       select city;

            // Вивід результатів
            Console.WriteLine("Task 2:");
            Console.WriteLine("All Cities:");
            Console.WriteLine(string.Join(" ", allCities));

            Console.WriteLine("\nCities with name length of " + nameLength + ":");
            Console.WriteLine(string.Join(" ", citiesLength));

            Console.WriteLine("\nCities starting with 'A':");
            Console.WriteLine(string.Join(" ", citiesWithA));

            Console.WriteLine("\nCities ending with 'M':");
            Console.WriteLine(string.Join(" ", citiesEndingM));

            Console.WriteLine("\nCities starting with 'N' and ending with 'K':");
            Console.WriteLine(string.Join(" ", citiesStartsN_endingK));

            Console.WriteLine("\nCities starting with 'Ne' (Descending):");
            Console.WriteLine(string.Join(" ", citiesWithNe));
        }

    }
}
