using FirstHW.DAL;
using FirstHW.Models;
using System;

namespace FirstHW
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            InsertBook();
            Console.WriteLine("Book Succesfully Added.");

            DeleteBook(5);
            Console.WriteLine("Book Succesfullt Deleted.");
        }

        private static void InsertBook()
        {
            using (AppDbContext db = new AppDbContext())
            {
                db.Books.Add(new Book { Name = "It starts with us", Genre = "Romance", PageCount = 384, Price = 17.04 });
                db.SaveChanges();
            }
        }

        private static bool DeleteBook(int id)
        {
            AppDbContext db = new AppDbContext();
            Book books = db.Books.Find(id);
            db.Books.Remove(books);
            bool result = db.SaveChanges()>0;
            return result;
        }
    }
}
