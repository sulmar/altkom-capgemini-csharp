using System.Text;

namespace Html
{
    public class Header : ContentElement
    {
        public override string Tag => $"h{Level}";

        public byte Level { get; set; }

        public override string Render()
        {
            StringBuilder stringBuilder = base.Build();

            // EndTag

            stringBuilder.Append($"</{Tag}>");

            string html = stringBuilder.ToString();

            return html;


        }
    }
}
