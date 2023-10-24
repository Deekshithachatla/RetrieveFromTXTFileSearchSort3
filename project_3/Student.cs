using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3
{
    internal class Student
    {

            public string Name { get; }
            public string Class { get; }

            public Student(string name, string className)
            {
                Name = name;
                Class = className;
            }
        }
    }

