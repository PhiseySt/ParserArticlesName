using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using System;

namespace SuperParser.Core
{
    internal class ParserWorker<T> where T : class
    {
        private IParserSettings _parserSettings;
        private HtmlLoader _loader;

        public IParser<T> Parser { get; set; }

        public IParserSettings Settings
        {
            get { return _parserSettings; }
            set
            {
                    _parserSettings = value;
                    _loader = new HtmlLoader(value);
            }
        }

        public bool IsActive { get; private set; }

        public event Action<object, T> OnNewData;
        public event Action<object> OnComplited;

        public ParserWorker(IParser<T> parser)
        {
            Parser = parser;
        }

        public void Start()
        {
            IsActive = true;
            Worker();
        }

        public void Stop() => IsActive = false;

        public async void Worker()
        {
            for (var i = _parserSettings.StartPoint; i <= _parserSettings.EndPoint; i++)
            {
                if (IsActive)
                {
                    string source = await _loader.GetSourceByPage(i);
                    HtmlParser domParser = new HtmlParser();
                    IHtmlDocument document = await domParser.ParseDocumentAsync(source);
                    T result = Parser.Parse(document);
                    OnNewData?.Invoke(this, result);
                }
            }

            OnComplited?.Invoke(this);
            IsActive = false;
        }
    }
}
