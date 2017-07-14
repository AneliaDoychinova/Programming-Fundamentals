using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;

namespace _10.Book_Library_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllLines("input.txt");
            var afterDate = DateTime.ParseExact(File.ReadAllText("date.txt"), "dd.MM.yyyy", CultureInfo.InvariantCulture);
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

            var titlesDates = library.Books.Where(b => b.ReleaseDate > afterDate).OrderBy(d => d.ReleaseDate).
                ThenBy(t => t.Title).ToArray();

            foreach (var kvp in titlesDates)
            {
                var title = kvp.Title;
                var date = kvp.ReleaseDate;

                File.AppendAllText("output.txt", title + " -> " + date.ToString("dd.MM.yyyy") + Environment.NewLine);
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
