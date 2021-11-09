

# Zadanie nr 4 - HTML


Utwórz klasę, która będzie generowała odpowiednią kontrolkę html, np.

 <img src="img_orange_flowers.jpg" alt="Flowers" style="width:auto;">


~~~ csharp
namespace Html {

   public abstract class Element
   {
           public string Id { get; set; }

            public abstract string Render();
   }

   public class Image : Element
   {
           public string Source { get; set; }
           public string Alternate { get; set; }  
           public string Style { get; set; }       

           public override string  Render() 
           {
               // TODO:
               // użyj String.Format lub StringBuilder
           }
           
   }

}

~~~


## Kontrolki
1. https://www.w3schools.com/tags/tag_em.asp
1. https://www.w3schools.com/tags/tag_button.asp
1. https://www.w3schools.com/html/html_links.asp
1. https://www.w3schools.com/tags/tag_label.asp
1. https://www.w3schools.com/tags/tag_input.asp
1. https://www.w3schools.com/html/html_images.asp
1. https://www.w3schools.com/html/html_headings.asp
1. https://www.w3schools.com/html/html_favicon.asp
1. https://www.w3schools.com/tags/tag_iframe.asp
1. https://www.w3schools.com/html/html_lists.asp
1. https://www.w3schools.com/html/html_tables.asp
1. https://www.w3schools.com/tags/tag_hn.asp
1. https://www.w3schools.com/tags/tag_li.asp
1. https://www.w3schools.com/tags/tag_progress.asp