using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace bookStore
{
    class myStore
    {
        static void Main(string[] args)
        {
            book harry_potter = new book();
            harry_potter.SetId(1);
            harry_potter.SetTitle("Harry Potter and the Sorcerer's Stone");
            harry_potter.SetAuthor("JK Rowling");
            book transactions = new book();
            transactions.SetTrans();

            book witcher = new book();
            Console.WriteLine("Please enter the book ID: ");
            witcher.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the book name: ");
            witcher.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the authors name: ");
            witcher.SetAuthor(Console.ReadLine());
            transactions.SetTrans();

            book thegiver = new book(3, "The Giver", "Lois Lowry");
            transactions.SetTrans();

            Console.WriteLine("Please enter the book ID: ");
            int tempid = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the book name: ");
            string tempName = Console.ReadLine();
            Console.WriteLine("Please enter the authors name: ");
            string tempAuthor = Console.ReadLine();
            book dracula = new book(tempid, tempName, tempAuthor);
            transactions.SetTrans();


            Console.WriteLine($"The store has sold {transactions.GetTrans()} books");
            displayBooks(harry_potter);
            displayBooks(witcher);
            displayBooks(thegiver);
            displayBooks(dracula);
        }

        static void displayBooks(book entry)
        {
            Console.WriteLine("Here is the store inventory information");
            Console.WriteLine($"Book ID: {entry.GetId()}");
            Console.WriteLine($"Book Name: {entry.GetTitle()}");
            Console.WriteLine($"Author Name: {entry.GetAuthor()}");
        }
    }
    class book
    {
        int _Id;
        string _Title;
        string _Author;
        private static int _transactions = 0;


        public book()
        {
            _Id = 0;
            _Title = "";
            _Author = "";
        }

        public book(int id, string title, string author)
        {
            _Id = id;
            _Title = title;
            _Author = author;
        }

        public int GetId()
        {
            return _Id;
        }

        public string GetTitle()
        {
            return _Title;
        }

        public string GetAuthor()
        {
            return _Author;
        }

        public void SetId(int identity)
        {
            _Id = identity;
        }

        public void SetTitle(string title)
        {
            _Title = title;
        }

        public void SetAuthor(string author)
        {
            _Author = author;
        }

        public void SetTrans()
        {
            _transactions++;
        }

        public int GetTrans()
        {
            return _transactions;
        }
    }
}
