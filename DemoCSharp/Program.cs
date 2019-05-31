using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoCSharp
{
    class Student {
        public Student(int id, string name,int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public override string ToString()
        {
            return "ID : "+this.id +" - Name : "+this.name+" - Age : "+this.age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student(1,"Hung",20),
                new Student(2,"Trinh",22),
                new Student(3,"Luu",30),
                new Student(5,"Messi",50),
                new Student(4,"Kaka",40),
                new Student(5,"Messi",50)
            };
            // var liststudent = from s in students where s.age > 19 && s.age < 25 select s;
            var liststudent = students.Where(s => s.age > 19 && s.age < 60).OrderBy(s=>s.name.Length).ToList();
            //Console.WriteLine(liststudent);
            foreach (Student item in liststudent)
            {
                Console.WriteLine(item.ToString());
            }


            List<string> arr = new List<string>() { 
                "abc","xyz","nmp","kpq"
            };
            int[] arra = new int[10];
           // arra[0] = 1;
            var items = from a in arr select a;
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
