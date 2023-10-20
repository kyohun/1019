using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empty_개체
{
    internal class Book
    {
        internal static Book Empty = new Book("","","");
        internal string Title { get; set; }
        internal string Description { get; set; }
        internal string Author { get; set; }
        internal Book(string title,string desc,string author) 
        {
            Title = title;
            Description = desc;
            Author = author;
        }
        public override string ToString()
        {
            return Title;
        }
    }
    internal class Program
    {
        static internal Book MakeBook()
        {
            return Book.Empty;
        }
        static void Main(string[] args)
        {
            Book book = MakeBook();
            if(book != Book.Empty)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}
