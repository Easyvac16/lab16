using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab16
{
    internal class cs1
    {
        public static void task_1()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 14, 16, 21, 28,  };

            // Отримати весь масив цілих
            var allIntegers = from num in numbers
                              select num;

            //парні цілі
            var evenIntegers = from num in numbers
                               where num % 2 == 0
                               select num;

            //непарні цілі
            var oddIntegers = from num in numbers
                              where num % 2 != 0
                              select num;

            //значення більше заданого
            int moreThanGiven = 5;
            var greaterThanGiven = from num in numbers
                                       where num > moreThanGiven
                                       select num;

            //числа в заданому діапазоні
            int minRange = 3;
            int maxRange = 8;
            var numbersInRange = from num in numbers
                                 where num >= minRange && num <= maxRange
                                 select num;

            //числа, кратні семи. Результат відсортований за зростанням
            var multiplesOfSeven = from num in numbers
                                   where num % 7 == 0
                                   orderby num ascending
                                   select num;

            //числа, кратні восьми. Результат відсортований за спаданням
            var multiplesOfEight = from num in numbers
                                   where num % 8 == 0
                                   orderby num descending
                                   select num;

            // Вивід результатів
            Console.WriteLine("Task 1:");
            Console.WriteLine("All Integers:");
            Console.WriteLine(string.Join(" ", allIntegers));

            Console.WriteLine("\nEven Integers:");
            Console.WriteLine(string.Join(" ", evenIntegers));

            Console.WriteLine("\nOdd Integers:");
            Console.WriteLine(string.Join(" ", oddIntegers));

            Console.WriteLine("\nNumbers greater than " + moreThanGiven + ":");
            Console.WriteLine(string.Join(" ", greaterThanGiven));

            Console.WriteLine("\nNumbers in the range " + minRange + " - " + maxRange + ":");
            Console.WriteLine(string.Join(" ", numbersInRange));

            Console.WriteLine("\nMultiples of Seven (Ascending):");
            Console.WriteLine(string.Join(" ", multiplesOfSeven));

            Console.WriteLine("\nMultiples of Eight (Descending):");
            Console.WriteLine(string.Join(" ", multiplesOfEight));
        }


    }
}
