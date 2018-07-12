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

            Dictionary<string, decimal> authors = new Dictionary<string, decimal>();

            foreach (Books book in books)
            {
                string authorName = book.Author;
                decimal price = book.Price;

                if (!authors.ContainsKey(authorName))
                {
                    authors.Add(authorName, 0);
                }

                authors[authorName] += price;
            }

            Dictionary<string, decimal> sortedAuthors = authors.OrderByDescending(a => a.Value).ThenBy(a => a.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var author in sortedAuthors)
            {
                Console.WriteLine($"{author.Key} -> {author.Value:f2}");
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

        public Books (string title, string author, string publisher, DateTime releaseDate, string isbn, decimal price)
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
