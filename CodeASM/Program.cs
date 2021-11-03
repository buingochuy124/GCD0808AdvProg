using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeASM
{
    class Program
    {
        static void Main(string[] args)
        {
            MediaDocument mediadocument = new MediaDocument();
            PersonDocument personDocument = new PersonDocument();

            mediadocument.PrintDocumentInfo();
            Console.WriteLine("---------------------");
            personDocument.PrintDocumentInfo();




            //mediadocument.PrintDocumentInfo();
            //Person huy = new Person("huy");
            //Person thong = new Person("thong");
            //Person binh = new Person("binh");





            //Console.WriteLine("========");
            //PersonDocument personDocument = new PersonDocument();
            //personDocument.AddPersonToDocment(huy);
            //personDocument.AddPersonToDocment(binh);
            //personDocument.AddPersonToDocment(thong);
            //personDocument.PrintDocumentInfo();
            Console.ReadLine(); 
        }
    }
}
