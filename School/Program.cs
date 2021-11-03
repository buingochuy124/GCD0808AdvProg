using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Student huy = new Student(100, "huy", new DateTime(2000, 12, 24));
            
            Student binh = new Student(100, "binh", new DateTime(2001, 1, 1));
            Class gcd0808 = new Class();
            gcd0808.AddStudentToClass(huy);
            gcd0808.AddStudentToClass(binh);
            gcd0808.PrintStudentInClass();
            Console.ReadLine();



            

        }
        
    }
    public SmartStudent()
    {

    }
}
