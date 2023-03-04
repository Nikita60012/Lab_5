using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Students;
using Library;

namespace Lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student petrov = new Student("Петров В.В.", 2020, 15);
            Student pavlov = new Student("Павлов П.П.", 1820, 18);
            Student kuznetsov = new Student("Кузнецов К.А.", 2020, 17);
            Student[] studentsList = new Student[]{petrov, pavlov, kuznetsov};

            Reader petrovReader = new Reader(studentsList[0].fio, 112, "Программирование", "24/05/2008", "+7887833843");
            Reader pavlovReader = new Reader(studentsList[1].fio, 113, "Робототехника", "24/05/2005", "+7435346843");
            Reader kuznetsovReader = new Reader(studentsList[2].fio, 114, "3D-моделирование", "24/05/2006", "8368472143");
            Reader[] readersList = new Reader[] {petrovReader, pavlovReader, kuznetsovReader};
            int count = 0;
            foreach(Student student in studentsList)
            {
                student.Print();
                Console.WriteLine("Введите количество взятых книг");
                int book = Convert.ToInt32(Console.ReadLine());
                readersList[count].takeBook(book);
                readersList[count].returnBook(book);

                Console.WriteLine("Введите названия взятых книг, для того, чтобы завершить ввод списка книг, введите 0");
                string bookName = Console.ReadLine();
                List<String> bookList = new List<string>();

                while (!bookName.Equals("0"))
                {
                    bookList.Add(bookName);
                    bookName = Console.ReadLine();
                }

                readersList[count].takeBook(bookList);
                readersList[count].returnBook(bookList);
                count++;
                Console.WriteLine("---------------------------------------------------");
            }

            

            
        }
    }
}

