using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;

namespace SuperParser.Core.Habr
{
    class HabrParser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {
            //Для хранения заголовков
            List<string> list = new List<string>();
            //Здесь мы получаем заголовки
            IEnumerable<IElement> items = document.QuerySelectorAll("a")
                .Where(item => item.ClassName!= null && item.ClassName.Contains("post__title_link"));

            foreach (var item in items)
            {
                //Добавляем заголовки в коллекцию.
                list.Add(item.TextContent);
            }

            return list.ToArray();
        }
    }
}
