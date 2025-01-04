using System;
Console.WriteLine("Birinchi sonni kiriting: ");
int birinchison = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ikkinchi sonni kiriting: ");
int ikkinchison = Convert.ToInt32(Console.ReadLine());
if (birinchison > ikkinchison)
{
    Console.WriteLine("Birinchi son katta");
}
else if (birinchison < ikkinchison)
{
    Console.WriteLine("Ikkinchi son katta");
}
else
{
    Console.WriteLine("Sonlar teng");
}