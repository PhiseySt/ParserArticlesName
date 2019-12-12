using AngleSharp.Html.Dom;

namespace SuperParser.Core
{
    internal interface IParser<out T> where T : class
    {
        T Parse(IHtmlDocument document);
    }
}
