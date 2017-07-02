using System.Linq;
using System.Net.Http;

namespace TryCatch.Dialogs
{
    public class BingSearch
    {
        public string BingToSearch(string question)
        {
            // Create a query
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "e296b7488f8143d6b64b068c697f4150");
            var query = "https://api.cognitive.microsoft.com/bing/v5.0/search?" + "q=" + question;

            //发送query并返回处理结果
            HttpResponseMessage httpResponseMessage = client.GetAsync(query).Result;

            //反序列化得到的结果
            var responseContentString = httpResponseMessage.Content.ReadAsStringAsync().Result;
            Newtonsoft.Json.Linq.JObject responseObjects = Newtonsoft.Json.Linq.JObject.Parse(responseContentString);

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                string[] rankingGroups = new string[] { "pole", "mainline", "sidebar" };

                foreach (string rankingName in rankingGroups)
                {
                    Newtonsoft.Json.Linq.JToken rankingResponseItems = responseObjects.SelectToken($"rankingResponse.{rankingName}.items");
                    if (rankingResponseItems != null)
                    {
                        Newtonsoft.Json.Linq.JObject rankingResponseItem = (Newtonsoft.Json.Linq.JObject)rankingResponseItems.ElementAt(0);
                        var resultIndex = rankingResponseItem.GetValue("resultIndex");

                        Newtonsoft.Json.Linq.JToken items = responseObjects.SelectToken("webPages.value");
                        Newtonsoft.Json.Linq.JToken item = items.ElementAt((int)resultIndex);

                        string url = (string)item["url"];
                        string snippet = (string)item["snippet"];

                        return snippet;
                    }
                }
                return null;
            }
            else
            {
                return null;
            }
        }
    }
}