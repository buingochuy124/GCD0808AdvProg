using System;
using System.Collections.Generic;

namespace CodeASM
{
    class PersonDocument : Document
    {

        List<Person> Persons;


        public PersonDocument()
            : base()
        {
            Content = "This is the document of all persons in company";
            Persons = new List<Person>();
            Description = "Persons Document";

        }

        public void AddPersonToDocment(Person person)
        {
            Persons.Add(person);
        }

        public void PrintPersonList()
        {
            foreach (var item in Persons)
            {
                Console.WriteLine(item.GetPersionalInfo(item));
            }

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

        public override void PrintDocumentInfo()
        {
            Console.WriteLine($"This is {Description} !!!!");
            Console.WriteLine($"Document Name : " + Name);
            Console.WriteLine($"     {Content}");
            PrintPersonList();
        }
    }
}
