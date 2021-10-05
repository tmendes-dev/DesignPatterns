using System;

namespace LiskovSubstitutionPrinciple
{
    partial class Program
    {
        static public int Area(Rectangle rectangle) => rectangle.Height * rectangle.Width;  
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(2,3);
            Console.WriteLine($"{rectangle} has area {Area(rectangle)}");

            Rectangle square = new Square();
            square.Height = 2;
            Console.WriteLine($"{square} has area {Area(square)}");
        }
    }
}
