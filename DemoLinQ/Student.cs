using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLinQ
{
    class Student
    {
        public Student(int id, string name, int age,string clazz)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.clazz = clazz;
        }
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string clazz { get; set; }
        public override string ToString()
        {
            return "ID : " + this.id + " - Name : " + this.name + " - Age : " + this.age;
        }
    }
}
