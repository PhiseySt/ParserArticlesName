using SuperParser.Core;

namespace SuperParser.Sites
{
    class ProgrammingCSharpSettings : IParserSettings
    {
        public ProgrammingCSharpSettings(int start, int end)
        {
            StartPoint = start;
            EndPoint = end;
        }

        public string BaseUrl { get; set; } = "https://programming-csharp.ru/";
        public string Postfix { get; set; } = "page{CurrentId}";
        public int StartPoint { get; set; }
        public int EndPoint { get; set; }
    }
}
