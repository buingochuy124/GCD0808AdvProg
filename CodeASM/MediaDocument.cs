using System;

namespace CodeASM
{
    public class MediaDocument : Document       
    {
        public double Expense;

        public MediaDocument()
        {
            Description = "Media Document";
        }
        public MediaDocument(string id, string name, string description, string content,double expense) 
            : base(id,name,description,content)
        {
            Expense = expense;
            Description = "Media Document";
        }

        public override string GetDocumentContent()
        {
            return Content;
        }

        public override string GetDocumentDescription()
        {
            return Description;
        }

        public override string GetDocumentId()
        {
            return Id;
        }

        public override string GetDocumentName()
        {
            return Name;
        }

        public double GetDocumentExpense()
        {
            return Expense;
        }

        public override void PrintDocumentInfo()
        {
            Console.WriteLine($"This is {Description} !!!!");
            Console.WriteLine($"Document Name : " + Name);
            Console.WriteLine($"Spend {Expense} $");
            Console.WriteLine($"     {Content}");

        }
       

    }
}
    