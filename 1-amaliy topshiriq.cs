using System;

partial class Program
{
	static void Main()
	{
		Console.WriteLine("Doira radiusini kiriting: ");
		double radius =Convert.ToDouble(Console.ReadLine());
		double pi = 3.14;
		double doirayuzi = pi * radius * radius;
		double doiraperimetri = 2 * pi * radius;
		System.Console.WriteLine($"Doira yuzi: S= {doirayuzi}");
		System.Console.WriteLine($"Doira perimetri: P= {doiraperimetri}");
		 
		 //Dollar kursini hisoblash
		 Console.WriteLine("Qiymatni kiriting: ");
		 double qiymat = Convert.ToDouble(Console.ReadLine());
		 double dollar = 12400*qiymat;
		 System.Console.WriteLine($"Dollar kursi: {dollar} so'm");

		 //Foydalanuvchi yoshini kunlarda aniqlash
		 Console.WriteLine("Tug'ilgan yilingizni kiriting: ");
		 int yil= Convert.ToInt32(Console.ReadLine());
		 int yosh = DateTime.Now.Year - yil;
		 int kun = yosh * 365;
		 System.Console.WriteLine($"Siz {kun} kun yashadingiz");

	}
}
