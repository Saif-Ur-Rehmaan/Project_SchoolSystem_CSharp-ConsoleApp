using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    internal class Student
    {
       public int id, age, semester, parentid;
        public string subject, name, @class;

        public Student(int id,string name, int age, string @class, string subject, int semester, int parentid)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.semester = semester;
            this.@class = @class;
            this.subject = subject;
            this.parentid = parentid;

        }   
    }
}
