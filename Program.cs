using System;

    class Program
    {
        static void Main()
        {
            // 1 dan 1000 gacha bo'lgan toq sonlarning yigindisini topish.
            int yigindi = 0;
            int son = 1;
            while (son <= 1000)
            {
                yigindi += son;
                son += 2;
            }
            Console.WriteLine("1 dan 1000 gacha bo'lgan toq sonlar yig'indisi: " + yigindi);
            
            //Array ichidagi eng katta va eng kichik qiymatlarni ko'paytmasini topish.
            int[] sonlar = { 3, 4, 5, 6, 7, 8, 9, 10,11,12,13,14,15 };
            int engKatta = sonlar[0];
            int engKichik = sonlar[0];
            for (int iterator = 1; iterator< sonlar.Length; iterator++)
            {
                if (sonlar[iterator] > engKatta)
                {
                    engKatta = sonlar[iterator];
                }
                if (sonlar[iterator] < engKichik)
                {
                    engKichik = sonlar[iterator];
                }
            }
            Console.WriteLine("Eng katta qiymat: " + engKatta);
            Console.WriteLine("Eng kichik qiymat: " + engKichik);
            Console.WriteLine($"{engKichik} * {engKatta} = "+ (engKatta * engKichik));

            //x! faktorial x ni hisoblash.
            Console.WriteLine("Faktorialni hisoblash uchun sonni kiriting: ");
            int faktorial = Convert.ToInt32(Console.ReadLine());
            int faktorialNatija = 1;
            for (int iterator = 1; iterator <= faktorial; iterator++)
            {
                faktorialNatija *= iterator;
            }
            Console.WriteLine($"{faktorial}! = " + faktorialNatija);


    }
    
        
    
}
