using System;

namespace Homework9_DocumentWorker
{

    public class DocumentWorker // Main class
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
    public class ProDocumentWorker : DocumentWorker // inheritance class from MainClass
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
    public class ExpertDocumentWorker : ProDocumentWorker // from ProDocWork
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
            int proKey = 13579;
            int expKey = 24680;
            System.Console.WriteLine("Enter Pro's key password:");
            int pro = int.Parse(Console.ReadLine());
            if (pro != proKey)
            {
                DocumentWorker us1 = new DocumentWorker();
                System.Console.WriteLine("Simple document:");
                us1.OpenDocument();
                us1.EditDocument();
                us1.SaveDocument();
            }
            else
            {
                System.Console.WriteLine("Enter please Expert's key password:");
                int exp = int.Parse(Console.ReadLine());

                if (exp != expKey)
                {
                    ExpertDocumentWorker us1 = new ExpertDocumentWorker();
                    System.Console.WriteLine("Data:");
                    us1.OpenDocument();
                    us1.EditDocument();
                    us1.SaveDocument();
                }
                else
                {
                    ProDocumentWorker us1 = new ProDocumentWorker();
                    System.Console.WriteLine("Data:");
                    us1.OpenDocument();
                    us1.EditDocument();
                    us1.SaveDocument();
                }
            }


        }
    }
}
