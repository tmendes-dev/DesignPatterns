namespace InterfaceSegregationPrinciple
{
    partial class Program
    {
        public interface IMultiFunctionDevice : IPrinter, IScanner, IFax
        {

        }
    }
}