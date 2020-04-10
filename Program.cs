using System;

namespace Homework9_DocumentWorker
{

    public class DocumentWorker
    {
        public DocumentWorker() { }
        public void OpenDocument()
        {
            System.Console.WriteLine("Document is open");
        }
        public virtual void EditDocument()
        {
            System.Console.WriteLine("Document editing is available in Pro version");
        }
        public virtual void SaveDocument()
        {
            System.Console.WriteLine("Saving the document is available in Pro version");
        }

    }
    public class ProDocumentWorker : DocumentWorker
    {
        public ProDocumentWorker() { }
        public override void EditDocument()
        {
            System.Console.WriteLine("The document edited");
            base.EditDocument();
        }
        public override void SaveDocument()
        {
            System.Console.WriteLine("The document is saved in the old format.Saving other formats is available in Pro version");
            base.SaveDocument();
        }


    }
    public class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            System.Console.WriteLine("The document is saved in a new format");
            base.SaveDocument();
        }
    }




    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
