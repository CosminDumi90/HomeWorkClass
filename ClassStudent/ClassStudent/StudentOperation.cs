using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkStudent
{
    public class StudentOperation
    {
        public int Age { get; }
  

        public string Name { get; set; }

        public decimal? Mark { get; set; }

        public StudentOperation(int age, string name,decimal? mark)
        {
            this.Age = age;
            this.Name = name;
            this.Mark = mark;
        }
   
    }
}
