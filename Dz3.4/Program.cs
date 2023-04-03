using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz3._4
{
    class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Документ відкритий");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Редагування документа у версії Про");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Збереження документа у версії Про");
        }
    }

    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ відредаговано");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ збережено у старому форматі, збереження в інших форматах є у версії Експерт");
        }
    }

    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ збережений у новому форматі");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Введіть ключ доступу (pro або exp): ");
            string key = Console.ReadLine();

            DocumentWorker document;

            switch (key)
            {
                case "pro":
                    document = new ProDocumentWorker();
                    break;
                case "exp":
                    document = new ExpertDocumentWorker();
                    break;
                default:
                    document = new DocumentWorker();
                    break;
            }

            document.OpenDocument();
            document.EditDocument();
            document.SaveDocument();

            Console.ReadKey();
        }
    }
}
