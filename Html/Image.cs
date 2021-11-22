using System.Text;

namespace Html
{
    public class Image : Element
    {
        public string Source { get; set; }
        public string Alternative { get; set; }

        public override string Tag => "img";

        public override string Render()
        {
            StringBuilder stringBuilder = base.Build();

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
