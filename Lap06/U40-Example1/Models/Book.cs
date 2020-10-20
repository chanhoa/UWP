using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U40_Example1.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string CoverImage { get; set; }
    }

    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var Books = new List<Book>();
            Books.Add(new Book { BookId = 1, Title = "Doremon", Author = "Fujio", CoverImage = "Assets/1.jpg" });

            Books.Add(new Book { BookId = 2, Title = "PoKeMon", Author = "Takeshi Shudo", CoverImage = "Assets/2.jpg" });

            Books.Add(new Book { BookId = 3, Title = "Dragon Ball", Author = "Toriyama Akira", CoverImage = "Assets/3.jpg" });

            return Books;
        }
    }
}
