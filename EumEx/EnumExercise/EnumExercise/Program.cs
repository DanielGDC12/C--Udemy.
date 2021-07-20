using System;
using System.Globalization;
using EnumExercise.Entities.Enums;
using EnumExercise.Entities;
using EnumExercise.Services;
using EnumExercise.Entities.Departments;

namespace EnumExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the  department`s name: ");
            string deptName = Console.ReadLine();
           
            Console.WriteLine("Enter worker data");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            
            Console.Write("Level (Junior / MidLevel / Senior ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine()); /*Conversao de um ENUMS */

            Console.Write("Base Salary");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(level, name, salary, dept);
            Console.WriteLine();

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i < n; i++)
            {
                Console.WriteLine($"Enter #{i} Contract Data");
                Console.Write("Data (DD / MM / YYYY) ");
               DateTime data = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine());

                Console.WriteLine("Duration (hours)");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(hours, value, data);
                worker.AddContract(contract);
                Console.WriteLine();

            }

            Console.WriteLine("Enter month e year to calculate income (MM / YYYY)");
            string monthAndyear = Console.ReadLine();

            int month = int.Parse(monthAndyear.Substring(0, 2));
            int year = int.Parse(monthAndyear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.departmentName);
            Console.WriteLine("Income for " + monthAndyear + ": " + worker.Income(year,month));


            
        }
    }
}
