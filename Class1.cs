using System;
    class Book{
        string title = "Chernobyl";
        int pages = 200;
        public void Describe()
        {
            Console.WriteLine($"{title} has {pages} pages");
        }
        public static void Main(string[] args)
        {
            Book b = new Book();
            b.Describe();
        }
    }
