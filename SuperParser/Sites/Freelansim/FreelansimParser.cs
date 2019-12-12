using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;

namespace SuperParser.Core.Freelansim
{
    class FreelansimParser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {
            List<string> list = new List<string>();
            IEnumerable<IElement> items = document.QuerySelectorAll("div")
                .Where(item => item.ClassName != null && item.ClassName.Contains("task__title"));

            foreach (var item in items)
            {
                list.Add(item.TextContent);
            }

            return list.ToArray();
        }
    }
}
