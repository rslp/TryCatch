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
        
        [LuisIntent("查价值和意义类")]
        public async Task Find_Value(IDialogContext context, LuisResult result)
        {
            //获取entity列表
            IList<EntityRecommendation> entity1 = result.Entities;

            //遍历entity列表
            foreach (EntityRecommendation example in entity1)
            {
                //获取entity
                string entity = example.Entity;
                //获取entity的name
                string type = example.Type;
                //判断entity类别
                if(type != null)
                {
                    if (type.Equals("学院"))
                    {
                        switch (entity)
                        {
                            case "继续教育学院":
                                //回复消息
                                await context.PostAsync("信息时代终身学习的推动者！");
                                break;
                            default:
                                string question = result.Query;
                                string solution = await QnAMaker.MakeRequest(question);

                                if (solution == null)
                                {
                                    await context.PostAsync("很抱歉 没能帮您找到答案");
                                }
                                else await context.PostAsync(solution);
                                break;
                        }
                    }
                    else
                    {
                        string question = result.Query;
                        string solution = await QnAMaker.MakeRequest(question);

                        if (solution == null)
                        {
                            await context.PostAsync("很抱歉 没能帮您找到答案");
                        }
                        else await context.PostAsync(solution);
                        break;
                    }
                }              
            }
            context.Wait(MessageReceived);
        }

        [LuisIntent("查功能")]
        public async Task Find_Function(IDialogContext context, LuisResult result)
        {
            //获取entity列表
            IList<EntityRecommendation> entity1 = result.Entities;

            //遍历entity列表
            foreach (EntityRecommendation example in entity1)
            {
                //获取entity
                string entity = example.Entity;
                //获取entity的name
                string type = example.Type;
                //判断entity类别
                if (type != null)
                {
                    if (type.Equals("学院"))
                    {
                        switch (entity)
                        {
                            case "创新创业学院":
                                //回复消息
                                await context.PostAsync("（1）人才培养（2）产业引导（3）助创空间");
                                break;
                            case "感知技术研究院学院":
                                //回复消息
                                await context.PostAsync("技术创新，人才培养，公共服务，成果转化");
                                break;
                            case "信息光子学与光通信研究院":
                                //回复消息
                                await context.PostAsync("其主要职能是支撑信息光子学与光通信国家重点实验室的建设和发展");
                                break;
                            case "中共北京邮电大学网络技术研究院党委":
                                //回复消息
                                await context.PostAsync("根据《中国共产党党章》的有关规定，院党委对学院党建设工作负全面领导责任，党委书记为第一责任人，其他成员根据工作分工，对职责范围内的工作负直接领导责任。");
                                break;
                            case "理学院":
                                //回复消息
                                await context.PostAsync("学院办公室本着“高效服务、务实协调”的宗旨，承担日常党政、教学、科研管理、学生管理和服务的大量工作。目前下设两个综合办公室，现有工作人员6名，其中副高级以上职称3名；中级职称3名。");
                                break;
                            case "人文学院":
                                //回复消息
                                await context.PostAsync("中心承担全校9个学院，2个研究院本科及研究生公共基础实验教学工作，现为全校36个本科专业41个研究生专业开设60门实验课程。");
                                break;
                            default:
                                string question = result.Query;
                                string solution = await QnAMaker.MakeRequest(question);

                                if (solution == null)
                                {
                                    await context.PostAsync("很抱歉 没能帮您找到答案");
                                }
                                else await context.PostAsync(solution);
                                break;
                        }
                    }
                    else
                    {
                        string question = result.Query;
                        string solution = await QnAMaker.MakeRequest(question);

                        if (solution == null)
                        {
                            await context.PostAsync("很抱歉 没能帮您找到答案");
                        }
                        else await context.PostAsync(solution);
                    }
                }
            }
            context.Wait(MessageReceived);
        }
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