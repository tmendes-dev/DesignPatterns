using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class HtmlElement
    {
        public string Name { get; set; }
        public string Text { get; set; }

        public List<HtmlElement> Elements = new List<HtmlElement>();

        private const int identSize = 2;

        public HtmlElement()
        {
        }

        public HtmlElement(string name, string text)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Text = text ?? throw new ArgumentNullException(nameof(text));
        }

        private string ToStringImpl(int ident)
        {
            var sb = new StringBuilder();
            var i = new string(' ', identSize * ident);
            sb.AppendLine($"{i}<{Name}>");

            if (!string.IsNullOrWhiteSpace(Text))
            {
                sb.Append(new string(' ', identSize * (ident + 1)));
                sb.AppendLine($"<{Text}>");
            }

            foreach (var el in Elements)
            {
                sb.Append(el.ToStringImpl(ident + 1));
            }
            sb.AppendLine($"{i}</{Name}>");

            return sb.ToString();
        }

        public override string ToString()
        {
            return ToStringImpl(0);
        }
    }
}