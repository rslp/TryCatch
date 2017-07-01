using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Net.Http;

namespace TryCatch.Dialogs
{
    [LuisModel("76dee75f-47ed-4146-ba91-939fffc81f3b", "32bf79dffecb400cb5d3c4337f6766e0")]
    [Serializable]
    public class LuisDialog : LuisDialog<object>
    {
        /*
        [LuisIntent("打招呼")]
        public async Task Greeting(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("你好啊，老铁");
            context.Wait(MessageReceived);
        }*/
        /*
        [LuisIntent("询问名字")]
        public async Task Name(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("你就叫我特浪扑吧。");
            context.Wait(MessageReceived);
        }
        [LuisIntent("讲笑话")]
        public async Task Amuse(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("你的存在其实就是一个笑话。");
            context.Wait(MessageReceived);
        }
        [LuisIntent("查询学校")]
        public async Task FindSchool(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("北邮是个好地方。");
            context.Wait(MessageReceived);
        }
        [LuisIntent("")]
        public async Task None(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("老铁，发烧就该吃药，不能胡言乱语啊。");
            context.Wait(MessageReceived);
        }
        */
        [LuisIntent("None")]
        public async Task None(IDialogContext context, LuisResult result)
        {
            string question = result.Query;
            string solution = await QnAMaker.MakeRequest(question);

            if (solution == null)
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

                // Handle success and error codes
                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    string[] rankingGroups = new string[] { "pole", "mainline", "sidebar" };
                    bool getAnswer = false;
                    foreach (string rankingName in rankingGroups)
                    {
                        Newtonsoft.Json.Linq.JToken rankingResponseItems = responseObjects.SelectToken($"rankingResponse.{rankingName}.items");
                        if (rankingResponseItems != null)
                        {
                            Newtonsoft.Json.Linq.JObject rankingResponseItem = (Newtonsoft.Json.Linq.JObject)rankingResponseItems.ElementAt(0);
                            var resultIndex = rankingResponseItem.GetValue("resultIndex");
                            //var answerType = rankingResponseItem.Value<string>("answerType");

                            Newtonsoft.Json.Linq.JToken items = responseObjects.SelectToken("webPages.value");
                            Newtonsoft.Json.Linq.JToken item = items.ElementAt((int)resultIndex);

                            string url = (string)item["url"];
                            string snippet = (string)item["snippet"];
                            getAnswer = true;

                            //await context.PostAsync(url);
                            await context.PostAsync(snippet);

                            break;
                        }
                    }
                    if(getAnswer == false)
                    {
                        await context.PostAsync("很抱歉 没能帮您找到答案");
                    }
                           
                }
                else
                {
                    Console.WriteLine($"HTTP error status code: {httpResponseMessage.StatusCode.ToString()}");
                    await context.PostAsync("很抱歉 没能帮您找到答案");
                }

                
            }
            else await context.PostAsync(solution);
            context.Wait(MessageReceived);
        }

    }
}