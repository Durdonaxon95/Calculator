using System;
int birinchison = Convert.ToInt32(Console.ReadLine());
int ikkinchison = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Birinchi son ikkinchi sondan kattami?  {birinchison>ikkinchison}");
System.Console.WriteLine($"Ikkinchi son birinchi sondan kattami?  {birinchison<ikkinchison}");
System.Console.WriteLine($"Birinchi son ikkinchi sondan kattami yoki tengmi?  {birinchison>=ikkinchison}");
System.Console.WriteLine($"Ikkinchi son birinchi sondan kattami yoki tengmi?  {birinchison<=ikkinchison}");
System.Console.WriteLine($"Birinchi son ikkinchi son bilan tengmi?  {birinchison==ikkinchison}");
System.Console.WriteLine($"Birinchi son ikkinchi son bilan teng emasmi?  {birinchison!=ikkinchison}");
