using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;

namespace TryCatch.Dialogs
{
    [LuisModel("76dee75f-47ed-4146-ba91-939fffc81f3b", "32bf79dffecb400cb5d3c4337f6766e0")]
    [Serializable]
    public class LuisDialog : LuisDialog<object>
    {
        
        [LuisIntent("查数量")]
        public async Task Find_Number(IDialogContext context, LuisResult result)
        {
            //获取entity列表
            IList<EntityRecommendation> entity1 = result.Entities;

            string entity = null;

            foreach (EntityRecommendation example in entity1)
            {
                entity = entity + example.Entity;
            }

            switch (entity)
            {
                case "信息与通信工程学院实验中心实验室":
                    //回复消息
                    await context.PostAsync("7个");
                    break;
                case "信息与通信工程学院实验中心各类仪器设备":
                    //回复消息
                    await context.PostAsync("2500余件");
                    break;
                case "信息与通信工程学院泛网无线教研中心学术团队":
                    //回复消息
                    await context.PostAsync("3个");
                    break;
                case "信息与通信工程学院网络搜索教研中心学术团队":
                    //回复消息
                    await context.PostAsync("1个");
                    break;
                case "信息与通信工程学院多媒体技术教研中心学术团队":
                    //回复消息
                    await context.PostAsync("2个");
                    break;
                case "信息与通信工程学院通信网技术教研中心学术团队":
                    //回复消息
                    await context.PostAsync("4个");
                    break;
                case "信息与通信工程学院无线通信教研中心学术团队":
                    //回复消息
                    await context.PostAsync("2个");
                    break;
                case "信息与通信工程学院信息理论与技术教研中心学术团队":
                    //回复消息
                    await context.PostAsync("2个");
                    break;
                case "信息与通信工程学院教研中心":
                    //回复消息
                    await context.PostAsync("7个");
                    break;
                case "信息与通信工程学院实验中心":
                    //回复消息
                    await context.PostAsync("1个");
                    break;
                case "信息与通信工程学院学术团队":
                    //回复消息
                    await context.PostAsync("16个");
                    break;
                case "信息与通信工程学院博士生导师":
                    //回复消息
                    await context.PostAsync("80余名");
                    break;
                case "目前信息与通信工程学院博士生导师":
                    //回复消息
                    await context.PostAsync("80余名");
                    break;
                case "目前信息与通信工程学院硕士生导师":
                    //回复消息
                    await context.PostAsync("190余名");
                    break;
                case "网络空间安全老师":
                    //回复消息
                    await context.PostAsync("60余人");
                    break;
                case "电子工程学院老师":
                    //回复消息
                    await context.PostAsync("近百名");
                    break;
                case "电子工程学院本科专业":
                    //回复消息
                    await context.PostAsync("3个");
                    break;
                case "电子工程学院研究生专业":
                    //回复消息
                    await context.PostAsync("3个工学专业1个工程专业");
                    break;
                case "电子工程学院工学硕士专业":
                    //回复消息
                    await context.PostAsync("3个");
                    break;
                case "电子工程学院工程专业":
                    //回复消息
                    await context.PostAsync("1个");
                    break;
                case "电子工程学院博士专业":
                    //回复消息
                    await context.PostAsync("2个");
                    break;
                case "软件学院导师":
                    //回复消息
                    await context.PostAsync("27个");
                    break;
                case "人文学院专业":
                    //回复消息
                    await context.PostAsync("3个");
                    break;
                case "人文学院研究生导师":
                    //回复消息
                    await context.PostAsync("40多个");
                    break;                
                case "人文学院教授":
                    //回复消息
                    await context.PostAsync("60多个");
                    break;
                case "人文学院教研室":
                    //回复消息
                    await context.PostAsync("7个");
                    break;
                case "人文学院中心":
                    //回复消息
                    await context.PostAsync("5个");
                    break;
                case "人文学院系":
                    //回复消息
                    await context.PostAsync("两个系");
                    break;                
                case "理学院教学系教师":
                    //回复消息
                    await context.PostAsync("88人");
                    break;
                case "理学院物理系教师":
                    //回复消息
                    await context.PostAsync("17人");
                    break;
                case "理学院物理实验中心教师":
                    //回复消息
                    await context.PostAsync("21人");
                    break;                
                case "经济管理学院专业":
                    //回复消息
                    await context.PostAsync("9个");
                    break;
                case "经济管理学院老师":
                    //回复消息
                    await context.PostAsync("一百人左右");
                    break;
                case "经济管理学院教师":
                    //回复消息
                    await context.PostAsync("一百人左右");
                    break;
                case "中共北京邮电大学网络技术研究院党委机构":
                    //回复消息
                    await context.PostAsync("党委下设1个综合办公室，34个党支部，其中教工党支部8个，博士生党支部5个，硕士生党支部21个。");
                    break;
                case "中共北京邮电大学网络技术研究院党委综合办公室":
                    //回复消息
                    await context.PostAsync("1个");
                    break;
                case "中共北京邮电大学网络技术研究院党委党支部":
                    //回复消息
                    await context.PostAsync("34个");
                    break;
                case "中共北京邮电大学网络技术研究院党委教工党支部":
                    //回复消息
                    await context.PostAsync("8个");
                    break;
                case "中共北京邮电大学网络技术研究院党委博士生党支部":
                    //回复消息
                    await context.PostAsync("5个");
                    break;
                case "中共北京邮电大学网络技术研究院党委硕士生党支部":
                    //回复消息
                    await context.PostAsync("21个");
                    break;
                case "中共北京邮电大学网络技术研究院党委党员":
                    //回复消息
                    await context.PostAsync("现有党员569名，其中教工党员71人，学生党员498人");
                    break;
                case "中共北京邮电大学网络技术研究院党委教工党员":
                    //回复消息
                    await context.PostAsync("71个");
                    break;
                case "中共北京邮电大学网络技术研究院党委学生党员":
                    //回复消息
                    await context.PostAsync("498个");
                    break;
                case "网络技术研究院中国科学院和中国工程院两院院士":
                    //回复消息
                    await context.PostAsync("1个");
                    break;
                case "网络技术研究院长江学者":
                    //回复消息
                    await context.PostAsync("2个");
                    break;
                case "网络技术研究院国家杰出青年基金获得者":
                    //回复消息
                    await context.PostAsync("3个");
                    break;
                case "网络技术研究院长国家自然科学基金创新研究群体学术带头人":
                    //回复消息
                    await context.PostAsync("2个");
                    break;
                case "网络技术研究院973项目首席科学家":
                    //回复消息
                    await context.PostAsync("2个");
                    break;
                case "网络技术研究院百千万人才工程国家级人选":
                    //回复消息
                    await context.PostAsync("4个");
                    break;
                case "网络技术研究院跨世纪/新世纪人才计划获得者":
                    //回复消息
                    await context.PostAsync("13个");
                    break;
                case "网络技术研究院国家优秀青年科学基金获得者":
                    //回复消息
                    await context.PostAsync("1个");
                    break;
                case "网络技术研究院北京市科技新星":
                    //回复消息
                    await context.PostAsync("3个");
                    break;
                case "网络技术研究院副教授":
                    //回复消息
                    await context.PostAsync("43个");
                    break;
                case "网络技术研究院教授":
                    //回复消息
                    await context.PostAsync("19个");
                    break;
                case "网络技术研究院博士生导师":
                    //回复消息
                    await context.PostAsync("20余个（含兼职）");
                    break;
                case "网络技术研究院讲师":
                    //回复消息
                    await context.PostAsync("27个");
                    break;
                case "网络技术研究院硕士生导师":
                    //回复消息
                    await context.PostAsync("近90人（含兼职）");
                    break;
                case "网络技术研究院国家级民口项目":
                    //回复消息
                    await context.PostAsync("149项");
                    break;
                case "网络技术研究院省部级项目":
                    //回复消息
                    await context.PostAsync("80多项");
                    break;
                case "网络技术研究院国家自然科学基金委创新研究群体":
                    //回复消息
                    await context.PostAsync("2支");
                    break;
                case "网络技术研究院教育部“长江学者和创新团队发展计划”团队":
                    //回复消息
                    await context.PostAsync("2支");
                    break;
                case "网络技术研究院企业合作的横向项目":
                    //回复消息
                    await context.PostAsync("321项");
                    break;
                case "网络技术研究院横向项目中国际合作项目":
                    //回复消息
                    await context.PostAsync("73项");
                    break;
                case "网络技术研究院横向项目中欧盟项目":
                    //回复消息
                    await context.PostAsync("2项");
                    break;
                case "到目前为止网络技术研究院国家科技进步二等奖":
                    //回复消息
                    await context.PostAsync("3项");
                    break;
                case "到目前为止网络技术研究院省部级科技进步奖":
                    //回复消息
                    await context.PostAsync("19项");
                    break;
                case "到目前为止网络技术研究院ITU-T采纳为国际标准":
                    //回复消息
                    await context.PostAsync("10项");
                    break;
                case "到目前为止网络技术研究院IEEE采纳为国际标准":
                    //回复消息
                    await context.PostAsync("1项");
                    break;
                case "到目前为止网络技术研究院国内通信行业标准":
                    //回复消息
                    await context.PostAsync("24项");
                    break;
                case "到目前为止网络技术研究院国内发明专利授权":
                    //回复消息
                    await context.PostAsync("153项");
                    break;
                case "到目前为止网络技术研究院出版专著":
                    //回复消息
                    await context.PostAsync("21项");
                    break;
                case "到目前为止网络技术研究院反应量子密码协议分析成果论文":
                    //回复消息
                    await context.PostAsync("400余次");
                    break;
                case "目前交换与智能控制研究中心教师":
                    //回复消息
                    await context.PostAsync("20个");
                    break;
                case "目前交换与智能控制研究中心两院院士":
                    //回复消息
                    await context.PostAsync("0个");
                    break;
                case "目前交换与智能控制研究中心教授":
                    //回复消息
                    await context.PostAsync("5个");
                    break;
                case "目前交换与智能控制研究中心副教授高工":
                    //回复消息
                    await context.PostAsync("10个");
                    break;
                case "目前交换与智能控制研究中心讲师":
                    //回复消息
                    await context.PostAsync("0个");
                    break;
                case "目前交换与智能控制研究中心工程师":
                    //回复消息
                    await context.PostAsync("0个");
                    break;
                case "目前交换与智能控制研究中心兼职导师":
                    //回复消息
                    await context.PostAsync("0个");
                    break;
                case "目前交换与智能控制研究中心博士生导师":
                    //回复消息
                    await context.PostAsync("2个");
                    break;
                case "目前交换与智能控制研究中心硕士生导师":
                    //回复消息
                    await context.PostAsync("15个");
                    break;
                case "目前宽带网研究中心教师":
                    //回复消息
                    await context.PostAsync("14个");
                    break;
                case "目前宽带网研究中心两院院士":
                    //回复消息
                    await context.PostAsync("0个");
                    break;
                case "目前宽带网研究中心教授":
                    //回复消息
                    await context.PostAsync("4个");
                    break;
                case "目前宽带网研究中心副教授":
                    //回复消息
                    await context.PostAsync("10个");
                    break;
                case "目前宽带网研究中心讲师":
                    //回复消息
                    await context.PostAsync("1个");
                    break;
                case "目前宽带网研究中心工程师":
                    //回复消息
                    await context.PostAsync("0个");
                    break;
                case "目前宽带网研究中心兼职导师":
                    //回复消息
                    await context.PostAsync("0个");
                    break;
                case "目前宽带网研究中心博士生导师":
                    //回复消息
                    await context.PostAsync("2个");
                    break;
                case "目前宽带网研究中心硕士生导师":
                    //回复消息
                    await context.PostAsync("13个");
                    break;
                case "目前网络安全研究中心教师":
                    //回复消息
                    await context.PostAsync("7个");
                    break;
                case "目前网络安全研究中心两院院士":
                    //回复消息
                    await context.PostAsync("0个");
                    break;               
                case "目前信息网络中心教师":
                    //回复消息
                    await context.PostAsync("8个");
                    break;
                case "计算机科学与技术老师":
                    //回复消息
                    await context.PostAsync("80多个");
                    break;
                case "计算机科学与技术学生":
                    //回复消息
                    await context.PostAsync("300人");
                    break;
                case "计算机学院实验室":
                    //回复消息
                    await context.PostAsync("有8个，还有十多个企业联合实验室和产学研基地");
                    break;
                case "计算机学院教职工":
                    //回复消息
                    await context.PostAsync("学院现有教职工140余人");
                    break;
                case "计算机学院教师":
                    //回复消息
                    await context.PostAsync("140多人");
                    break;
                case "计算机学院老师":
                    //回复消息
                    await context.PostAsync("140多人");
                    break;
                case "计算机学院师资":
                    //回复消息
                    await context.PostAsync("140多人");
                    break;
                case "计算机学院教职":
                    //回复消息
                    await context.PostAsync("学院现有教职工140余人");
                    break;
                case "计算机学院系":
                    //回复消息
                    await context.PostAsync("3个");
                    break;
                case "计算机学院专业":
                    //回复消息
                    await context.PostAsync("3个");
                    break;
                case "电子工程学院国家、省部级以上科研项目":
                    //回复消息
                    await context.PostAsync("数十项");
                    break;
                case "电子工程学院博士生招生专业":
                    //回复消息
                    await context.PostAsync("2个");
                    break;
                case "电子工程学院硕士生招生专业":
                    //回复消息
                    await context.PostAsync("4个");
                    break;
                case "电子工程学院本科生招生专业":
                    //回复消息
                    await context.PostAsync("3个");
                    break;
                case "公共管理学院教授":
                    //回复消息
                    await context.PostAsync("9个");
                    break;
                case "网络技术研究院一级学科":
                    //回复消息
                    await context.PostAsync("有信息与通信工程、计算机科学与技术、软件工程3个一级学科");
                    break;
                case "网络技术研究院二级学科":
                    //回复消息
                    await context.PostAsync("有信息安全（自设）、密码学2个二级学科");
                    break;
                case "网络技术研究院研究中心":
                    //回复消息
                    await context.PostAsync("交换与智能控制、网络管理、宽带网、网络智能、网络服务基础、网络安全、下一代互联网技术、信息网络等8个研究中心");
                    break;
                case "网络技术研究院国内外知名专家学者":
                    //回复消息
                    await context.PostAsync("中国科学院和中国工程院两院院士1人、长江学者2人、国家杰出青年基金获得者3人、国家自然科学基金创新研究群体学术带头人2人、973项目首席科学家2人、百千万人才工程国家级人选4人、跨世纪/新世纪人才计划获得者13人、国家优秀青年科学基金获得者1人、北京市科技新星3人。");
                    break;
                case "公共管理学院核心课程":
                    //回复消息
                    await context.PostAsync("11个");                                        
                    break;
                case "北京邮电大学民族教育学院招生少数民族省市自治区":
                    //回复消息
                    await context.PostAsync("31个少数民族、21个省市自治区");
                    break;
                case "民族教育学院少数民族省":
                    //回复消息
                    await context.PostAsync("31个少数民族、21个省市自治区");
                    break;
                case "北邮民族教育学院少数民族省市自治区":
                    //回复消息
                    await context.PostAsync("31个少数民族、21个省市自治区");
                    break;
                case "北京邮电大学民族教育学院目前高校":
                    //回复消息
                    await context.PostAsync("47所");
                    break;
                case "民目前高校":
                    //回复消息
                    await context.PostAsync("47所");
                    break;
                case "北邮民族教育学院目前高校":
                    //回复消息
                    await context.PostAsync("47所");
                    break;
                case "北京邮电大学民族教育学院民族预科生基础培训生":
                    //回复消息
                    await context.PostAsync("6111人");
                    break;
                case "民族教育学院目前民族预科生基础培训生":
                    //回复消息
                    await context.PostAsync("6111人");
                    break;
                case "自动化学院二级学科":
                    //回复消息
                    await context.PostAsync("7个");
                    break;
                case "自动化学院一级学科":
                    //回复消息
                    await context.PostAsync("2个");
                    break;
                case "自动化学院党政机关":
                    //回复消息
                    await context.PostAsync("2个");
                    break;
                case "自动化学院学术委员会":
                    //回复消息
                    await context.PostAsync("3个");
                    break;
                case "自动化学院教研中心":
                    //回复消息
                    await context.PostAsync("4个");
                    break;
                case "自动化学院中心实验室":
                    //回复消息
                    await context.PostAsync("10个");
                    break;
                case "自动化学院职员":
                    //回复消息
                    await context.PostAsync("8个");
                    break;
                case "自动化学院工程师":
                    //回复消息
                    await context.PostAsync("1个");
                    break;
                case "自动化学院高级工程师":
                    //回复消息
                    await context.PostAsync("3个");
                    break;
                case "自动化学院讲师":
                    //回复消息
                    await context.PostAsync("8个");
                    break;
                case "自动化学院副教授":
                    //回复消息
                    await context.PostAsync("21个");
                    break;
                case "自动化学院岗位教授":
                    //回复消息
                    await context.PostAsync("1个");
                    break;
                case "自动化学院教授":
                    //回复消息
                    await context.PostAsync("17个");
                    break;
                case "目前自动化学院博士生导师":
                    //回复消息
                    await context.PostAsync("9名");
                    break;
                case "目前自动化学院硕士生导师":
                    //回复消息
                    await context.PostAsync("34名");
                    break;
                case "目前自动化学院兼职教授":
                    //回复消息
                    await context.PostAsync("30余名");
                    break;
                case "自动化学院具有博士学位的教师":
                    //回复消息
                    await context.PostAsync("35名");
                    break;
                case "自动化学院博士生导师":
                    //回复消息
                    await context.PostAsync("9名");
                    break;
                case "自动化学院教授、副教授（含高工）以上职称的教师":
                    //回复消息
                    await context.PostAsync("41名");
                    break;
                case "自动化学院院士":
                    //回复消息
                    await context.PostAsync("1名");
                    break;
                case "信息与通信工程学院工会文体活动协会":
                    //回复消息
                    await context.PostAsync("10个");
                    break;
                case "信息与通信工程学院工会工会小组":
                    //回复消息
                    await context.PostAsync("10个");
                    break;
                case "信息与通信工程学院工会委员会女工委员":
                    //回复消息
                    await context.PostAsync("1名");
                    break;
                case "信息与通信工程学院工会委员会福利委员":
                    //回复消息
                    await context.PostAsync("1名");
                    break;
                case "信息与通信工程学院工会委员会文体委员":
                    //回复消息
                    await context.PostAsync("2名");
                    break;
                case "信息与通信工程学院工会委员会宣传委员":
                    //回复消息
                    await context.PostAsync("1名");
                    break;
                case "信息与通信工程学院本届工会委员会副主席":
                    //回复消息
                    await context.PostAsync("1名");
                    break;
                case "信息与通信工程学院工会委员会组织委员":
                    //回复消息
                    await context.PostAsync("1名");
                    break;
                case "信息与通信工程学院主席":
                    //回复消息
                    await context.PostAsync("1名");
                    break;
                case "信息与通信工程学院本届工会委员会委员":
                    //回复消息
                    await context.PostAsync("8名");
                    break;
                case "信息与通信工程学院工会":
                    //回复消息
                    await context.PostAsync("259名");
                    break;
                case "信息与通信工程学院工会男":
                    //回复消息
                    await context.PostAsync("154名");
                    break;                
                default:
                    string question = result.Query;
                    string solution = await NotFind.Sub_Process(question);

                    if (solution == null)
                    {
                        await context.PostAsync("很抱歉 没能帮您找到答案");
                    }
                    else await context.PostAsync(solution);
                    break;
            }
            context.Wait(MessageReceived);
        }
        
