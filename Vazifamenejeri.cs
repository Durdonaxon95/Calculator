using System;

    class Program
    {
        static string[] vazifalar = new string[10];
        static int vazifaIndex = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Vazifa menejiri");
            bool ishBajarildi = false;
            while (!ishBajarildi)
            {
                Console.WriteLine("1. Vazifa qo'shish");
                Console.WriteLine("2. Vazifalarni ko'rish");
                Console.WriteLine("3. Bajarilgan vazifani belgilash");
                Console.WriteLine("4. Vazifani o'chirish");
                Console.WriteLine("5. Dasturdan chiqish");
                Console.WriteLine("Tanlang: ");
                string tanlov = Console.ReadLine();
                switch (tanlov)
                {
                    case "1":
                        VazifaQoshish();
                        break;
                    case "2":
                        VazifalarniKorish();
                        break;
                    case "3":
                        VazifaniBajarildiQilibBelgilash();
                        break;
                    case "4":
                        VazifaniOchirish();
                        break;
                    case "5":
                        ishBajarildi = true;
                        break;
                    default:
                        Console.WriteLine("Noto'g'ri tanlov!");
                        break;
                }
            }
        }


        static void VazifaQoshish()
        {
            if (vazifaIndex < vazifalar.Length)
            {
                Console.WriteLine("Vazifa nomini kiriting: ");
                string? input = Console.ReadLine();
                if (input != null)
                {
                    vazifalar[vazifaIndex] = input;
                    vazifaIndex++;
                }
                else
                {
                    Console.WriteLine("Vazifa nomi kiritilmadi!");
                }
            }
            else
            {
                Console.WriteLine("Vazifalar ro'yxati to'la!");
            }
        }

        static void VazifalarniKorish()
        {
            Console.WriteLine("Vazifalar ro'yxati:");
            for (int i = 0; i < vazifaIndex; i++)
            {
                Console.WriteLine($"{i + 1}.Vazifa: {vazifalar[i]}");
            }
        }

        static void VazifaniBajarildiQilibBelgilash()
        {
            Console.WriteLine("Bajarilgan vazifa raqamini kiriting: ");
            int raqam = Convert.ToInt32(Console.ReadLine());
            if (raqam > 0 && raqam <= vazifaIndex)
            {
                vazifalar[raqam - 1] += " (bajarildi)";
            }
            else
            {
                Console.WriteLine("Noto'g'ri raqam!");
            }
        }

        static void VazifaniOchirish()
        {
            Console.WriteLine("O'chiriladigan vazifa raqamini kiriting: ");
            int raqam = Convert.ToInt32(Console.ReadLine());
            if (raqam > 0 && raqam <= vazifaIndex)
            {
                for (int i = raqam - 1; i < vazifaIndex - 1; i++)
                {
                    vazifalar[i] = vazifalar[i + 1];
                }
                vazifaIndex--;
            }
            else
            {
                Console.WriteLine("Noto'g'ri raqam!");
            }
        }
    }


    
        
    
