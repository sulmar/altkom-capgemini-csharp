using System.Text;

namespace Html
{
    public abstract class ContentElement : Element
    {
        public string Content { get; set; }

        public override StringBuilder Build()
        {            
            StringBuilder stringBuilder = base.Build();

            stringBuilder.Append(Content);

            return stringBuilder;
        }
    }
}
