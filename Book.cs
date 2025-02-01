using System;
 namespace BookApp
 {
    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public int Pages { get; set; }
        public double Price { get; set; }
        public Book(string name, string author, int year, string genre, int pages, double price)
        {
            Name = name;
            Author = author;
            Year = year;
            Genre = genre;
            Pages = pages;
            Price = price;
        }
        


        public void Display()
        {
            Console.WriteLine("Kitob nomi: " + Name);
            Console.WriteLine("Muallif: " + Author);
            Console.WriteLine("Yili: " + Year);
            Console.WriteLine("Janri: " + Genre);
            Console.WriteLine("Sahifalar soni: " + Pages);
            Console.WriteLine("Narxi: " + Price +  "$");
        }



    }
 }