        [LuisIntent("查地理位置")]
        public async Task Find_Location(IDialogContext context, LuisResult result)
        {
            //获取entity列表
            IList<EntityRecommendation> entity1 = result.Entities;

            string entity = null;

            foreach (EntityRecommendation example in entity1)
            {
                entity = entity + example.Entity;
            }

            switch (entity)
            {
                case "北京邮电大学信息与通信工程学院":
                    //回复消息
                    await context.PostAsync("北京市海淀区西土城路十号");
                    break;
                case "人文学院语言实验教学中心":
                    //回复消息
                    await context.PostAsync("实验中心面积分设于3个校区近4000平方米");
                    break;
                case "经济管理学院教务办公室":
                    //回复消息
                    await context.PostAsync("经管楼（北门新红楼）115室");
                    break;
                case "计算机科学与技术":
                    //回复消息
                    await context.PostAsync("教学地点为北京邮电大学沙河校区、宏福校区及校本部（2-4年级）");
                    break;
                case "北京邮电大学网络技术研究院":
                    //回复消息
                    await context.PostAsync("北京市海淀区西土城路10号北京邮电大学网络技术研究院");
                    break;
                case "北京邮电大学网络技术研究院办公地点":
                    //回复消息
                    await context.PostAsync("新科研楼 624室");
                    break;
                case "国际学院":
                    //回复消息
                    await context.PostAsync("国际学院实行北邮双校区办学，大一、大二学年在北邮宏福校区，大三、大四学年在北邮西土城校区。");
                    break;
                case "北京邮电大学自动化学院":
                    //回复消息
                    await context.PostAsync("北京市海淀区西土城路十号");
                    break;
                case "北京邮电大学民族教育学院":
                    //回复消息
                    await context.PostAsync("北京昌平区北七家镇郑各庄北邮宏福校区");
                    break;
                case "北京邮电大学":
                    //回复消息
                    await context.PostAsync("北京市海淀区西土城路10号");
                    break;
                case "北邮":
                    //回复消息
                    await context.PostAsync("北京市海淀区西土城路10号");
                    break;
                case "北京邮电大学宏福校区":
                    //回复消息
                    await context.PostAsync("北京市昌平区北七家镇北京邮电大学宏福校区");
                    break;
                case "北邮宏福校区":
                    //回复消息
                    await context.PostAsync("北京市昌平区北七家镇北京邮电大学宏福校区");
                    break;
                case "北京邮电大学继续教育学院":
                    //回复消息
                    await context.PostAsync("北京市海淀区西土城路10号北京邮电大学明光楼409");
                    break;                
                default:
                    string question = result.Query;
                    string solution = await NotFind.Sub_Process(question);

                    if (solution == null)
                    {
                        await context.PostAsync("很抱歉 没能帮您找到答案");
                    }
                    else await context.PostAsync(solution);
                    break;
            }
            context.Wait(MessageReceived);
        }
        
