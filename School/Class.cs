using System;
using System.Collections.Generic;

namespace School
{
    class Class
    {
        List<Student> Students;
        public Class()
        {
            Students = new List<Student>();
        }
        public void AddStudentToClass(Student student)
        {
            Students.Add(student);
        }
        public void PrintStudentInClass()
        {
            foreach (var item in Students)
            {
                Console.WriteLine("Student id:  "+item.Id);
                Console.WriteLine("Student Name:  "+item.Name);
                Console.WriteLine("Student Day of birth:  "+item.Dob);
                Console.WriteLine("=========================");
            }
        }
    }
}
