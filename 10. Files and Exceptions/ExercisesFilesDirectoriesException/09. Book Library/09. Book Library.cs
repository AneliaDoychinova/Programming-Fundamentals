using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace _09.Book_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllLines("input.txt");

            var listOfBooks = new List<Book>();

            for (int i = 0; i < input.Length; i++)
            {
                var currentBook = input[i].Split(' ');

                var title = currentBook[0];
                var author = currentBook[1];
                var publisher = currentBook[2];
                var releaseDate = DateTime.ParseExact(currentBook[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                var isbn = currentBook[4];
                var price = double.Parse(currentBook[5]);

                var book = new Book
                {
                    Title = title,
                    Author = author,
                    Publisher = publisher,
                    ReleaseDate = releaseDate,
                    Isbn = isbn,
                    Price = price
                };

                listOfBooks.Add(book);
            }

            var library = new Library 
            {
                Name = "Prosveta",
                Books = listOfBooks
            };

            var SumDict = new Dictionary<string, double>();

            for (int i = 0; i < library.Books.Count; i++)
            {
                var author = library.Books[i].Author;
                var price = library.Books[i].Price;
                if (!SumDict.ContainsKey(author))
                {
                    SumDict[author] = 0;
                }

                SumDict[author] += price;
            }

            SumDict = SumDict.Select(a => a).OrderByDescending(a => a.Value).
                ThenBy(a => a.Key).ToDictionary(a => a.Key, a => a.Value);

            foreach (var kvp in SumDict)
            {
                var author = kvp.Key;
                var totalPrice = kvp.Value;

                File.AppendAllText("output.txt", author + " -> " + totalPrice + Environment.NewLine);
            }
        }

        class Book
        {
            public string Title { get; set; }

            public string Author { get; set; }

            public string Publisher { get; set; }

            public DateTime ReleaseDate { get; set; }

            public string Isbn { get; set; }

            public double Price { get; set; }
        }

        class Library
        {
            public string Name { get; set; }

            public List<Book> Books { get; set; }
        }
    }
}