        [LuisIntent("查科研方向")]
        public async Task Find_Direction(IDialogContext context, LuisResult result)
        {
            //获取entity列表
            IList<EntityRecommendation> entity1 = result.Entities;

            string entity = null;

            foreach (EntityRecommendation example in entity1)
            {
                entity = entity + example.Entity;
            }

            switch (entity)
            {
                case "信息与通信工程学院宽带网络监控教研中心杨洁教授团队":
                    //回复消息
                    await context.PostAsync("网络数据科学与技术");
                    break;
                case "信息与通信工程学院多媒体技术教研中心门爱东教授团队":
                    //回复消息
                    await context.PostAsync("多媒体通信和数字图像处理数字内容处理技术、数字媒体创意与制作");
                    break;
                case "信息与通信工程学院多媒体技术教研中心景晓军教授团队":
                    //回复消息
                    await context.PostAsync("军事通信学、图像处理、信息安全、多媒体通信");
                    break;
                case "信息与通信工程学院通信网技术教研中心尹长川教授团队":
                    //回复消息
                    await context.PostAsync("通信网关键理论和技术");
                    break;
                case "信息与通信工程学院通信网技术教研中心纪越峰教授团队":
                    //回复消息
                    await context.PostAsync("宽带通信系统与网络技术");
                    break;
                case "信息与通信工程学院通信网技术教研中心温向明教授团队":
                    //回复消息
                    await context.PostAsync("信息通信网络理论、技术与应用");
                    break;
                case "信息与通信工程学院通信网技术教研中心纪红教授团队":
                    //回复消息
                    await context.PostAsync("宽带信息网络及无线网络");
                    break;
                case "信息与通信工程学院泛网无线教研中心陶小峰教授团队":
                    //回复消息
                    await context.PostAsync("新一代无线通信基础理论与网络技术");
                    break;
                case "信息与通信工程学院泛网无线教研中心张平教授团队":
                    //回复消息
                    await context.PostAsync("新一代无线通信基础理论与网络技术");
                    break;                
                case "信息与通信工程学院无线通信教研中心王文博教授团队":
                    //回复消息
                    await context.PostAsync("无线通信信号处理理论");
                    break;
                case "信息与通信工程学院无线通信教研中心杨鸿文教授团队":
                    //回复消息
                    await context.PostAsync("无线理论与技术");
                    break;
                case "网络技术研究院交换与智能控制研究中心":
                    //回复消息
                    await context.PostAsync("融合网络与业务支撑技术、服务计算技术、云计算与大数据技术、物联网共性支撑技术、服务及网络安全技术");
                    break;
                case "网络技术研究院网络安全研究中心":
                    //回复消息
                    await context.PostAsync("量子密码与量子信息、现代密码理论与技术 、工业控制系统安全、物联网安全、云计算安全、移动互联网安全");
                    break;
                case "网络技术研究院网络服务基础研究中心":
                    //回复消息
                    await context.PostAsync("服务的智能化生成理论和方法，服务执行平台体系结构理论和技术、服务资源虚拟化理论和技术、软件测试及服务质量的保障方法和技术");
                    break;
                case "网络技术研究院网络管理研究中心":
                    //回复消息
                    await context.PostAsync("（1）网络与业务管理基础理论与关键技术研究，开展管理模型、管理算法和管理机制等的研究。（2）网络与业务管理测试理论与关键技术研究，开展网络管理系统与接口测试理论、关键技术研究及测试系统的开发。（3）网络与业务管理标准研究，开展管理系统与接口的标准研制方法研究及标准制定工作。近年来，随着网络管理研究领域的深入和延伸，中心在末梢与无线网络管控，未来网络管理，网络与业务运营分析，专用通信网管理等多方面均开展了相应研究。");
                    break;
                case "网络技术研究院网络智能研究中心":
                    //回复消息
                    await context.PostAsync("业务网络智能化 Service Network Intelligence、智慧服务的协同网络 Cooperative Networks for Smart Service、云计算与未来网络 Cloud Computing and Future Internet、基于内容的多媒体检索  Content-based Multimedia Retrieval、大数据挖掘与支撑管理 Big Data Mining and Support Management");
                    break;
                case "网络技术研究院下一代互联网研究中心":
                    //回复消息
                    await context.PostAsync("智慧协同网络体系理论、一体化标识网络与普适服务、新型路由交换技术、移动互联网技术、互联网网络安全、绿色网络及物联网技术");
                    break;
                case "光通信系统与光子网络研究中心":
                    //回复消息
                    await context.PostAsync("(1) 宽带融合多业务接入及传感系统与网络； (2) 超大容量高效光传输理论与技术； (3) 低能耗自适应光子交换/路由机制与技术；(4) 动态智能光联网体系架构与关键技术。");
                    break;
                case "信息光子学材料与器件研究中心":
                    //回复消息
                    await context.PostAsync("(1)半导体材料系与异质兼容晶格-带隙工程； (2) 半导体光子学器件中的新型功能微结构与纳异质结构；(3)信息光子学半导体器件与微系统； (4)光纤波导器件与微结构光纤光子学。");
                    break;
                case "信息光子学基础研究中心":
                    //回复消息
                    await context.PostAsync("(1) 非线性光子学与复杂系统；(2) 低维半导体结构物理学与纳米光子学；(3) 光信息系统中的量子调控与量子光通信。");
                    break;
                case "电子工程学院":
                    //回复消息
                    await context.PostAsync("");
                    break;
                case "信息光子学与光通信研究院":
                    //回复消息
                    await context.PostAsync("光研院团队近年来主持承担了以国家自然科学基金重点项目、973计划、863计划重大项目、国际合作重大项目等为代表的一批国家级科研项目，发表学术论文和出版论著1000余篇/部，形成了“业务驱动的动态光网络技术创新及其实验平台”、“通信光电子器件中的材料、结构和工艺创新”等多项标志性科研成果。其中“WDM超长距离光传输设备”获国家科技进步二等奖，“高速窄线宽可调谐的解复用光接收集成器件及其关键制备工艺”被评为中国高校十大科技进展，以及十多项省部级科技进步奖，对推动国内相关学科的发展和产学研用的互动发挥了重要作用。");
                    break;
                case "自动化学院":
                    //回复消息
                    await context.PostAsync("空间机器人技术、机器人机构学、电子电器连接的可靠性、虚拟现实技术、邮政自动化与物流技术、测控技术与故障诊断、测控系统与光纤光缆检测技术、人机交互与产品创新设计、人机交互与用户体验研究、产品创新设计理论研究");
                    break;
                default:
                    string question = result.Query;
                    string solution = await NotFind.Sub_Process(question);

                    if (solution == null)
                    {
                        await context.PostAsync("很抱歉 没能帮您找到答案");
                    }
                    else await context.PostAsync(solution);
                    break;
            }
            context.Wait(MessageReceived);
        }
        
