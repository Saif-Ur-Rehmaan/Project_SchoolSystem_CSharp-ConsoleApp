using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    internal class Parent
    {
        public int Id,NoOfAddmission;
        public string name;
    

        public Parent(int id,string name)
        {
            this.Id = id;
            this.name = name;
            this.NoOfAddmission= 0;
        }
    
    }

}
