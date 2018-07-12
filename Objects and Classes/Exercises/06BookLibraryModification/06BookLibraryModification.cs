using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _05BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfBooks = int.Parse(Console.ReadLine());
            List<Books> books = new List<Books>();

            for (int i = 0; i < numOfBooks; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string title = tokens[0];
                string author = tokens[1];
                string publisher = tokens[2];
                DateTime releaseDate = DateTime.ParseExact(tokens[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                string isbn = tokens[4];
                decimal price = decimal.Parse(tokens[5]);

                Books book = new Books(title, author, publisher, releaseDate, isbn, price);

                books.Add(book);
            }

            DateTime givenDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Dictionary<string, DateTime> titles = new Dictionary<string, DateTime>();

            foreach (Books book in books.Where(d => d.ReleaseDate > givenDate))
            {
                string title = book.Title;
                DateTime date = book.ReleaseDate;

                if (!titles.ContainsKey(title))
                {
                    titles.Add(title, date);
                }
            }

            Dictionary<string, DateTime> sortedTitles = titles.OrderBy(a => a.Value).ThenBy(a => a.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var title in sortedTitles)
            {
                Console.WriteLine($"{title.Key} -> {title.Value:dd.MM.yyy}");
            }
        }
    }

    class Books
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }

        public Books(string title, string author, string publisher, DateTime releaseDate, string isbn, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.ReleaseDate = releaseDate;
            this.ISBN = isbn;
            this.Price = price;
        }
    }
}
