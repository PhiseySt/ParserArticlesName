namespace SuperParser.Core
{
    internal interface IParserSettings
    {
        string BaseUrl { get; set; }
        string Postfix { get; set; }
        int StartPoint { get; set; }
        int EndPoint { get; set; }
    }
}
