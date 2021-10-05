namespace LiskovSubstitutionPrinciple
{
    partial class Program
    {
        public class Square : Rectangle
        {
            public override int Width { set => base.Width = base.Height = value; }
            public override int Height { set => base.Height = base.Width = value; }
        }
    }
}