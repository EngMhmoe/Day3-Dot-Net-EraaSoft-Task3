
using static System.Net.WebRequestMethods;
using static System.Reflection.Metadata.BlobBuilder;

namespace mainTask
{
    #region Class New Book
    
    class Book
    {
        #region is Attributes ==> Example ==> {id: 1 , name : "Mohamed"}

        public int iSBN;
        public string title;
        public string author;
        public bool availablility;

        #endregion





        #region Constructor Book

        public Book(int iSBN, string title, string author, bool availablility = true)
        {
            this.iSBN = iSBN;
            this.title = title;
            this.author = author;
            this.availablility = availablility;
        }

        #endregion





        #region Desplay Info Book ToString ==> 2 Exxample ==> string لى Opject الفكره بتحولى ال 

        //Cal Method ده هتشتغل لما أعملها 
        public string DesplayInfoBookToString()
        {
            return $"ISBN: {iSBN}, Title: {title}, Author: {author}, Available: {availablility}";
        }


        // OR


        //الى انا فيه class على override ده بتشتتغل على طول يعنى بعمل
        public override string ToString()
        {
            return $"ISBN: {iSBN}, Title: {title}, Author: {author}, Available: {availablility}";
        }

        #endregion 
    }

    #endregion





    /// <summary>
    /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>





    #region Class Collection Library

    class Library
    {
        #region Attributes is List

        List<Book> books;

        #endregion





        #region Constructor Library New List

        public Library ()
        {
            this.books = new List<Book>();
        }

        #endregion





        #region Add Book

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        #endregion





        #region Display Info Book

        public void DisplayInfoBook(Book book)
        {
            Console.WriteLine(book.DesplayInfoBookToString());   // ==> Cal Method DesplayInfoBookToString()

            // OR

            //Console.WriteLine(book.ToString());   // ==> Cal Method ToString()

            // OR

            //Console.WriteLine(book); // الخاص بى طريقه طباعه الكتاب ازى كا نص فاهم override string ToString  لازم نفعل معاها ال

            // OR

            //Console.WriteLine($"ISBN: {book.iSBN}, Title: {book.title}, Author: {book.author}, Available: {book.availablility}");
        }

        #endregion





        #region Display ALL Books

        public void DisplayALLBooks()
        {
            #region For

            //for(int  i = 0; i < books.Count; i++)
            //{


            //Console.WriteLine(books[i].DesplayInfoBookToString());   // ==> Cal Method DesplayInfoBookToString()

            // OR

            //Console.WriteLine(books[i].ToString());   // ==> Cal Method ToString()

            // OR

            //Console.WriteLine(books[i]); // الخاص بى طريقه طباعه الكتاب ازى كا نص فاهم override string ToString  لازم نفعل معاها ال

            // OR

            //Console.WriteLine($"ISBN: {books[i].iSBN}, Title: {books[i].title}, Author: {books[i].author}, Available: {books[i].availablility}");


            //}

            #endregion



            // OR



            #region foreach

            foreach (Book book in books)
            {

                //Console.WriteLine(book.DesplayInfoBookToString());   // ==> Cal Method DesplayInfoBookToString()

                // OR

                Console.WriteLine(book.ToString());   // ==> Cal Method ToString()

                // OR

                //Console.WriteLine(book); // الخاص بى طريقه طباعه الكتاب ازى كا نص فاهم override string ToString  لازم نفعل معاها ال

                // OR

                //Console.WriteLine($"ISBN: {book.iSBN}, Title: {book.title}, Author: {book.author}, Available: {book.availablility


            }

            #endregion
        }

        #endregion





        #region Search Book

        public void SearchBook(string BookORAthor)
        {
            string ResultSearchBook = "Is Not Book";

            for (int i = 0; i < books.Count; i++)
            {
                if (BookORAthor == books[i].title || BookORAthor == books[i].author)
                {
                    //ResultSearchBook = $"Name Search is {BookORAthor} = " + books[i].DesplayInfoBookToString();   // ==> Cal Method DesplayInfoBookToString()

                    // OR

                    //ResultSearchBook = $"Name Search is {BookORAthor} = " + books[i].DesplayInfoBookToString().ToString();   // ==> Cal Method ToString()

                    // OR

                    ResultSearchBook = $"Name Search is {BookORAthor} = " + books[i];    // الخاص بى طريقه طباعه الكتاب ازى كا نص فاهم override string ToString  لازم نفعل معاها ال

                    // OR

                    //ResultSearchBook = $"ISBN: {books[i].iSBN}, Title: {books[i].title}, Author: {books[i].author}, Available: {books[i].availablility}";

                }
            }

            Console.WriteLine(ResultSearchBook);
        }