        [LuisIntent("查百分比")]
        public async Task Find_Percent(IDialogContext context, LuisResult result)
        {
            //获取entity列表
            IList<EntityRecommendation> entity1 = result.Entities;

            string entity = null;

            foreach (EntityRecommendation example in entity1)
            {
                entity = entity + example.Entity;
            }

            switch (entity)
            {
                case "网络技术研究院45岁以下科研人员总数":
                    //回复消息
                    await context.PostAsync("83.7%");
                    break;
                case "网络技术研究院博士学位科研人员总数":
                    //回复消息
                    await context.PostAsync("72.5%");
                    break;
                case "网络技术研究院北京邮电大学":
                    //回复消息
                    await context.PostAsync("是");
                    break;
                case "计算机科学与技术就业":
                    //回复消息
                    await context.PostAsync("99%以上");
                    break;
                case "计算机科学与技术保研":
                    //回复消息
                    await context.PostAsync("50%以上");
                    break;
                case "计算机科学与技术出国":
                    //回复消息
                    await context.PostAsync("50%");
                    break;
                case "计算机学院出国":
                    //回复消息
                    await context.PostAsync("出国率55%以上");
                    break;
                case "计算机学院读研":
                    //回复消息
                    await context.PostAsync("读研率55%以上");
                    break;
                case "计算机学院就业":
                    //回复消息
                    await context.PostAsync("计算机学院本科生近年来就业率达99%以上，2014年本科生就业率达到100%，研究生就业率100%");
                    break;
                case "电子工程学院本科生就业":
                    //回复消息
                    await context.PostAsync("98%");
                    break;
                case "电子工程学院研究生就业":
                    //回复消息
                    await context.PostAsync("100%");
                    break;
                case "电子工程学院博士":
                    //回复消息
                    await context.PostAsync("72%");
                    break;
                case "信息与通信工程学院工会":
                    //回复消息
                    await context.PostAsync("100%");
                    break;
                default:
                    string question = result.Query;
                    string solution = await NotFind.Sub_Process(question);

                    if (solution == null)
                    {
                        await context.PostAsync("很抱歉 没能帮您找到答案");
                    }
                    else await context.PostAsync(solution);
                    break;
            }
            context.Wait(MessageReceived);
        }
        
        [LuisIntent("查价值和意义类")]
        public async Task Find_Value(IDialogContext context, LuisResult result)
        {
            //获取entity列表
            IList<EntityRecommendation> entity1 = result.Entities;

            string entity = null;

            foreach (EntityRecommendation example in entity1)
            {
                entity = entity + example.Entity;
            }

            switch (entity)
            {
                case "继续教育学院":
                    //回复消息
                    await context.PostAsync("信息时代终身学习的推动者！");
                    break;
                case "北京邮电大学继续教育学院":
                    //回复消息
                    await context.PostAsync("信息时代终身学习的推动者！");
                    break;
                default:
                    string question = result.Query;
                    string solution = await NotFind.Sub_Process(question);

                    if (solution == null)
                    {
                        await context.PostAsync("很抱歉 没能帮您找到答案");
                    }
                    else await context.PostAsync(solution);
                    break;
            }
            context.Wait(MessageReceived);
        }
        
        [LuisIntent("查功能")]
        public async Task Find_Function(IDialogContext context, LuisResult result)
        {
            //获取entity列表
            IList<EntityRecommendation> entity1 = result.Entities;
            string entity = null;

            foreach (EntityRecommendation example in entity1)
            {
                entity = entity + example.Entity;
            }
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
                case "理学院院务办公室":
                    //回复消息
                    await context.PostAsync("学院办公室本着“高效服务、务实协调”的宗旨，承担日常党政、教学、科研管理、学生管理和服务的大量工作。目前下设两个综合办公室，现有工作人员6名，其中副高级以上职称3名；中级职称3名。");
                    break;
                case "人文学院语言实验教学中心":
                    //回复消息
                    await context.PostAsync("中心承担全校9个学院，2个研究院本科及研究生公共基础实验教学工作，现为全校36个本科专业41个研究生专业开设60门实验课程。");
                    break;
                default:
                    string question = result.Query;
                    string solution = await NotFind.Sub_Process(question);

                    if (solution == null)
                    {
                        await context.PostAsync("很抱歉 没能帮您找到答案");
                    }
                    else await context.PostAsync(solution);
                    break;
            }
            context.Wait(MessageReceived);
        }
        
