
using EnumExercise.Entities.Enums;
using EnumExercise.Services;
using EnumExercise.Entities.Departments;
using System.Collections.Generic;

namespace EnumExercise.Entities
{
    class Worker

    {
        public WorkerLevel Level { get; set; }
        public string Name { get; set; }

        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();


        public Worker() { }

        public Worker(WorkerLevel level, string name, double baseSalary, Department department) : this(level, name, baseSalary)
        {
            Department = department;
        }

        public Worker(WorkerLevel level, string name, double baseSalary)
        {
            Level = level;
            Name = name;
            BaseSalary = baseSalary;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            foreach(HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
