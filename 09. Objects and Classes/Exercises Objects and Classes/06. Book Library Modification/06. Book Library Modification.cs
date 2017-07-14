using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace _06.Book_Library_Modification
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
                var input = Console.ReadLine().Split(' ');
                var book = new Book
                {
                    Title = input[0],
                    Author = input[1],
                    Publisher = input[2],
                    ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBN = int.Parse(input[4]),
                    Price = double.Parse(input[5])
                };

                listOfBooks.Add(book);
            }
            var givenDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            var library = new Library();
            library.Books = listOfBooks;

            var titlesDates = new Dictionary<string, DateTime>();

            for (int i = 0; i < library.Books.Count; i++)
            {
                var title = library.Books[i].Title;
                var releaseDate = library.Books[i].ReleaseDate;

                if (releaseDate.CompareTo(givenDate) == 1)
	            {
		            titlesDates[title] = releaseDate;
	            }
                
                
            }

            titlesDates = titlesDates.Select(a => a).OrderBy(a => a.Value).
                ThenBy(a => a.Key).ToDictionary(a => a.Key, a => a.Value);

            foreach (var kvp in titlesDates)
            {
                var title = kvp.Key;
                var date = kvp.Value;

                Console.WriteLine("{0} -> {1}", title,date.ToString("dd.MM.yyyy"));
            }
        }
    }
}
