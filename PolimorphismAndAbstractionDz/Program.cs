using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphismAndAbstractionDz
{
    internal class Program
    {
        abstract class Employee
        {
            // name, SetName, GetName
            public string name;
            public void SetName(string value)
            {
                name = value;
            }
            public string GetName()
            {
                return name;
            }
            public abstract double CalculateSalary();
        }

        class FullTimeEmployee : Employee
        {
            // поле monthlySalary, SetSalary
            private double _monthSalary;

            public void SetSalary(double value)
            {
                _monthSalary = value;
            }

            // реализация CalculateSalary
            public override double CalculateSalary()
            {
                return _monthSalary;
            }
        }

        class PartTimeEmployee : Employee
        {
            // hourlyRate, hoursWorked
            private double _hourlyRate;
            private int _hoursWorked;

            // SetHourlyRate, SetHoursWorked
            public void SetHourlyRate(double value)
            {
                _hourlyRate = value;
            }
            public void SetHoursWorked(int value)
            {
                _hoursWorked = value;
            }

            // реализация CalculateSalary
            public override double CalculateSalary()
            {
                return _hourlyRate * _hoursWorked;
            }
        }

        static void Main()
        {
            // Массив Employee[], установка данных и вывод
            Employee[] employees = new Employee[2];

            FullTimeEmployee fullTime = new FullTimeEmployee();
            fullTime.name = "John";
            fullTime.SetSalary(5000);

            PartTimeEmployee partTime = new PartTimeEmployee();
            partTime.name = "Alice";
            partTime.SetHourlyRate(20);
            partTime.SetHoursWorked(80);

            employees[0] = fullTime;
            employees[1] = partTime;

            foreach (var employee in employees)
            {
                Console.WriteLine($"Name: {employee.name}, Salary: {employee.CalculateSalary()}");
            }
            Console.ReadKey();
        }
    }
}
