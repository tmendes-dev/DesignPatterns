using System;

namespace InterfaceSegregationPrinciple
{
    partial class Program
    {
        public class OldPrinter : IPrinter
        {
            public void Print(Document document)
            {
                throw new NotImplementedException();
            }
        }
    }
}