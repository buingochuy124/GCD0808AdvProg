using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeASM
{
    public abstract partial class Document
    {
        protected string Id;
        protected string Name;
        protected string Description;
        protected string Content;


        public Document()
        {
            Id = "N/A";
            Name = "N/A";
            Description = "Normal Document";
            Content = "N/A";
        }
        public Document(string name)
        {
            Id = "N/A";
            Name = name;
            Description = "Normal Document";
            Content = "N/A";
        }
        public Document(string id, string name, string description, string content)
        {
            Id = id;
            Name = name;
            Description = description;
            Content = content;
        }

        public abstract string GetDocumentId();

        public abstract string GetDocumentName();

        public abstract string GetDocumentDescription();

        public abstract string GetDocumentContent();

        public abstract void PrintDocumentInfo();
        
    }

}
    