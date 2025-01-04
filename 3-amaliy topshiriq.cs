//Tub sonlar
using System;

Console.WriteLine("Sonni kiriting: ");
int son = Convert.ToInt32(Console.ReadLine());
int sanoq = 0;
for (int i = 1; i <= son; i++)
{
    if (son % i == 0)
    {
        sanoq++;
    }
}
if (sanoq == 2)
{
    Console.WriteLine("Siz kiritgan son tub son");
}
else
{
    Console.WriteLine("Siz kiritgan son tub son emas");
}

// Bo'luvchi sonlar.
Console.WriteLine("Sonni kiriting: ");

int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{number} soning 2 dan 10 gacha bo'luvchilari: ");

for (int i = 2; i <= 10; i++)
{
    if (number % i == 0)
    {
        Console.WriteLine(i);
    }

}

//Darajani hisoblash
Console.WriteLine("Sonni kiriting: ");
double n = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Darajani kiriting: ");
double daraja = Convert.ToDouble(Console.ReadLine());

double natija = Math.Pow(n, daraja);
Console.WriteLine($"{n} ning {daraja} darajasi {natija} ga teng");

//Harajatlar to'plami yig'indisini hisoblash.
Console.WriteLine("Harajatlar sonini kiriting: ");

int harajat = Convert.ToInt32(Console.ReadLine());

int[] harajatlar=new int[harajat];
int umumiy=0;

for (int i = 0; i < harajat; i++)
{
    Console.WriteLine($"{i+1}-harajatni kiriting: ");
    harajatlar[i] = Convert.ToInt32(Console.ReadLine());
    umumiy+=harajatlar[i];
}

Console.WriteLine($"Umumiy harajatlar yig'indisi: {umumiy} so'm");


