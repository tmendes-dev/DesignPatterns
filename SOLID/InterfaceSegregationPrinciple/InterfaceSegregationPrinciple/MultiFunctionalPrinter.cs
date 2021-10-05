using System;

namespace InterfaceSegregationPrinciple
{
    partial class Program
    {
        public class MultiFunctionalPrinter : IMultiFunctionDevice
        {
            private IPrinter Printer;
            private IScanner Scanner;

            public MultiFunctionalPrinter(IPrinter printer, IScanner scanner)
            {
                Printer = printer ?? throw new ArgumentNullException(nameof(printer));
                Scanner = scanner ?? throw new ArgumentNullException(nameof(scanner));
            }

            

            public void Print(Document doc)
            {
                Printer.Print(doc);
            }

            public void Scan(Document doc)
            {
                Scanner.Scan(doc);
            }

            public void Fax(Document document)
            {
                throw new NotImplementedException();
            }
        }
    }
}