        #endregion





        #region Borrow Book

        public void BorrowBook(string Namebook)
        {
            string ResultBorrowBook = "Is Not Borrow Book";

            for (int i = 0; i < books.Count; i++)
            {
                if (Namebook == books[i].title)
                {

                    ResultBorrowBook = $"Name Book is {Namebook} = ISBN: {books[i].iSBN}, Title: {books[i].title}, Author: {books[i].author}, Available: {books[i].availablility = false}";

                    //books.Remove(books[i]);

                }
            }

            Console.WriteLine(ResultBorrowBook);
        }

        #endregion





        #region Return Book

        public void ReturnBook(string Namebook)
        {
            string ResultReturnBook = "Is Not Return Book";

            for (int i = 0; i < books.Count; i++)
            {
                if (Namebook == books[i].title)
                {

                    ResultReturnBook = $"Name Book is {Namebook} = ISBN: {books[i].iSBN}, Title: {books[i].title}, Author: {books[i].author}, Available: {books[i].availablility = true}";

                }
            }

            Console.WriteLine(ResultReturnBook);
        }

        #endregion
    }

    #endregion





    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Libaray Management System:\n");





            ////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////





            #region Clone Books

            Book book1 = new Book(1, "Book1", "Author1" , true);

            Book book2 = new Book(2, "Book2", "Author2" , true);

            Book book3 = new Book(3, "Book3", "Author3" , true);

            Book book4 = new Book(4, "Book4", "Author4" , true);

            Book book5 = new Book(5, "Book5", "Author5" , true);

            #endregion





            ////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////





            #region Clone Library

            Library Library = new Library();

            #endregion





            ////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////





            #region Cal Method Add Book
            
            Library.AddBook(book1);
            Library.AddBook(book2);
            Library.AddBook(book3);
            Library.AddBook(book4);
            Library.AddBook(book5);
            Library.AddBook(book1);
            Library.AddBook(book2);
            Library.AddBook(book3);
            Library.AddBook(book4);
            Library.AddBook(book5);

            #endregion





            ////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////





            #region Cal Method Display Info Book

            Console.WriteLine("Display Info Book: ");

            Library.DisplayInfoBook(book1);
            Library.DisplayInfoBook(book2);
            Library.DisplayInfoBook(book3);
            Library.DisplayInfoBook(book4);
            Library.DisplayInfoBook(book5);

            #endregion





            ////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n\n/////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////\n\n");
            ////////////////////////////////////////////////////////////////////////////////





            #region Cal Method Display ALL Books

            Console.WriteLine("Display ALL Books: ");

            Library.DisplayALLBooks();

            #endregion





            ////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n\n/////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////\n\n");
            ////////////////////////////////////////////////////////////////////////////////





            #region Cal Method Search Book

            Console.WriteLine("Search Books: ");

            Library.SearchBook("Book1");
            Library.SearchBook("Author1");

            Library.SearchBook("Book2");
            Library.SearchBook("Author2");

            Library.SearchBook("Book3");
            Library.SearchBook("Author3");

            Library.SearchBook("Book4");
            Library.SearchBook("Author4");

            Library.SearchBook("Book5");
            Library.SearchBook("Author5");

            #endregion





            ////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n\n/////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////\n\n");
            ////////////////////////////////////////////////////////////////////////////////





            #region Cal Method Boorow Book

            Console.WriteLine("Mark a Books As Brrowed: ");

            Library.BorrowBook("Book1");
            Library.BorrowBook("Book2");
            Library.BorrowBook("Book2");
            Library.BorrowBook("Book3");
            Library.BorrowBook("Book4");
            Library.BorrowBook("Book5");

            #endregion





            ////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n\n/////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////\n\n");
            ////////////////////////////////////////////////////////////////////////////////





            #region Cal Method Return Book

            Console.WriteLine("Mark a Books As Return: ");

            Library.ReturnBook("Book1");
            Library.ReturnBook("Book2");
            Library.ReturnBook("Book3");
            Library.ReturnBook("Book4");
            Library.ReturnBook("Book5");

            #endregion
        }
    }
}