        [LuisIntent("查定义")]
        public async Task Find_Definition(IDialogContext context, LuisResult result)
        {
            //获取entity列表
            IList<EntityRecommendation> entity1 = result.Entities;
            string entity = null;

            foreach (EntityRecommendation example in entity1)
            {
                entity = entity + example.Entity;
            }
            switch (entity)
            {
                case "人文学院语言实验教学中心":
                    //回复消息
                    await context.PostAsync("北京邮电大学语言实验教学中心是国内首个国家级语言实验教学示范中心及北京市大学英语实验教学创新基地。实验中心体系完整、队伍优秀、成果丰硕、装备先进、管理规范。办学规模：中心承担全校9个学院，2个研究院本科及研究生公共基础实验教学工作，现为全校36个本科专业41个研究生专业开设60门实验课程。实验中心面积分设于3个校区近4000平方米， 7种类型30套实验室，实验设备4200台件数，设备总价值约4762万元，是我校规模最大的基础实践教学平台。每年直接受益学生达12000余名，年实验人时数超过78万，是为社会培养适应信息化时代发展需要的复合型人才的重要基地。教学理念：以学生为中心，以信息技术为手段，加强学生的语言综合应用能力、自主学习能力、研究能力和创新能力，为社会培养适应信息化时代发展需要的复合型人才。实验教学体系：按照“语言基础”、“技能技巧”、“设计研究”三个层次开设外语实验课程，组成“一个中心、三个层次、四个面向、多个模块”的语言实验教学课程体系及量规化、多维评价的评估体系。");
                    break;
                case "理学院行政机构":
                    //回复消息
                    await context.PostAsync("院务办公室");
                    break;
                case "北京邮电大学民族教育学院“三基地”":
                    //回复消息
                    await context.PostAsync("“全国高校民族预科教育基地”、“全国少数民族高层次骨干人才硕士生基础强化培训基地”和“全国少数民族骨干教师语言与信息化培训基地”");
                    break;
                case "民族教育学院“三基地”":
                    //回复消息
                    await context.PostAsync("“全国高校民族预科教育基地”、“全国少数民族高层次骨干人才硕士生基础强化培训基地”和“全国少数民族骨干教师语言与信息化培训基地”");
                    break;
                case "北邮民族教育学院“三基地”":
                    //回复消息
                    await context.PostAsync("“全国高校民族预科教育基地”、“全国少数民族高层次骨干人才硕士生基础强化培训基地”和“全国少数民族骨干教师语言与信息化培训基地”");
                    break;
                case "北京邮电大学校徽图案":
                    //回复消息
                    await context.PostAsync("北邮校徽图案内以鸿雁象征邮，以右下方半圆形天线象征电，单纯、醒目、易懂。");
                    break;
                case "北邮校训":
                    //回复消息
                    await context.PostAsync("厚德博学 敬业乐群");
                    break;
                case "北邮校风":
                    //回复消息
                    await context.PostAsync("团结 勤奋 严谨 创新");
                    break;
                case "北邮校徽图案":
                    //回复消息
                    await context.PostAsync("北邮校徽图案内以鸿雁象征邮，以右下方半圆形天线象征电，单纯、醒目、易懂。");
                    break;
                default:
                    string question = result.Query;
                    string solution = await NotFind.Sub_Process(question);

                    if (solution == null)
                    {
                        await context.PostAsync("很抱歉 没能帮您找到答案");
                    }
                    else await context.PostAsync(solution);
                    break;
            }           
            context.Wait(MessageReceived);
        }
        
        [LuisIntent("test询问名字")]
        public async Task Find_Name(IDialogContext context, LuisResult result)
        {            
            await context.PostAsync("你好，我叫TryCatch，我是北邮信息智能查询机器人，有什么问题尽管问我好啦，我一定竭尽全力去回答！");                             
            context.Wait(MessageReceived);
        }
        
        [LuisIntent("查前身")]
        public async Task Find_Prebuild(IDialogContext context, LuisResult result)
        {
            //获取entity列表
            IList<EntityRecommendation> entity1 = result.Entities;

            string entity = null;

            foreach (EntityRecommendation example in entity1)
            {
                entity = entity + example.Entity;
            }

            switch (entity)
            {
                case "电子工程学院":
                    //回复消息
                    await context.PostAsync("物理系");
                    break;
                case "人文学院":
                    //回复消息
                    await context.PostAsync("前身为北京邮电大学语言学院和文法经济学院");
                    break;
                case "经济管理学院":
                    //回复消息
                    await context.PostAsync("北京邮电大学经济管理学院的前身是1955年建校时成立的三大系之一—工程经济系，1980年重建为管理工程系，1997年学校院系调整时组建管理与人文学院，2000年5月重组成立经济管理学院。");
                    break;
                case "经管院":
                    //回复消息
                    await context.PostAsync("北京邮电大学经济管理学院的前身是1955年建校时成立的三大系之一—工程经济系，1980年重建为管理工程系，1997年学校院系调整时组建管理与人文学院，2000年5月重组成立经济管理学院。");
                    break;
                case "计算机学院":
                    //回复消息
                    await context.PostAsync("计算机学院源于1985年9月成立的北京邮电大学计算机工程系");
                    break;
                case "信息与通信工程学院":
                    //回复消息
                    await context.PostAsync("信息与通信工程学院的前身是1955年学校建校伊始成立的有线电工程系和无线电工程系");
                    break;
                default:
                    string question = result.Query;
                    string solution = await NotFind.Sub_Process(question);

                    if (solution == null)
                    {
                        await context.PostAsync("很抱歉 没能帮您找到答案");
                    }
                    else await context.PostAsync(solution);
                    break;
            }
            context.Wait(MessageReceived);
        }
        
        [LuisIntent("查精神和理念类")]
        public async Task Find_Spirit(IDialogContext context, LuisResult result)
        {
            //获取entity列表
            IList<EntityRecommendation> entity1 = result.Entities;

            string entity = null;

            foreach (EntityRecommendation example in entity1)
            {
                entity = entity + example.Entity;
            }

            switch (entity)
            {
                case "中共北京邮电大学网络技术研究院党委":
                    //回复消息
                    await context.PostAsync("根据《中国共产党党章》的有关规定，院党委对学院党建设工作负全面领导责任，党委书记为第一责任人，其他成员根据工作分工，对职责范围内的工作负直接领导责任。");
                    break;                
                case "北邮":
                    //回复消息
                    await context.PostAsync("崇尚奉献 追求卓越");
                    break;                
                default:
                    string question = result.Query;
                    string solution = await NotFind.Sub_Process(question);

                    if (solution == null)
                    {
                        await context.PostAsync("很抱歉 没能帮您找到答案");
                    }
                    else await context.PostAsync(solution);
                    break;
            }
            context.Wait(MessageReceived);
        }
        
        [LuisIntent("查特征")]
        public async Task Find_Feature(IDialogContext context, LuisResult result)
        {
            //获取entity列表
            IList<EntityRecommendation> entity1 = result.Entities;

            string entity = null;

            foreach (EntityRecommendation example in entity1)
            {
                entity = entity + example.Entity;
            }

            switch (entity)
            {
                case "电子工程学院":
                    //回复消息
                    await context.PostAsync("无线电、通信微电子、光电子和生物电子");
                    break;
                case "公共管理学院":
                    //回复消息
                    await context.PostAsync("信息网络优势");
                    break;
                case "北京邮电大学成人高等学历教育":
                    //回复消息
                    await context.PostAsync("面向通信信息领域开展学历教育的办学特色");
                    break;
                case "北邮成人高等学历教育":
                    //回复消息
                    await context.PostAsync("面向通信信息领域开展学历教育的办学特色");
                    break;
                default:
                    string question = result.Query;
                    string solution = await NotFind.Sub_Process(question);

                    if (solution == null)
                    {
                        await context.PostAsync("很抱歉 没能帮您找到答案");
                    }
                    else await context.PostAsync(solution);
                    break;
            }
            context.Wait(MessageReceived);
        }
        
