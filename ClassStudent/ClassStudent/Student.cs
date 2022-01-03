using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkStudent
{
    class Student
    {
        //Fields

        private int age;
        private string name;

        public const int MIN_AGE = 18;
        public const int MAX_AGE = 99;

        private List<StudentOperation> allStudents = new List<StudentOperation>();



        //Properties
        public decimal? Mark { get; set; }

        public int Age
        {
            get { return age; }
            set
            {
                age = (value >= MIN_AGE && value <= MAX_AGE) ? value : 0;

            }
        }

        public string Info
        {
            get
            {
                if (Age != 0)
                {
                    var combinedNameAge = new StringBuilder();
                    combinedNameAge.Append($"Age and name combined looks like this: {Age}{name}\n");
                    return combinedNameAge.ToString();
                }
                return "";
            }
        }

        //constructor
        public Student(int age, string name, decimal? mark = null)
        {
            Mark = mark;
            this.name = name;
            Age = age;
            if (Age != 0)
            {
                AddStudent(Age, this.name, Mark);

            }
            else
            {
                Console.WriteLine($"Age for {this.name} is not appropriate. Must be at least {MIN_AGE}");
              
            }
        }

        //Methods

        public void AddStudent(int age, string name, decimal? mark = null)
        {
            if (age >= MIN_AGE)
            {
                var application = new StudentOperation(age, name, mark);
                allStudents.Add(application);
            }
            else Console.WriteLine($"{name} does not have 18 yet!\n"); 
        }


        public string GetAllStudents()
        {
            var report = new StringBuilder();
            report.AppendLine("Age\t\tName\t\tMark\n");
            foreach (var item in allStudents)
            {
                report.AppendLine($"{item.Age}\t\t{item.Name}\t\t{item.Mark}");
            }
            return report.ToString();
        }

        public int GetNoOfMarks()
        {
            int counter = 0;
            foreach (var item in allStudents)
            {
                if (item.Mark.HasValue)
                {
                    counter++;
                }
            }
            return counter;
        }
        public void GetAverage( )
        {
            decimal averageResult = 0;

            foreach (var item in allStudents)
            {
                if (item.Mark.HasValue)
                {
                    averageResult += (decimal)item.Mark;
                }
            }
            Console.WriteLine($"Average is {averageResult / GetNoOfMarks()}");
        }

     

    }

}


