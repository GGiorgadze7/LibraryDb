using System.Text;
using LibraryDb.Data;
using LibraryDb.Models;
using Microsoft.EntityFrameworkCore;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("wignebis gamotana");

using DataContext db = new DataContext();

var booksAndAuthor = db.Books.Include(a => a.Author).ToList();

foreach(var item in booksAndAuthor)
{
    Console.WriteLine($"Author: {item.Author.FullName}, Book: {item.Title}" );
    Console.WriteLine(item.info);
}



Book book = new Book()
{
    Title = "მგზავრის წერილები",
    AuthorId = 1
    

};

//db.Books.Add(book);
//db.SaveChanges();

