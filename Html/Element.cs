using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Html
{
    public abstract class Element
    {
        public string Id { get; set; }

        public string Style { get; set; }
        public abstract string Tag { get; }

        public abstract string Render();    // Metoda abstrakcyjna

        //public virtual string Render()
        //{
        //    return string.Empty;
        //}
    }

    public class Paragraph : Element
    {
        public string Content { get; set; }

        public override string Tag
        {
            get
            {
                return "p";
            }
        }

        public override string Render()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("<");
            stringBuilder.Append(Tag);

            if (!string.IsNullOrEmpty(Id))
            {
                stringBuilder.Append($" Id=\"{Id}\"");
            }

            if (!string.IsNullOrEmpty(Style))
            {
                stringBuilder.Append($" style=\"{Style}\">");                
            }

            // Paragraph
            stringBuilder.Append(Content);

            // EndTag

            stringBuilder.Append($"</{Tag}>");

            string html = stringBuilder.ToString();

            return html;
        }
    }


    public class Image : Element
    {
        public string Source { get; set; }
        public string Alternative { get; set; }

        public override string Tag => "img";

        public override string Render()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("<");
            stringBuilder.Append(Tag);

            if (!string.IsNullOrEmpty(Id))
            {
                stringBuilder.Append($" Id=\"{Id}\"");
            }

            if (!string.IsNullOrEmpty(Style))
            {
                stringBuilder.Append($" style=\"{Style}\">");
            }


            // Image
            if (!string.IsNullOrEmpty(Source))
            {
                stringBuilder.Append($" src=\"{Source}\"");
            }

            if (!string.IsNullOrEmpty(Alternative))
            {
                stringBuilder.Append($" alt=\"{Alternative}\"");
            }

            // EndTag

            stringBuilder.Append($">");


            return stringBuilder.ToString();
        }
    }
}
