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

        public virtual StringBuilder Build()
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

            return stringBuilder;
        }
    }
}
