using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Reader
    {
        private string fio;
        int readTicketNumber;
        string faculty;
        private string birthdate;
        string phoneNumber;
        public Reader(string fio, int readTicketNumber, string faculty, string birthdate, string phoneNumber)
        {
            this.fio = fio;
            this.readTicketNumber = readTicketNumber;
            this.faculty = faculty;
            this.birthdate = birthdate;
            this.phoneNumber = phoneNumber;
        }
        public void takeBook(int takingBook) => Console.WriteLine($"{fio} взял {takingBook} книги");

        public void takeBook(List<String> listOfTakingBook)
        {
            Console.WriteLine($"{fio} взял книги: ");
            for (int i = 0; i < listOfTakingBook.Count; i++)
            {
                string book = listOfTakingBook[i];
                if (i < listOfTakingBook.Count - 1)
                    Console.Write(book + ", ");
                else
                    Console.Write(book + ".");
            }
            Console.WriteLine();
        }
        public void returnBook(int takingBook) => Console.WriteLine($"{fio} вернул {takingBook} книги");

        public void returnBook(List<String> listOfTakingBook)
        {
            Console.WriteLine($"{fio} вернул книги: ");
            for (int i = 0; i < listOfTakingBook.Count; i++)
            {
                string book = listOfTakingBook[i];
                if (i < listOfTakingBook.Count - 1)
                    Console.Write(book + ", ");
                else
                    Console.Write(book + ".");
            }
            Console.WriteLine();
        }
    }

}
