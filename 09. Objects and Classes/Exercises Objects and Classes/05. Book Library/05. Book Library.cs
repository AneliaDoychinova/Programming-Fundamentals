using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _05.Book_Library
{
    class Program
    {
        class Library
        {
            public string Name { get; set; }

            public List<Book> Books { get; set; }
        }
        class Book
        {
            public string Title { get; set; }

            public string Author { get; set; }

            public string Publisher { get; set; }

            public DateTime ReleaseDate { get; set; }

            public int ISBN { get; set; }

            public double Price { get; set; }

        }
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var listOfBooks = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(' ');
               
                var book = new Book 
                {
                    Title = tokens[0],
                    Author = tokens[1],
                    Publisher = tokens[2],
                    ReleaseDate = DateTime.ParseExact(tokens[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBN = int.Parse(tokens[4]),
                    Price = double.Parse(tokens[5])
                };

                listOfBooks.Add(book);
            }
            var library = new Library();
            library.Books = listOfBooks;

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

                Console.WriteLine("{0} -> {1:F2}", author, totalPrice);
            }
        }
    }
}

