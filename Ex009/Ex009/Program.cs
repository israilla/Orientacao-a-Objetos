using System;
using System.Globalization;
using System.Collections.Generic;

namespace Ex009
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered ");
            int n = int.Parse(Console.ReadLine());

            List<Data> list = new List<Data>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = (Console.ReadLine());

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                list.Add(new Data(name, salary, id));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Data emp = list.Find(x => x.Id == searchId);
            if (emp != null)
            {
                Console.Write("Enter percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }
            Console.WriteLine();
            Console.WriteLine("Updated list of employees: ");
            foreach (Data obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.ReadKey();
        }
    }
}