using System;

namespace Html
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Element element = new Paragraph() { Content = "This is some text in a paragraph.", Style = "text-align:right" };

            string result = element.Render();

            string expected = "<p style=\"text-align:right\">This is some text in a paragraph.</p>";

            if (result == expected)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Błąd");
            }

            Console.WriteLine(result);

            Element image = new Image() { Source = "pic_trulli.jpg", Alternative = "Italian Trulli" };

            string result2 = image.Render();
            string expected2 = "<img src=\"pic_trulli.jpg\" alt=\"Italian Trulli\">";

            if (result2 == expected2)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Błąd");

                Console.WriteLine(result2);
                Console.WriteLine(expected2);
            }



        }
    }
}
