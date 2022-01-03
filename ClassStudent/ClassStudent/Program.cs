using System;
using System.Collections;
using System.Linq;

namespace HomeWorkStudent
{
    class Program
    {
        static void Main(string[] args)
        {
        
            
            Student student = new Student(18,"Cosmin",9);//first student
           



            Console.WriteLine(student.Info);//If input is of age prints out age and name toghether

       

            //adding students to list Age/Name/Optional Mark
            student.AddStudent(17, "Alex",9);
            student.AddStudent(23, "Melinda",10);
            student.AddStudent(19, "Razvan", 7);
            student.AddStudent(20, "Corina");

          
            //prints all students
            Console.WriteLine(student.GetAllStudents());

            

          
       
        }

    
      

     

       














    }
}
