using System;

namespace CarApp
{
    class Car
    { 
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public decimal Speed { get; set; }

        public void GetCarInfo (string model, int year, decimal price, decimal speed)
        {
            Model = model;
            Year = year;
            Price = price;
            Speed = speed;
        }

        public void Display()
        {
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Price: {Price}$");
            Console.WriteLine($"Speed: {Speed}");
        }

        public void CalculateDepreciation(int years)
        {
            decimal depreciation = Price;
            for (int i = 0; i < years; i++)
            {
                depreciation = depreciation - (depreciation * 10 / 100);
            }
           

            Console.WriteLine($"After {years} years, the car {Model} will cost {depreciation}$");

            
        }
        
           
        



    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.GetCarInfo("Toyota", 2019, 50000, 200);
            car.Display();
            car.CalculateDepreciation(5); 
            car.CalculateDepreciation(10);
            
            car.GetCarInfo("BMW", 2020, 100000, 250);
            car.Display();
            car.CalculateDepreciation(5);
            car.CalculateDepreciation(10);
        }
    }
}
