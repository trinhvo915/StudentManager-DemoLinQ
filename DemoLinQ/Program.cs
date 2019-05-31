using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> listStudent = new List<Student>() {
                new Student(1,"Hung", 20,"15T3"),
                new Student(2,"Thoai",23,"15T1"),
                new Student(3,"Luu",20,"15T3"),
                new Student(4,"Tri",23,"15T1"),
                new Student(5,"Nguyen",26,"15T4"),
                new Student(6,"Kaka",27,"15T3"),
                new Student(7,"Huang", 20,"15T5")
            };
            IList<Clazz> listClass = new List<Clazz> {
                new Clazz("15T3","CNTT"),
                new Clazz("15T1","CNTT"),
                new Clazz("15T4","CNTT"),
                new Clazz("15T2","CNTT"),
                new Clazz("15T5","CNTT")
            };

            
            //Sort
            // sort student with age if age equal then sort with name student
            var listOrderBy = listStudent.OrderBy(s => s.age).ThenBy(s=>s.name);
            foreach(Student item in listOrderBy)
            {
                Console.WriteLine(item);
            }
            // filter 
            // Filter students that we have age more than 25 and name equal "Nguyen"
            Console.WriteLine("+++++++++++++++++++++");
            var listFilter = listStudent.Where(s=>s.age>25).Where(s=>s.name =="Nguyen");
            foreach (Student item in listFilter)
            {
                Console.WriteLine(item);
            }
            // GroupBy
            Console.WriteLine("+++++++++++++++++++++");
            var listGroupBy = listStudent.GroupBy(s => s.age);
            foreach(var item in listGroupBy)
            {
                Console.WriteLine("Group Age {0}", item.Key); // each item will have a key 
                foreach(Student student in item)
                {
                    Console.WriteLine(student); // each item will have a list student 
                }

            }

            //Inner Join 
            var listInnerJoin = listStudent.Join(listClass,
                student => student.clazz,
                clazz => clazz.name,
                (student, clazz) => new
                {
                    StudentId = student.id,
                    StudentName = student.name,
                    StudentFaculty = clazz.Faculty
                }).OrderBy(s=>s.StudentName);
            Console.WriteLine("+++++++++++++++++++++");
            foreach (var item in listInnerJoin)
            {
                Console.WriteLine("ID : {0}, Name : {1}, Faculty : {2}",item.StudentId,item.StudentName,item.StudentFaculty);
            }

            // Group Join
            Console.WriteLine("+++++++++++++++++++++");
            var listGroupJoin = listStudent.GroupJoin(listClass,
                student => student.clazz,
                clazz => clazz.name,
                (clazz, GroupStudent) => new {
                    nameClass = clazz.name,
                    student = GroupStudent
                }
                );
            foreach (var item in listGroupJoin)
            {
                Console.WriteLine("ID : {0}, Name : {1}", item.nameClass, item.student.ToString());
            }
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