        [LuisIntent("查获奖")]
        public async Task Find_Award(IDialogContext context, LuisResult result)
        {
            //获取entity列表
            IList<EntityRecommendation> entity1 = result.Entities;

            string entity = null;

            foreach (EntityRecommendation example in entity1)
            {
                entity = entity + example.Entity;
            }

            switch (entity)
            {
                case "计算机学院":
                    //回复消息
                    await context.PostAsync("近年来获得国家级教学成果二等奖3项；北京市教学成果一等奖7项，北京市教学成果二等奖4项；获得 2008年全国百篇优秀博士学位论文奖1篇，中国计算机学会优秀博士论文奖2篇");
                    break;
                case "计算机学院学生":
                    //回复消息
                    await context.PostAsync("2014年，我院学生在包括美国大学生数学建模等竞赛中共获国际级奖励58项，国家级奖励98项，市级奖励39项，校级奖励37项。其中，在第39届ACM国际大学生程序设计竞赛亚洲区预赛的六个赛区的竞赛中，我院共获得三金、一银、八铜的优异成绩");
                    break;
                case "电子工程学院":
                    //回复消息
                    await context.PostAsync("国家科技进步奖二等奖1项、省部级科技奖4项、社会力量科技奖7项。近三年来共申请发明专利120多项，共发表高水平的科研论文近700篇。其中2010年我院有1篇论文入选“中国百篇最具影响国际论文”，2012年我院有2篇博士学位论文被评为北京市优秀博士学位论文。");
                    break;
                case "网路技术研究院科研奖项":
                    //回复消息
                    await context.PostAsync("获得国家科技进步二等奖3项及省部级科技进步奖19项，10项成果被ITU-T采纳为国际标准，1项成果被IEEE采纳为国际标准，24项成果被采纳为国内通信行业标准；获得国内发明专利授权153项；出版专著21部；发表了一批高水平论文，获得了国际同行的关注和认可，反映量子密码协议分析成果的论文被引用400余次；2008年、2009年和2010年连续3年获全国优秀博士学位论文提名；多次在国外举行的国际会议上做大会特邀报告。");
                    break;
                case "自动化学院学生":
                    //回复消息
                    await context.PostAsync("详情请参见:http://sa.bupt.edu.cn/cgzs/xshj.htm");
                    break;
                case "自动化学院教师":
                    //回复消息
                    await context.PostAsync("详情请参见:http://sa.bupt.edu.cn/cgzs/jshj.htm");
                    break;
                default:
                    string question = result.Query;
                    string solution = await NotFind.Sub_Process(question);

                    if (solution == null)
                    {
                        await context.PostAsync("很抱歉 没能帮您找到答案");
                    }
                    else await context.PostAsync(solution);
                    break;
            }
            context.Wait(MessageReceived);
        }
        
        [LuisIntent("查排名")]
        public async Task Ranking(IDialogContext context, LuisResult result)
        {
            IList<EntityRecommendation> entity1 = result.Entities;
            string entity = null;
            foreach (EntityRecommendation example in entity1)
            {
                entity = entity + example.Entity;
            }

            switch (entity)
            {
                case "计 算 机 科 学 与 技 术":
                    await context.PostAsync("北邮计算机学科位列全国第六，全球第四十！");
                    break;
                case "计 算 机 学 院":
                    await context.PostAsync("北邮计算机学科位列全国第六，全球第四十！");
                    break;

                default:
                    string question = result.Query;
                    string solution = await NotFind.Sub_Process(question);

                    if (solution == null)
                    {
                        await context.PostAsync("很抱歉 没能帮您找到答案");
                    }
                    else await context.PostAsync(solution);
                    break;

            }
            context.Wait(MessageReceived);
        }
        
        [LuisIntent("查结构布局")]
        public async Task Structure(IDialogContext context, LuisResult result)
        {
            IList<EntityRecommendation> entity1 = result.Entities;
            string entity = null;
            foreach (EntityRecommendation example in entity1)
            {
                entity = entity + example.Entity;
            }

            switch (entity)
            {
                case "北京邮电大学党委组织":
                    await context.PostAsync("党政办公室、组织部（党校）、宣传部、统战部、学生工作部（武装部）、研究生工作部、保密办公室、 保卫部、校工会、校团委、机关党委、教务党委、信息与通信工程学院党委、电子工程学院党委、计算机学院党委、自动化学院党委、软件学院党委、数字媒体与设计艺术学院党委、网络空间安全学院党委、理学院党委、经济管理学院党委、人文学院党委、马克思主义学院党委、国际学院党委、网络教育学院党委、民族教育学院党委、网络技术研究院党委、信息光子学与光通信研究院党委、后勤党委、离休党委、退休党委、资产经营公司党委、世纪学院党委、纪律检查委员会、纪委办公室");
                    break;
                case "北京邮电大学行政组织":
                    await context.PostAsync("党政办公室（含信访办公室、档案馆）、教务处（含基础实验教学中心、招生办公室）、研究生院（含研究生招生办公室、研究生管理办公室）、科学技术发展研究院（含科研计划处、科技协作与成果处、国防科研处、科研基地处、技术转移处、教育信息化处）、发展战略研究中心、国际合作与交流处（含港澳台办公室）、学术委员会办公室、人事处、教师发展中心、学生事务管理处（含学生就业指导中心）、离退休工作处、财务处、基建处（含校区建设办公室）、资产管理处（含人防办公室、招标办公室）、后勤处、保密处、保卫处、监察处、审计处、远程与继续教育处、新闻中心、宏福校区综合办公室、沙河校区管理委员会");
                    break;
                case "网络技术研究院科研人员年龄":
                    await context.PostAsync("全院科研人员平均年龄38岁，45岁以下人员占总数的83.7%，具有博士学位人数占科研人员总数的72.5%"); ;
                    break;
                default:
                    string question = result.Query;
                    string solution = await NotFind.Sub_Process(question);

                    if (solution == null)
                    {
                        await context.PostAsync("很抱歉 没能帮您找到答案");
                    }
                    else await context.PostAsync(solution);
                    break;

            }
            context.Wait(MessageReceived);
        }
        
        [LuisIntent("查招生")]
        public async Task Enroll(IDialogContext context, LuisResult result)
        {
            IList<EntityRecommendation> entity1 = result.Entities;
            string entity = null;
            foreach (EntityRecommendation example in entity1)
            {
                entity = entity + example.Entity;
            }

            switch (entity)
            {
                case "感知技术研究院":
                    await context.PostAsync("http://istb.bupt.edu.cn/channels/55.html");
                    break;
                case "电子工程学院":
                    await context.PostAsync("http://see.bupt.edu.cn/list/list.php?p=7_22_1");
                    break;
                case "公共管理学院":
                    await context.PostAsync("http://sppm.bupt.edu.cn/list/list.php?p=6_13_12017-03-20"); ;
                    break;
                default:
                    string question = result.Query;
                    string solution = await NotFind.Sub_Process(question);

                    if (solution == null)
                    {
                        await context.PostAsync("很抱歉 没能帮您找到答案");
                    }
                    else await context.PostAsync(solution);
                    break;

            }
            context.Wait(MessageReceived);
        }
        
        [LuisIntent("查时间段")]
        public async Task TimeSlot(IDialogContext context, LuisResult result)
        {
            IList<EntityRecommendation> entity1 = result.Entities;
            string entity = null;
            foreach (EntityRecommendation example in entity1)
            {
                entity = entity + example.Entity;
            }

            switch (entity)
            {
                case "信息与通信工程学院停招":
                    await context.PostAsync("1966年～1970年");
                    break;

                default:
                    string question = result.Query;
                    string solution = await NotFind.Sub_Process(question);

                    if (solution == null)
                    {
                        await context.PostAsync("很抱歉 没能帮您找到答案");
                    }
                    else await context.PostAsync(solution);
                    break;

            }
            context.Wait(MessageReceived);
        }
        
        [LuisIntent("查校友")]
        public async Task Alumni(IDialogContext context, LuisResult result)
        {
            IList<EntityRecommendation> entity1 = result.Entities;
            string entity = null;
            foreach (EntityRecommendation example in entity1)
            {
                entity = entity + example.Entity;
            }

            switch (entity)
            {
                case "信息与通信工程学院":
                    await context.PostAsync("详情请参见http://sice.bupt.edu.cn/xytd/xyfc.htm");
                    break;

                default:
                    string question = result.Query;
                    string solution = await NotFind.Sub_Process(question);

                    if (solution == null)
                    {
                        await context.PostAsync("很抱歉 没能帮您找到答案");
                    }
                    else await context.PostAsync(solution);
                    break;

            }
            context.Wait(MessageReceived);
        }
        
