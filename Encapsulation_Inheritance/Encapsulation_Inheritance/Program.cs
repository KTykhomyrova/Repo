using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Encapsulation_Inheritance
{
    internal class Program
    {
        class Vehicle
        {
            // Поля и методы (инкапсуляция)
            private string _brand;
            private int _speed;
            public void SetBrand(string value)
            {
                _brand = value;
            }
            public string GetBrand()
            {
                return _brand;
            }

            public int GetSpeed()
            {
                return _speed;
            }

            public void SetSpeed(int value) 
            {
                if (value > 0)
                {
                    _speed = value;
                }
                else
                {
                    throw new ArgumentException("Скорость не может быть меньше 0");
                }
            }

            

            public virtual void ShowInfo()
            {
                Console.WriteLine($"Brand: {_brand}, speed: {_speed}");
            }
        }

        // Класс-наследник (protected поле, переопределение метода)
        class Car : Vehicle
        {
            // Наследование, protected поле, переопределение метода
            private string _fuelType;

            public void SetFuelType(string value)
            {
                _fuelType = value;
            }

           
            public override void ShowInfo()
            {
                Console.WriteLine($"Brand: {GetBrand()}, speed: {GetSpeed()}, fuel type: {_fuelType}");
            }
        }

        // Класс-наследник с base() и override
        class ElectricCar : Car
        {
            // Использование base, новое поле, переопределение метода
            private int _batteryCapacity;

            public void SetBatteryCapacity(int value)
            {
                _batteryCapacity = value;
            }

            public ElectricCar(string brand, int speed, int batteryCapacity) : base(brand, speed)
            {
                _batteryCapacity = batteryCapacity;
            }

          
            public override void ShowInfo()
            {
                base.ShowInfo();
                Console.WriteLine($"Battery Capacity: {_batteryCapacity} kWh");
            }

        }
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle();
            v.SetBrand("Toyota");
            v.SetSpeed(200);
            v.ShowInfo();

            Car car = new Car();
            car.SetBrand("DACIA");
            car.SetSpeed(250);
            car.SetFuelType("Fluel");
            car.ShowInfo();
            Console.ReadKey();
        }
    }
}
