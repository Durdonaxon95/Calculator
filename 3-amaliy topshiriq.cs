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

