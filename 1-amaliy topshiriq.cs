using System;

partial class Program
{
	static void Main()
	{
		Console.WriteLine("Doira radiusini kiriting: ");
		double radius = Convert.ToInt32(Console.ReadLine());
		double pi = 3.14;
		double doirayuzi = pi * radius * radius;
		double doiraperimetri = 2 * pi * radius;
		System.Console.WriteLine($"Doira yuzi: S= {doirayuzi}");
		System.Console.WriteLine($"Doira perimetri: P= {doiraperimetri}");
	}
}
