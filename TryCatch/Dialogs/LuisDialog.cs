using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

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
                await context.PostAsync("很抱歉 没能帮您找到答案");
            }
            else await context.PostAsync(solution);
            context.Wait(MessageReceived);
        }

    }
}