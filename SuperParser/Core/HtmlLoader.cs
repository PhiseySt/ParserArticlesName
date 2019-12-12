using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace SuperParser.Core
{
    internal class HtmlLoader
    {
        readonly HttpClient _client;
        readonly string _url;

        public HtmlLoader(IParserSettings settings)
        {
            _client = new HttpClient();
            _url = $"{settings.BaseUrl}/{settings.Postfix}/";
        }

        public async Task<string> GetSourceByPage(int id)
        {
            var currentUrl = _url.Replace("{CurrentId}", id.ToString());
            HttpResponseMessage responce = await _client.GetAsync(currentUrl);
            var source = "";

            if (responce!=null && responce.StatusCode == HttpStatusCode.OK)
            {
                source = await responce.Content.ReadAsStringAsync();
            }
            return source;
        }
    }
}
