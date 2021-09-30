using System;
using System.Diagnostics;

namespace SingleResponsabilityPrinciple
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var journal = new Journal();

            journal.AddEntry("Today i studied hard");
            journal.AddEntry("Tomorrow i'll do the same");

            Console.WriteLine(journal);

            var persistance = new Persistance();
            var fileName = @"c:\temp\journal.txt";

            persistance.SaveToFile(journal, fileName, true);
            Process.Start(fileName);
        }
    }
}