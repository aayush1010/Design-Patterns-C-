using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FluentBuilderPattern
{
    /// <summary>
    /// Class to create Html Element like <html>, <head>
    /// </summary>
    class HtmlElement
    {
        /// <summary>
        /// The name of html element
        /// </summary>
        public string Name;

        /// <summary>
        /// The text of html element
        /// </summary>
        public string Text;

        /// <summary>
        /// The elements contained by root element
        /// </summary>
        public List<HtmlElement> Elements = new List<HtmlElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlElement"/> class.
        /// Constructor used to create the root element
        /// </summary>
        public HtmlElement()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlElement"/> class.
        /// Constructor to create the child elements of the root elements
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="text">The text.</param>
        public HtmlElement(string name, string text)
        {
            this.Name = name;
            this.Text = text;
        }

        /// <summary>
        /// Print the Html formed
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
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

    /// <summary>
    /// Html Builder class
    /// </summary>
    class HtmlBuilder
    {
        /// <summary>
        /// The root element
        /// </summary>
        HtmlElement root = new HtmlElement();

        /// <summary>
        /// The root element name
        /// </summary>
        private string rootName;

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlBuilder"/> class.
        /// Used to create root element of the html builder
        /// </summary>
        /// <param name="rootName">Name of the root.</param>
        public HtmlBuilder(string rootName)
        {
            this.rootName = rootName;
            root.Name = rootName;
        }

        /// <summary>
        /// Adds the child element to root.
        /// </summary>
        /// <param name="childName">Name of the child.</param>
        /// <param name="childText">The child text.</param>
        /// <returns>the html builder itself</returns>
        public HtmlBuilder AddChild(string childName, string childText)
        {
            var element = new HtmlElement(childName, childText);
            root.Elements.Add(element);
            return this;
        }

        /// <summary>
        /// Print the string formed by html builder
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return root.ToString();
        }
    }
}
