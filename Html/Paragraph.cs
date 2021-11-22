using System.Text;

namespace Html
{
    public class Paragraph : ContentElement
    {
        public override string Tag
        {
            get
            {
                return "p";
            }
        }

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
