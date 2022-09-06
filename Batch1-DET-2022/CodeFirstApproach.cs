using Batch1_DET_2022.Models;
using Batch1_DET_2022.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class CodeFirstApproach
    {
        public static void Main(string[] args)
        {
            //AddNewBook();
            //DeleteNewBook();
            UpdateNewBook();
            Console.ReadLine();
        }

        private static void AddNewBook()
        {
            var ctx = new BookContext();
            Book book = new Book();
           

            book.BookID = 3;
            book.BookName = "Sql core";
            book.author = "Rohan";
            book.price = 350;

            try
            {
                ctx.Book.Add(book);
                ctx.SaveChanges();
                Console.WriteLine("new book successfully Added");

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.InnerException.Message);
            }

        }

        private static void DeleteNewBook()
        {
            var ctx = new BookContext();
            Book book = new Book();


            book.BookID = 3;
            book.BookName = "Sql core";
            book.author = "Rohan";
            book.price = 350;

            try
            {
                ctx.Book.Remove(book);
                ctx.SaveChanges();
                Console.WriteLine("new book successfully removed");

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.InnerException.Message);
            }
        }

        private static void UpdateNewBook()
        {
            var ctx = new BookContext();
            var Books = ctx.Book.Where(b => b.BookID == 3).SingleOrDefault();
            try
            {
                
                Books.BookName = "Asp.net";
                ctx.Update(Books);
                ctx.SaveChanges();
                Console.WriteLine("One Book Updated");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }



    }
}