        [LuisIntent("查活动")]
        public async Task Activity(IDialogContext context, LuisResult result)
        {
            IList<EntityRecommendation> entity1 = result.Entities;
            string entity = null;
            foreach (EntityRecommendation example in entity1)
            {
                entity = entity + example.Entity;
            }

            switch (entity)
            {
                case "自动化学院学生":
                    await context.PostAsync("情暖伊冬晚会、篮球赛");
                    break;

                default:
                    string question = result.Query;
                    string solution = await NotFind.Sub_Process(question);

                    if (solution == null)
                    {
                        await context.PostAsync("很抱歉 没能帮您找到答案");
                    }
                    else await context.PostAsync(solution);
                    break;

            }
            context.Wait(MessageReceived);
        }
        
        [LuisIntent("查年龄")]
        public async Task Age(IDialogContext context, LuisResult result)
        {
            IList<EntityRecommendation> entity1 = result.Entities;
            string entity = null;
            foreach (EntityRecommendation example in entity1)
            {
                entity = entity + example.Entity;
            }

            switch (entity)
            {
                case "网络技术研究院全院科研人员平均":
                    await context.PostAsync("平均年龄38岁");
                    break;

                default:
                    string question = result.Query;
                    string solution = await NotFind.Sub_Process(question);

                    if (solution == null)
                    {
                        await context.PostAsync("很抱歉 没能帮您找到答案");
                    }
                    else await context.PostAsync(solution);
                    break;

            }
            context.Wait(MessageReceived);
        }
        
        [LuisIntent("查背景")]
        public async Task CheckBackground(IDialogContext context, LuisResult result)
        {    
            IList<EntityRecommendation> entityl = result.Entities;

            var message = context.MakeMessage();

            foreach (EntityRecommendation example in entityl)
            {
                string entity = example.Entity;
                string type = example.Type;

                if (type != null)
                {
                    if (type.Equals("学院"))
                    {
                        switch (entity)
                        {
                            case "网络技术研究院":
                                await context.PostAsync("2008年8月，为进一步抓住国际新科技革命为网络领域带来的难得发展机遇，加速提升学校在网络领域中的高新技术自主创新能力和持续竞争力，解决国家重大战略需求，北京邮电大学依托网络与交换技术国家重点实验室成立了网络技术研究院。网络技术研究院拥有信息与通信工程、计算机科学与技术、软件工程3个一级学科，信息安全（自设）、密码学2个二级学科，同时支撑网络与交换技术国家重点实验室及CERNET的建设与运行。");
                                break;
                            case "网络教育学院":
                                await context.PostAsync("北京邮电大学网络教育学院（原函授学院）是北京邮电大学开展成人高等学历教育的专门机构，自 1956 年开办成人高等学历教育至今已有 50 余年的历史。我校成人高等学历教育以服务学生、服务社会为宗旨，以培养技能型、应用型人才为目标，以规范办学、确保质量为理念，形成了面向通信信息领域开展学历教育的办学特色。培养计划紧扣通信信息行业的实际需要，课程内容紧跟通信信息技术的最新发展，教学模式多样，技术手段先进，支持服务完善。经过多年的发展，在通信信息领域的在职学历教育方面保持了领先的优势，形成了良好的口碑，被业内誉为邮电通信行业的黄埔军校。");
                                break;
                            case "民族教育学院":
                                await context.PostAsync("北京邮电大学民族教育学院是由教育部民族教育司于2003年11月25日批准建立的全国高校民族预科教育基地，正式成立于2004年6月4日。成为教育部指定的六所全国少数民族预科教育培养基地之一。");
                                break;
                            case "自动化学院":
                                await context.PostAsync("北京邮电大学自动化学院重点为工业与信息产业培养机械工程及自动化、测控技术、物流工程、自动化等专业的宽口径复合型高级技术人才。");
                                break;
                            case "信息与通信工程学院":
                                await context.PostAsync("北京邮电大学信息与通信工程学院以信息科技为特色，以突出的学科实力和明显的专业优势，在全国信息通信领域享有很高的声誉。重点建设的一级学科“信息与通信工程”是国家级重点学科，也是我校“211工程”和“985优势学科建设平台”重点建设的学科，在2012年学科评估中评为全国第一。学院的学科和专业源自于北京邮电大学1955年建校时创建的有线电工程系和无线电工程系，经过60余年的建设与发展，已经成为北京邮电大学学科实力最突出、专业优势最明显、师资力量最雄厚、历史渊源最深远的学院。");
                                break;
                            default:
                                string question = result.Query;
                                string solution = await NotFind.Sub_Process(question);

                                if (solution == null)
                                {
                                    await context.PostAsync("很抱歉 没能帮您找到答案");
                                }
                                else await context.PostAsync(solution);
                                break;
                        }
                    }
                    if (type.Equals("机构"))
                    {
                        await context.PostAsync("北京邮电大学体育部是在校行政、校党委领导下的行政二级单位，下属教学研究室、后勤管理办公室。体育部在主管校长领导下具体组织全校体育工作，负责制定学校体育工作计划和有关规章制度，定期向领导汇报工作。组织领导体育教学，制定教学计划，开展教学研究活动，搞好体育教学改革。制定体育科研规划，组织领导教师开展科研工作。组织体育部教师的政治学习和业务进修，不断提高全体教职工的思想素质和业务水平。协同学生处、团委、各院系组织领导学生业余体育活动、组织运动队训练和校内外竞赛工作；协助校工会开展教职工业余体育活动。按国家教育部要求，每学年对学生进行《国家学生体质健康标准》的测试工作。做好图书资料的保管，体育器材的购置，维护及运动场地的管理工作，并协同基建部门做好运动场地的规划和建设。");
                    }
                }
            }
            context.Wait(MessageReceived);
        }        
        
        [LuisIntent("查目标和愿景类")]
        public async Task TestCheckSchool(IDialogContext context, LuisResult result)
        {
            IList<EntityRecommendation> entityl = result.Entities;

            foreach (EntityRecommendation example in entityl)
            {
                string entity = example.Entity;
                string type = example.Type;

                if (type != null)
                {
                    if (type.Equals("学院")){
                        switch (entity)
                        {
                            case "继续教育学院":
                                await context.PostAsync("聚焦泛信息社会的人才培养，打造开放式的终身学习平台！");
                                break;
                            default:
                                string question = result.Query;
                                string solution = await NotFind.Sub_Process(question);

                                if (solution == null)
                                {
                                    await context.PostAsync("很抱歉 没能帮您找到答案");
                                }
                                else await context.PostAsync(solution);
                                break;
                        }
                    }
                    if (type.Equals("项目"))
                    {
                        switch (entity)
                        {
                            case "成人高等学历教育":
                                await context.PostAsync("以培养技能型、应用型人才为目标");
                                break;
                            default:
                                string question = result.Query;
                                string solution = await NotFind.Sub_Process(question);

                                if (solution == null)
                                {
                                    await context.PostAsync("很抱歉 没能帮您找到答案");
                                }
                                else await context.PostAsync(solution);
                                break;
                        }
                    }
                }
            }
            context.Wait(MessageReceived);
        }
        
        [LuisIntent("查职位")]
        public async Task CheckPosition(IDialogContext context, LuisResult result)
        {
            string question = result.Query;

            if (question.Equals("方滨兴在北邮是什么职位、")){ 
                await context.PostAsync("网络空间安全院长");
            }
            if (question.Equals("杨放春在北邮是什么职位"))
            {
                await context.PostAsync("感知技术研究院院长");
            }           
            if (question.Equals("乔建永在北邮是什么职位"))
            {
                await context.PostAsync("校长");
            }
            else
            {                
                string solution = await NotFind.Sub_Process(question);

                if (solution == null)
                {
                    await context.PostAsync("很抱歉 没能帮您找到答案");
                }
                else await context.PostAsync(solution);
            }
            context.Wait(MessageReceived);
        }
        
