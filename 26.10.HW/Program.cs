using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Завдання 1: Масив цілих чисел
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 14, 16, 21, 28, 35, 42, 56, 63, 70 };

        // Отримати весь масив цілих
        var allNumbers = numbers.ToList();

        // Отримати парні цілі
        var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

        // Отримати непарні цілі
        var oddNumbers = numbers.Where(n => n % 2 != 0).ToList();

        // Отримати значення більше заданого (наприклад, 20)
        var numbersGreaterThan20 = numbers.Where(n => n > 20).ToList();

        // Отримати числа в заданому діапазоні (наприклад, 10 до 50)
        var numbersInRange = numbers.Where(n => n >= 10 && n <= 50).ToList();

        // Отримати числа, кратні семи та відсортовані за зростанням
        var numbersMultipleOfSeven = numbers.Where(n => n % 7 == 0).OrderBy(n => n).ToList();

        // Отримати числа, кратні восьми та відсортовані за спаданням
        var numbersMultipleOfEight = numbers.Where(n => n % 8 == 0).OrderByDescending(n => n).ToList();

        // Завдання 2: Масив рядків (назви міст)
        string[] cities = { "Kyiv", "Amsterdam", "Moscow", "New York", "Paris", "Tokyo", "London" };

        // Отримати весь масив міст
        var allCities = cities.ToList();

        // Отримати міста з довжиною назви, що дорівнює заданому (наприклад, 5)
        var citiesWithLengthFive = cities.Where(city => city.Length == 5).ToList();

        // Отримати міста, які починаються з літери "A"
        var citiesStartingWithA = cities.Where(city => city.StartsWith("A")).ToList();

        // Отримати міста, які закінчуються літерою "M"
        var citiesEndingWithM = cities.Where(city => city.EndsWith("M")).ToList();

        // Отримати міста, які починаються з "N" та закінчуються "K"
        var citiesStartingWithNAndEndingWithK = cities.Where(city => city.StartsWith("N") && city.EndsWith("K")).ToList();

        // Отримати міста, які починаються з "Ne" та відсортовані за спаданням
        var citiesStartingWithNe = cities.Where(city => city.StartsWith("Ne")).OrderByDescending(city => city).ToList();

        // Завдання 3: Масив студентів
        var students = new List<Student>
        {
            new Student("Boris", "Johnson", 22, "MIT"),
            new Student("Alice", "Brown", 20, "Oxford"),
            new Student("John", "Doe", 19, "Harvard"),
            new Student("Nancy", "Kerrigan", 21, "MIT"),
            new Student("Bob", "Smith", 23, "Oxford"),
        };

        // Отримати весь масив студентів
        var allStudents = students.ToList();

        // Отримати список студентів з ім'ям "Boris"
        var studentsWithNameBoris = students.Where(student => student.FirstName == "Boris").ToList();

        // Отримати список студентів з прізвищем, яке починається з "Bro"
        var studentsWithSurnameBro = students.Where(student => student.LastName.StartsWith("Bro")).ToList();

        // Отримати список студентів старших 19 років
        var studentsOlderThan19 = students.Where(student => student.Age > 19).ToList();

        // Отримати список студентів віком від 20 до 23 років
        var studentsBetween20And23 = students.Where(student => student.Age >= 20 && student.Age <= 23).ToList();

        // Отримати список студентів, які навчаються в MIT
        var mitStudents = students.Where(student => student.School == "MIT").ToList();

        // Отримати список студентів, які навчаються в Oxford та вік яких старше 18 років, відсортованих за віком за спаданням
        var oxfordStudentsAbove18 = students.Where(student => student.School == "Oxford" && student.Age > 18).OrderByDescending(student => student.Age).ToList();

        // Виведення результатів
        Console.WriteLine("Завдання 1:");
        Console.WriteLine("Весь масив цілих: " + string.Join(", ", allNumbers));
        Console.WriteLine("Парні цілі: " + string.Join(", ", evenNumbers));
        Console.WriteLine("Непарні цілі: " + string.Join(", ", oddNumbers));
        Console.WriteLine("Значення більше 20: " + string.Join(", ", numbersGreaterThan20));
        Console.WriteLine("Числа в діапазоні від 10 до 50: " + string.Join(", ", numbersInRange));
        Console.WriteLine("Числа, кратні семи (за зростанням): " + string.Join(", ", numbersMultipleOfSeven));
        Console.WriteLine("Числа, кратні восьми (за спаданням): " + string.Join(", ", numbersMultipleOfEight));

        Console.WriteLine("\nЗавдання 2:");
        Console.WriteLine("Весь масив міст: " + string.Join(", ", allCities));
        Console.WriteLine("Міста з довжиною назви 5: " + string.Join(", ", citiesWithLengthFive));
        Console.WriteLine("Міста, які починаються з 'A': " + string.Join(", ", citiesStartingWithA));
        Console.WriteLine("Міста, які закінчуються на 'M': " + string.Join(", ", citiesEndingWithM));
        Console.WriteLine("Міста, які починаються з 'N' і закінчуються на 'K': " + string.Join(", ", citiesStartingWithNAndEndingWithK));
        Console.WriteLine("Міста, які починаються з 'Ne' (за спаданням): " + string.Join(", ", citiesStartingWithNe));

        Console.WriteLine("\nЗавдання 3:");
        Console.WriteLine("Весь масив студентів:");
        foreach (var student in allStudents)
        {
            Console.WriteLine(student.ToString());
        }
        Console.WriteLine("Список студентів з ім'ям 'Boris':");
        foreach (var student in studentsWithNameBoris)
        {
            Console.WriteLine(student.ToString());
        }
        Console.WriteLine("Список студентів з прізвищем, яке починається з 'Bro':");
        foreach (var student in studentsWithSurnameBro)
        {
            Console.WriteLine(student.ToString());
        }
        Console.WriteLine("Список студентів старших 19 років:");
        foreach (var student in studentsOlderThan19)
        {
            Console.WriteLine(student.ToString());
        }
        Console.WriteLine("Список студентів віком від 20 до 23 років:");
        foreach (var student in studentsBetween20And23)
        {
            Console.WriteLine(student.ToString());
        }
        Console.WriteLine("Список студентів, які навчаються в MIT:");
        foreach (var student in mitStudents)
        {
            Console.WriteLine(student.ToString());
        }
        Console.WriteLine("Список студентів, які навчаються в Oxford і вік яких старше 18 років (за віком, за спаданням):");
        foreach (var student in oxfordStudentsAbove18)
        {
            Console.WriteLine(student.ToString());
        }
    }

    public class Student
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }
        public string School { get; }

        public Student(string firstName, string lastName, int age, string school)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            School = school;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, вік {Age}, навчається в {School}";
        }
    }
}
