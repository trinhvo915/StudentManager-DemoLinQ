using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLinQ
{
    public class Clazz
    {
        public Clazz(string name,string Faculty)
        {
            this.name = name;
            this.Faculty = Faculty;
        }
        public string name { get; set; }
        public string Faculty { get; set; }
    }
}
