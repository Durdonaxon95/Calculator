
using System;
namespace OOPAPP
{
    enum Baho { A = 5, B = 4, C = 3, D = 2, F = 1 }

    class Student
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Ism { get; set; }
        public string Familya { get; set; }
        public int Sinf { get; set; }
        public Baho baho { get; set; }
    }
    class CarAdvise
    {
        public string Nomi { get; set; }
        public string Brand { get; set; }
        public decimal Narxi { get; set; }
    }
    class Bokschi
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Ism { get; set; }
        public string Familya { get; set;}
        public int Yoshi { get; set;}
        public double Ogirligi { get; set;}
    }   

    class Program
    {
        static void Main()
        {
           List<Student> students = new List<Student>
           {
                new Student { Ism = "Durdona", Familya = "Qilichova", Sinf = 10, baho = Baho.A },
                new Student { Ism = "Sarvinoz", Familya = "Aloxonova", Sinf = 9, baho = Baho.B },
                new Student { Ism = "Hasan", Familya = "Tohirov", Sinf = 11, baho = Baho.C },
                new Student { Ism = "Husan", Familya = "Tohirov", Sinf = 10, baho = Baho.A },
                new Student { Ism = "Zarina", Familya = "Qodirova", Sinf = 12, baho = Baho.B }
           };

            Console.Write("Bahoni kiriting (5, 4, 3, 2, 1): ");
            if (Enum.TryParse(Console.ReadLine(), out Baho inputGrade))
            {
                var filteredStudents = students.Where(s => s.baho == inputGrade).ToList();

                Console.WriteLine($"{inputGrade} baho olgan o'quvchilar:");
            
                foreach (var student in filteredStudents)
                {
                   Console.WriteLine($"O'quvchi ID:{student.Id} \n{student.Ism} {student.Familya}, {student.Sinf}-sinf");
                }
            }
            else
            {
                Console.WriteLine("Noto'g'ri baho kiritildi!");
            }

            List<CarAdvise> cars = new List<CarAdvise>
            {
                new CarAdvise { Nomi = "Model S ", Brand = "Tesla", Narxi = 79999},
                new CarAdvise { Nomi = "Mustang", Brand = "Ford", Narxi = 55999},
                new CarAdvise { Nomi = "Tracer", Brand = "Chevrolet", Narxi=20999},
                new CarAdvise { Nomi = "Arizzo", Brand = "Cherry", Narxi = 20999},
                new CarAdvise { Nomi = "Gladiator", Brand = "Jeep", Narxi = 92999},
                new CarAdvise { Nomi = "Gentra", Brand = "Chevrolet", Narxi = 85999},
                new CarAdvise { Nomi = "Corolla wagon", Brand = "Toyota", Narxi = 86999}
            };
            Console.WriteLine("\nBirinchi narxni kiriting: ");
            decimal narx1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ikkinchi narxni kiriting: ");
            decimal narx2 = Convert.ToDecimal(Console.ReadLine());

            var filteredCars = cars.Where(car => car.Narxi >= Math.Min(narx1,narx2) && car.Narxi <= Math.Max(narx1,narx2)).ToList();
            Console.WriteLine("\nTanlangan narx oralig'idagi avtomobillar: ");
             
            foreach (var car in filteredCars)
            {
                Console.WriteLine($"Avtomobil: {car.Nomi}, Brend: {car.Brand}, Narxi: {car.Narxi}");
            }

            List<Bokschi> bokschi = new List<Bokschi>
            {
                new Bokschi { Ism = "Shaxram", Familya = "G'iyosov", Yoshi = 22, Ogirligi = 48 },
                new Bokschi { Ism = "Vali", Familya = "Aliyev", Yoshi = 25, Ogirligi = 55 },
                new Bokschi { Ism = "Hasanboy", Familya = "Do'smatov", Yoshi = 30, Ogirligi = 70 },
                new Bokschi { Ism = "Fayozxon", Familya = "Hasanov", Yoshi = 28, Ogirligi = 80 },
                new Bokschi { Ism = "Abdulatif", Familya = "Qodirov", Yoshi = 24, Ogirligi = 52 }
            };

            var lightWeightBoxers = bokschi.Where(b => b.Ogirligi <= 50).ToList();
            var middleWeightBoxers = bokschi.Where(b => b.Ogirligi > 50 && b.Ogirligi <= 76).ToList();
            var heavyWeightBoxers = bokschi.Where(b => b.Ogirligi > 76).ToList();

            Console.WriteLine("\nYengil vazndagi bokschilar (50 kg gacha):");
            PrintBokschi(lightWeightBoxers);

            Console.WriteLine("\nO'rta vazndagi bokschilar (50 dan 76 kg gacha):");
            PrintBokschi(middleWeightBoxers);

            Console.WriteLine("\nOg'ir vazndagi bokschilar (76 kg dan yuqori):");
            PrintBokschi(heavyWeightBoxers);
        }

        static void PrintBokschi(List<Bokschi> bokschi)
        {
            foreach (var bokschilar in bokschi)
            {
                Console.WriteLine($"{bokschilar.Ism} {bokschilar.Familya}, Yosh: {bokschilar.Yoshi}, Vazn: {bokschilar.Ogirligi}kg");
            }
        }
    }
}   

  
