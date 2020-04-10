using System;

namespace Homework9_DocumentWorker
{

    class DocumentWorker
    {
        static void OpenDocument()
        {
            System.Console.WriteLine("Document is open");
        }
        static void EditDocument()
        {
            System.Console.WriteLine("Document editing is available in pro version");
        }
        static void SaveDocument()
        {
            System.Console.WriteLine("Saving the document is available in pro version");
        }

    }
    class ProDocumentWorker : DocumentWorker
    {

    }




    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