        [LuisIntent("查时间")]
        public async Task CheckTime(IDialogContext context, LuisResult result)
        {
            IList<EntityRecommendation> entityl = result.Entities;

            foreach (EntityRecommendation example in entityl)
            {
                string entity = example.Entity;
                string type = example.Type;

                if (type != null)
                {
                    if (type.Equals("学院")){
                        switch (entity)
                        {
                            case "网络工程":
                                await context.PostAsync("四年");
                                break;
                            default:
                                string question = result.Query;
                                string solution = await NotFind.Sub_Process(question);

                                if (solution == null)
                                {
                                    await context.PostAsync("很抱歉 没能帮您找到答案");
                                }
                                else await context.PostAsync(solution);
                                break;
                        }
                    }
                    if (type.Equals("项目"))
                    {
                        switch (entity)
                        {
                            case "硕博连读":
                                await context.PostAsync("五年");
                                break;
                            default:
                                string question = result.Query;
                                string solution = await NotFind.Sub_Process(question);

                                if (solution == null)
                                {
                                    await context.PostAsync("很抱歉 没能帮您找到答案");
                                }
                                else await context.PostAsync(solution);
                                break;
                        }
                    }
                    if (type.Equals("工种（科研人员、教师等）"))
                    {
                        switch (entity)
                        {
                            case "研究生":
                                await context.PostAsync("三年");
                                break;
                            case "博士生":
                                await context.PostAsync("三年");
                                break;
                            default:
                                string question = result.Query;
                                string solution = await NotFind.Sub_Process(question);

                                if (solution == null)
                                {
                                    await context.PostAsync("很抱歉 没能帮您找到答案");
                                }
                                else await context.PostAsync(solution);
                                break;
                        }
                    }
                }
            }
            context.Wait(MessageReceived);
        }
        
        [LuisIntent("查成果")]
        public async Task CheckAchievements(IDialogContext context, LuisResult result)
        {
            IList<EntityRecommendation> entityl = result.Entities;

            foreach (EntityRecommendation example in entityl)
            {
                string entity = example.Entity;
                string type = example.Type;

                if (type != null)
                {
                    if (type.Equals("学院")){
                        switch (entity)
                        {
                            case "计算机学院":
                                await context.PostAsync("近年来获得国家级教学成果二等奖3项，北京市教学成果一等奖7项；获得 2008年全国百篇优秀博士学位论文奖1篇，中国计算机学会优秀博士论文奖2篇");
                                break;
                            case "人文学院":
                                await context.PostAsync("共承担190余项科研项目，其中国家社科基金项目7项，省部级项目42项；在近四年全国大学生英语竞赛中，我校参赛学生共12人获特等奖，52人获一等奖，获奖总人数居北京高校前列。2012年，法学专业学生在北京市大学生模拟法庭竞赛中荣获一等奖");
                                break;
                            default:
                                string question = result.Query;
                                string solution = await NotFind.Sub_Process(question);

                                if (solution == null)
                                {
                                    await context.PostAsync("很抱歉 没能帮您找到答案");
                                }
                                else await context.PostAsync(solution);
                                break;
                        }
                    }
                    if (type.Equals("工种（科研人员、教师等）"))
                    {
                        switch (entity)
                        {
                            case "学生":
                                await context.PostAsync("在近四年全国大学生英语竞赛中，我校参赛学生共12人获特等奖，52人获一等奖，获奖总人数居北京高校前列。2012年，法学专业学生在北京市大学生模拟法庭竞赛中荣获一等奖");
                                break;
                            default:
                                string question = result.Query;
                                string solution = await NotFind.Sub_Process(question);

                                if (solution == null)
                                {
                                    await context.PostAsync("很抱歉 没能帮您找到答案");
                                }
                                else await context.PostAsync(solution);
                                break;
                        }
                    }
                    if (type.Equals("时间段"))
                    {
                        switch (entity)
                        {
                            case "历年":
                                await context.PostAsync("详情请参见:http://sa.bupt.edu.cn/cgzs/kycg.htm");
                                break;
                            default:
                                string question = result.Query;
                                string solution = await NotFind.Sub_Process(question);

                                if (solution == null)
                                {
                                    await context.PostAsync("很抱歉 没能帮您找到答案");
                                }
                                else await context.PostAsync(solution);
                                break;
                        }
                    }
                }
            }
            context.Wait(MessageReceived);
        }      
        
        [LuisIntent("查创建者和设计者类")]
        public async Task Find_Creator(IDialogContext context, LuisResult result)
        {
            IList<EntityRecommendation> entity1 = result.Entities;
            string entity = null;
            foreach (EntityRecommendation example in entity1)
            {
                entity = entity + example.Entity;
            }

            switch (entity)
            {
                case "北邮校徽":
                    await context.PostAsync("由我国著名设计家，高级工艺师李印清同志设计。");
                    break;
                default:
                    string question = result.Query;
                    string solution = await NotFind.Sub_Process(question);

                    if (solution == null)
                    {
                        await context.PostAsync("很抱歉 没能帮您找到答案");
                    }
                    else await context.PostAsync(solution);
                    break;
            }            
            context.Wait(MessageReceived);
        }
        
        [LuisIntent("查费用")]
        public async Task Find_Expense(IDialogContext context, LuisResult result)
        {
            IList<EntityRecommendation> entity1 = result.Entities;
            foreach (EntityRecommendation example in entity1)
            {
                string entity = example.Entity;
                string type = example.Type;
                if (type != null)
                {
                    if (type.Equals("学院"))
                    {
                        switch (entity)
                        {
                            case "国际学院":        
                                await context.PostAsync("学费六万元/学年");
                                break;
                            case "国院":        
                                await context.PostAsync("学费六万元/学年");
                                break;
                            default:
                                string question = result.Query;
                                string solution = await NotFind.Sub_Process(question);

                                if (solution == null)
                                {
                                    await context.PostAsync("很抱歉 没能帮您找到答案");
                                }
                                else await context.PostAsync(solution);
                                break;
                        }
                    }
                }
            }
            context.Wait(MessageReceived);
        }
        
        [LuisIntent("查要求")]
        public async Task Find_Ask(IDialogContext context, LuisResult result)
        {
            IList<EntityRecommendation> entity1 = result.Entities;
            string entity = null;
            foreach (EntityRecommendation example in entity1)
            {
                entity = entity + example.Entity;
            }

            switch (entity)
            {
                case "自动化学院本科生毕业设计":
                    await context.PostAsync("详情请参见:http://sa.bupt.edu.cn/rcpy/bks/bysj.htm");
                    break;
                default:
                    string question = result.Query;
                    string solution = await NotFind.Sub_Process(question);

                    if (solution == null)
                    {
                        await context.PostAsync("很抱歉 没能帮您找到答案");
                    }
                    else await context.PostAsync(solution);
                    break;
            }                                                  
            context.Wait(MessageReceived);
        }
        
        [LuisIntent("查资产")]
        public async Task Find_Asset(IDialogContext context, LuisResult result)
        {
            IList<EntityRecommendation> entity1 = result.Entities;
            string entity = null;
            foreach (EntityRecommendation example in entity1)
            {
                entity = entity + example.Entity;
            }

            switch (entity)
            {
                case "信息与通信工程学院实验中心设备":
                    await context.PostAsync("1600余万元");
                    break;
                default:
                    string question = result.Query;
                    string solution = await NotFind.Sub_Process(question);

                    if (solution == null)
                    {
                        await context.PostAsync("很抱歉 没能帮您找到答案");
                    }
                    else await context.PostAsync(solution);
                    break;
            }           
            context.Wait(MessageReceived);
        }
        
        [LuisIntent("问面积")]
        public async Task Find_Area(IDialogContext context, LuisResult result)
        {
            IList<EntityRecommendation> entity1 = result.Entities;
            string entity = null;
            foreach (EntityRecommendation example in entity1)
            {
                entity = entity + example.Entity;
            }

            switch (entity)
            {
                case "信息与通信工程学院实验中心总":
                    await context.PostAsync("2000平方米");
                    break;
                default:
                    string question = result.Query;
                    string solution = await NotFind.Sub_Process(question);

                    if (solution == null)
                    {
                        await context.PostAsync("很抱歉 没能帮您找到答案");
                    }
                    else await context.PostAsync(solution);
                    break;
            }            
            context.Wait(MessageReceived);
        }
        
        [LuisIntent("None")]
        public async Task None(IDialogContext context, LuisResult result)
        {
            string question = result.Query;

            string solution = await NotFind.Sub_Process(question);

            if(solution == null)
            {
                await context.PostAsync("很抱歉 没能帮您找到答案");
            }
            else await context.PostAsync(solution);
            context.Wait(MessageReceived);
        }
    }
}
