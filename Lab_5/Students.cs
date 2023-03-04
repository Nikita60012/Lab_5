using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Student
    {
        public string fio;
        int id;
        private int age;
        public Student(string fio, int id, int age)
        {
            this.fio = fio;
            this.id = id;
            this.age = age;
        }

        public void Print() => Console.WriteLine($"ФИО:{fio}; номер группы: {id}; возраст: {age}");
    }
}
