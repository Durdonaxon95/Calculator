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
Console.WriteLine("Harajatlarni kiriting: ");
decimal umumiyyigindi=0;
string javob;
do {
    decimal miqdor=Convert.ToDecimal(Console.ReadLine());

    umumiyyigindi+=miqdor;
    Console.WriteLine("Yana harajat qo'shasizmi? (ha/yo'q)");
    javob = Console.ReadLine() ?? string.Empty;
    if (javob != null)
    {
        javob = javob.ToLower();
    }
} while (javob=="ha");
Console.WriteLine($"Umumiy harajatlar yig'indisi: {umumiyyigindi} so'm");

;

