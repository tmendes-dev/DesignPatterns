using System;
using System.Text;

namespace Builder
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var hello = "Hello";
            var sb = new StringBuilder();
            sb.Append("<p>");
            sb.Append(hello);
            sb.Append("</p>");
            Console.WriteLine(sb);
            Console.WriteLine("\n");

            var words = new[] { "Hello", "world!" };
            sb.Clear();
            sb.Append("<ul>");
            foreach (var w in words)
            {
                sb.AppendFormat("<li>{0}</li>", w);
            }
            sb.Append("</ul>");
            Console.WriteLine(sb);
            Console.WriteLine("\n");

            //BUILER
            var builder = new HtmlBuilder("ul");
            foreach (var word in words)
            {
                builder.AddChild("li", word);
            }
            Console.WriteLine(builder);
        }
    }
}