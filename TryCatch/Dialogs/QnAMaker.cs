using System.Net.Http.Headers;
using System.Text;
using System.Net.Http;
using System.Web;
using System.Threading.Tasks;

namespace TryCatch.Dialogs
{
    public class QnAMaker
    {
        public static async Task<string> MakeRequest(string query)
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "c98c8b2c8a52412e94ced75898ad3155");

            var uri = "https://westus.api.cognitive.microsoft.com/qnamaker/v2.0/knowledgebases/411efa2e-1ad3-485b-b234-e395601e3985/generateAnswer?" + queryString;

            HttpResponseMessage response;

            var postBody = $"{{\"question\": \"{query}\"}}";

            byte[] byteData = Encoding.UTF8.GetBytes(postBody);

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                response = await client.PostAsync(uri, content);

                string solution = await response.Content.ReadAsStringAsync();

                int first = solution.LastIndexOf("answer");
                int last = solution.LastIndexOf("questions");

                string result = solution.Substring(first + 9, last - first - 12);

                if (result.Equals("No good match found in the KB"))
                {
                    return null;
                }
                else return result;
            }
        }
    }
}