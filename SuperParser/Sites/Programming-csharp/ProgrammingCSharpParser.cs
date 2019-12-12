using System.Collections.Generic;
using System.Linq;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using SuperParser.Core;

namespace SuperParser.Sites
{
    class ProgrammingCsParser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {
            List<string> list = new List<string>();
            IEnumerable<IElement> items = document.QuerySelectorAll("a")
                .Where(item => item.ClassName == null && item.Attributes.GetNamedItem("rel") != null && item.Attributes.GetNamedItem("rel").Value == "bookmark");

            foreach (var item in items)
            {
                list.Add(item.TextContent);
            }

            return list.ToArray();
        }
    }
}
