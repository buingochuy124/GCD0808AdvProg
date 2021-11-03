using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Student
    {
        public int Id;
        public string Name;
        public DateTime Dob;
        public Student()
        {
            Id = 0;
            Name = "unknow";
            Dob = new DateTime(21, 10, 27); 
        }
        public Student(int id, string name,DateTime dob)
        {
            Id = id;
            Name = name;
            Dob = dob;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Student Id:  "+Id);
            Console.WriteLine("Student Name:  " + Name);
            Console.WriteLine("Student Day of birth:  " + Dob);

        }
        public void Status(Status status)
        {
            Console.WriteLine(status);
        }
    }
    class  Status
    {
        public void Learn()
        {
            Console.WriteLine("Learning....");
        }
    }
}
