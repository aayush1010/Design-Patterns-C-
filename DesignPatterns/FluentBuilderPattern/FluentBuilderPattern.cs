using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FluentBuilderPattern
{
    class HtmlElement
    {
        public string Name, Text;
        public List<HtmlElement> Elements = new List<HtmlElement>();

        public HtmlElement()
        {
        }

        public HtmlElement(string name, string text)
        {
            this.Name = name;
            this.Text = text;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append($"<{Name}>");
            if (!string.IsNullOrEmpty(Text))
            {
                stringBuilder.Append($"{Text}");
            }
            foreach (var element in Elements)
            {
                stringBuilder.Append(element.ToString());
            }
            stringBuilder.Append($"</{Name}>");
            return stringBuilder.ToString();
        }

    }

    class HtmlBuilder
    {
        HtmlElement root = new HtmlElement();

        private string rootName;

        public HtmlBuilder(string rootName)
        {
            this.rootName = rootName;
            root.Name = rootName;
        }

        public HtmlBuilder AddChild(string childName, string childText)
        {
            var element = new HtmlElement(childName, childText);
            root.Elements.Add(element);
            return this;
        }

        public override string ToString()
        {
            return root.ToString();
        }
    }
}
