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
        public async Task Ask_Name(IDialogContext context, LuisResult result)
        {            
            await context.PostAsync("你好，我叫TryCatch，我是北邮智能查询机器人，有什么问题尽管问我好啦，我一定竭尽全力去回答！");                             
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
                    await context.PostAsync("");
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
                    await context.PostAsync("党政办公室、组织部（党校）、宣传部、统战部、学生工作部（武装部）、研究生工作部、保密办公室、 保卫部、校工会、校团委、机关党委、教务党委、信息与通信工程学院党委、电子工程学院党委、计算机学院党委、自动化学院党委、软件学院党委、数字媒体与设计艺术学院党委、网络空间安全学院党委、理学院党委、经济管理学院党委、人文学院党委、马克思主义学院党委、国际学院党委、网络教育学院党委、民族教育学院党委、网络技术研究院党委、信息光子学与光通信研究院党委、后勤党委、离休党委、退休党委、资产经营公司党委、世纪学院党委、纪律检查委员会、纪委办公室");
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
                    await context.PostAsync("http://www.bupt.edu.cn/");
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
                    await context.PostAsync("");
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
                    await context.PostAsync("很抱歉 没能帮您找到答案");
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
                    await context.PostAsync("很抱歉 没能帮您找到答案");
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
                    await context.PostAsync("很抱歉 没能帮您找到答案");
                    break;

            }
            context.Wait(MessageReceived);
        }

        [LuisIntent("查背景")]
        public async Task CheckBackground(IDialogContext context, LuisResult result)
        {
            string question = result.Query;
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

        [LuisIntent("查特征")]
        public async Task CheckFeature(IDialogContext context, LuisResult result)
        {
            IList<EntityRecommendation> entityl = result.Entities;

            foreach (EntityRecommendation example in entityl)
            {
                string entity = example.Entity;
                string type = example.Type;

                if (type != null)
                {
                    if (type.Equals("学院")) {
                        switch (entity)
                        {
                            case "电子工程学院":
                                await context.PostAsync("无线电、通信微电子、光电子和生物电子");
                                break;
                            case "公共管理学院":
                                await context.PostAsync("信息网络优势");
                                break;
                            default:
                                break;
                        }
                    }
                    if (type.Equals("项目")) {
                        switch (entity)
                        {
                            case "成人高等学历教育":
                                await context.PostAsync("面向通信信息领域开展学历教育的办学特色");
                                break;
                            default:
                                break;
                        }
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
            /*
            if (question.Equals("刘志晗在北邮是什么职位"))
            {
                await context.PostAsync("");
            }*/

            if (question.Equals("乔建永在北邮是什么职位、"))
            {
                await context.PostAsync("校长");
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
                                break;
                        }
                    }
                }
            }
            context.Wait(MessageReceived);
        }
        [LuisIntent("查价值和意义类")]
        public async Task CheckValueAndSignificance(IDialogContext context, LuisResult result)
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
                                await context.PostAsync("信息时代终生学习的推动者！");
                                break;
                            default:
                                await context.PostAsync("信息时代终生学习的推动者！");
                                break;
                        }
                    }
                }
            }
            context.Wait(MessageReceived);
        }

        [LuisIntent("查名称和称呼")]
        public async Task Appellation(IDialogContext context, LuisResult result)
        {
            IList<EntityRecommendation> entity1 = result.Entities;
            string entity = null;
            foreach (EntityRecommendation example in entity1)
            {
                entity = entity + example.Entity;
            }

            switch (entity)
            {
                case "信息与通信工程学院副院长":
                    await context.PostAsync("许琼来");
                    break;
                case "信息与通信工程学院院长":
                    await context.PostAsync("张琳");
                    break;
                case "刘韵洁是信息与通信工程学院院长":
                    await context.PostAsync("错");
                    break;
                case "信息与通信工程学院执行院长":
                    await context.PostAsync("张琳");
                    break;
                case "张琳信息与通信工程学院执行院长":
                    await context.PostAsync("对");
                    break;
                case "信息与通信工程学院党委书记":
                    await context.PostAsync("杨洁");
                    break;
                case "信息与通信工程学院副书记":
                    await context.PostAsync("许琼来");
                    break;
                case "尹长川冯春燕苏菲信息与通信工程学院副院长":
                    await context.PostAsync("尹长川、冯春燕、苏菲");
                    break;
                case "尹长川冯春燕苏菲信息与通信工程学院副书记":
                    await context.PostAsync("是");
                    break;
                case "网络空间安全院长":
                    await context.PostAsync("方滨兴院士");
                    break;
                case "网络空间安全执行院长":
                    await context.PostAsync("马东华教授");
                    break;
                case "网络空间安全副院长":
                    await context.PostAsync("吴旭");
                    break;
                case "软件学院执行院长":
                    await context.PostAsync("邝坚");
                    break;
                case "软件学院副院长":
                    await context.PostAsync("王文东和张笑燕");
                    break;
                case "软件学院党委书记":
                    await context.PostAsync("王文东");
                    break;
                case "人文学院党委书记":
                    await context.PostAsync("胡启镔");
                    break;
                case "理学院院长":
                    await context.PostAsync("郑厚植院士");
                    break;
                case "理学院党委书记":
                    await context.PostAsync("袁喆颖");
                    break;
                case "经济管理学院工会的主任":
                    await context.PostAsync("闫强");
                    break;
                case "经济管理学院学科建设与科研主任":
                    await context.PostAsync("闫强");
                    break;
                case "经济管理学院学实验中心主任":
                    await context.PostAsync("张翼");
                    break;
                case "经济管理学院EMBA主任":
                    await context.PostAsync("待定");
                    break;
                case "经济管理学院财务室主任":
                    await context.PostAsync("徐慧娟");
                    break;
                case "经济管理学院教务科科长":
                    await context.PostAsync("韩同富");
                    break;
                case "经济管理学院院务办公室主任":
                    await context.PostAsync("李婧璇");
                    break;
                case "经济管理学院MBA主任":
                    await context.PostAsync("谢智勇");
                    break;
                case "经济管理学院院长":
                    await context.PostAsync("周宏仁");
                    break;
                case "经管院院长":
                    await context.PostAsync("周宏仁");
                    break;
                case "经济管理学院党委书记":
                    await context.PostAsync("庄育峰");
                    break;
                case "计算机学院党委书记":
                    await context.PostAsync("计算机学院的院长是李德毅院士");
                    break;
                case "计算机学院副院长":
                    await context.PostAsync("副院长是张雷教授和卞佳丽教授");
                    break;
                case "计算机学院副党委书记":
                    await context.PostAsync("副党委书记是赵晓晔");
                    break;
                case "网络技术研究院院长":
                    await context.PostAsync("陈俊亮");
                    break;
                case "陈俊亮网络技术研究院院长":
                    await context.PostAsync("是");
                    break;
                case "网络技术研究院党委书记":
                    await context.PostAsync("白梅");
                    break;
                case "网络技术研究院副院长":
                    await context.PostAsync("苏森、邱雪松");
                    break;
                case "白梅网络技术研究院党委书记":
                    await context.PostAsync("是");
                    break;
                case "苏森邱雪松亓峰高飞网络技术研究院副院长":
                    await context.PostAsync("白梅");
                    break;
                case "中共北京邮电大学网络技术研究院现任党委书记":
                    await context.PostAsync("白梅");
                    break;
                case "白梅中共北京邮电大学网络技术研究院现任党委书记":
                    await context.PostAsync("是");
                    break;
                case "中共北京邮电大学网络技术研究院现任党委委员":
                    await context.PostAsync("苏森、温巧燕、亓峰、高飞、黄小红、魏玲");
                    break;
                case "苏森温巧燕中共北京邮电大学网络技术研究院现任党委委员":
                    await context.PostAsync("是");
                    break;
                case "信息光子学与光通信研究院院长":
                    await context.PostAsync("纪越峰 教授");
                    break;
                case "信息光子学材料与器件研究中心中心主任":
                    await context.PostAsync("余重秀 教授");
                    break;
                case "信息光子学材料与器件研究中心骨干教授":
                    await context.PostAsync("任晓敏 教授、黄永清 教授、黄辉教授");
                    break;
                case "信息光子学材料与器件研究中心青年人才":
                    await context.PostAsync("王葵茹 副教授、张  霞 副教授、王  琦 副教授、桑新柱 副教授");
                    break;
                case "光通信系统与光子网络研究中心骨干教授":
                    await context.PostAsync("林金桐 教授、顾畹仪 教授、纪越峰 教授、张  杰 教授、李  蔚 教授、伍  剑 教授、张小频 教授");
                    break;
                case "光通信系统与光子网络研究中心青年人才":
                    await context.PostAsync("徐  坤 副教授、张永军 副教授、张  民 副教授、张阳安 副教授、喻  松 副教授、黄善国 副教授");
                    break;
                case "信息光子学基础研究中心中心主任":
                    await context.PostAsync("张晓光 教授");
                    break;
                case "信息光子学基础研究中心骨干教授":
                    await context.PostAsync("俞重院 教授");
                    break;
                case "信息光子学基础研究中心青年人才":
                    await context.PostAsync("韩利红 副教授、刘玉敏 副教授、芦鹏飞 副教授、席丽霞 副教授");
                    break;
                case "感知技术研究院院长":
                    await context.PostAsync("杨放春");
                    break;
                case "感知技术研究院副院长":
                    await context.PostAsync("明安龙");
                    break;
                case "国际学院党委书记":
                    await context.PostAsync("王宏原");
                    break;
                case "国际学院常务副院长":
                    await context.PostAsync("郭莉教授");
                    break;
                case "信息光子学与光通信研究院党委书记兼副院长":
                    await context.PostAsync("王 霞 高级工程师");
                    break;
                case "信息光子学与光通信研究院副院长":
                    await context.PostAsync("张 杰 教授、张 泳 高级工程师");
                    break;
                case "信息光子学与光通信研究院研究生院学术委员会主任":
                    await context.PostAsync("任晓敏 教授");
                    break;
                case "电子工程学院副院长":
                    await context.PostAsync("忻向军 教授、王卫东 教授、黄善国 教授");
                    break;
                case "电子工程学院党委副书记":
                    await context.PostAsync("任增霞");
                    break;
                case "电子工程学院院长":
                    await context.PostAsync("薛其坤 院士");
                    break;
                case "电子工程学院执行院长":
                    await context.PostAsync("刘元安 教授");
                    break;
                case "北京邮电大学中文校名":
                    await context.PostAsync("北京邮电大学");
                    break;
                case "北京邮电大学中文全称":
                    await context.PostAsync("北京邮电大学");
                    break;
                case "北京邮电大学英文缩写":
                    await context.PostAsync("BUPT");
                    break;
                case "北京邮电大学英文全称":
                    await context.PostAsync("Beijing University Posts and Telecommunications");
                    break;
                case "北邮中文全称":
                    await context.PostAsync("北京邮电大学");
                    break;
                case "北邮英文缩写":
                    await context.PostAsync("BUPT");
                    break;
                case "北邮英文全称":
                    await context.PostAsync("University");
                    break;
                case "北邮中文校名":
                    await context.PostAsync("北京邮电大学");
                    break;
                case "自动化学院二级学科负责人":
                    await context.PostAsync("机械设计及理论：廖启征、机械设计及理论：孙汉旭、机械制造及自动化：刘晓平、控制理论与控制工程：魏世民、模式识别与智能系统：贾庆轩、检测技术与自动化装置：许良军、物流工程（自设）：杨福兴");
                    break;
                case "自动化学院一级学科负责人":
                    await context.PostAsync("机械工程：孙汉旭；控制科学与工程：许良军");
                    break;
                case "自动化学院行政副院长":
                    await context.PostAsync("马启华");
                    break;
                case "自动化学院副院长":
                    await context.PostAsync("魏世民");
                    break;
                case "自动化学院党委书记":
                    await context.PostAsync("马启华");
                    break;
                case "自动化学院行政执行院长":
                    await context.PostAsync("刘晓平");
                    break;
                case "自动化学院院长":
                    await context.PostAsync("王天然");
                    break;
                case "北京邮电大学信息与通信工程学院校友分会秘书长":
                    await context.PostAsync("王文华");
                    break;
                case "北京邮电大学信息与通信工程学院校友分会会长":
                    await context.PostAsync("张琳");
                    break;
                case "计算机学院院长":
                    await context.PostAsync("李德毅院士");
                    break;

                default:
                    await context.PostAsync("");
                    break;

            }
            context.Wait(MessageReceived);
        }

        [LuisIntent("查简介")]
        public async Task Brief(IDialogContext context, LuisResult result)
        {
            IList<EntityRecommendation> entity1 = result.Entities;
            string entity = null;
            foreach (EntityRecommendation example in entity1)
            {
                entity = entity + example.Entity;
            }

            switch (entity)
            {
                case "北京邮电大学信息与通信工程学院":
                    await context.PostAsync("北京邮电大学信息与通信工程学院以信息科技为特色，以突出的学科实力和明显的专业优势，在全国信息通信领域享有很高的声誉。重点建设的一级学科“信息与通信工程”是国家级重点学科，也是我校“211工程”和“985优势学科建设平台”重点建设的学科，在2012年学科评估中评为全国第一。学院的学科和专业源自于北京邮电大学1955年建校时创建的有线电工程系和无线电工程系，经过60余年的建设与发展，已经成为北京邮电大学学科实力最突出、专业优势最明显、师资力量最雄厚、历史渊源最深远的学院。");
                    break;
                case "网络空间安全方滨兴":
                    await context.PostAsync("方滨兴，男，中国工程院院士，可信分布式计算与服务教育部重点实验室主任；中国网络空间安全协会理事长；国务院学位委员会网络空间安全学科评议组召集人；国家信息化专家咨询委员会网络与信息安全专委会副主任；国家网络与信息安全应急指挥专家组副组长");
                    break;
                case "网络空间安全杨义先":
                    await context.PostAsync("杨义先,男,长江学者奖励计划特聘教授、国家杰出青年基金获得者、国家级教学名师。现任灾备技术国家工程实验室主任。灾备技术国家工程实验室主任。中国密码学会常务理事、中国人工智能学会常务理事、中国通信学会会士、中国电子学会理事。博导，硕导。教授。承担课程?研究方向：网络与信息安全，现代密码理论与应用。");
                    break;
                case "网络空间安全马华东":
                    await context.PostAsync("马华东，男，执行院长（兼）。学术兼职中国计算机学会常务理事、传感网专委会副主任、多媒体专委会副主任，中国图形图像学会常务理事，中国电子学会理事，第十四届国家自然科学基金委信息学部专家评审组成员，教育部高等学校计算机类专业教学指导委员会委员。曾任中");
                    break;
                case "网络空间安全陈秀波":
                    await context.PostAsync("陈秀波,女,硕导。副教授。承担课程：信息安全数学基础、信息安全专业英语、数论及其应用研究方向新型密码与应用；网络隐私与信息保密");
                    break;
                case "网络空间安全崔宝江":
                    await context.PostAsync("崔宝江,男,承担课程信息安全概论、信息安全综合实验研究方向网络攻防、漏洞挖掘、大数据安全分析个人介绍崔宝江，男，教授，博士生导师。2004年在南开大学获博士学位，同年到北京邮电大学任教。");
                    break;
                case "网络空间安全邓小龙":
                    await context.PostAsync("邓小龙，男，职务讲师学术兼职中国网络空间安全协会青年专家老师类型硕士研究生导师所属中心网络安全与治理中心职称讲师承担课程大数据内容安全研究方向数据挖掘、社交网络内容安全分析、机器学习个人介绍博士，硕士研究生导师");
                    break;
                case "网络空间安全谷利泽":
                    await context.PostAsync("谷利泽,男,承担课程：现代密码学，信息安全概论。研究方向：信息安全、网络安全、密码学的理论和应用、安全管理、信任管理");
                    break;
                case "网络空间安全郭燕慧":
                    await context.PostAsync("	郭燕慧,女,信息安全管理（本/硕）、人工智能原理（本）研究方向移动互联网安全、人工智能应用个人介绍1997年毕业于燕山大学无线电技术专业");
                    break;
                case "网络空间安全黄勤龙":
                    await context.PostAsync("黄勤龙，男，学术兼职中国计算机学会会员、中国密码学会会员，IEEE Transactions on Information Forensics & Security、IET Information Security、SCIENCE CHINA Information Sciences等期刊审稿人");
                    break;
                case "网络空间安全胡正名":
                    await context.PostAsync("胡正名,男,博导。教授。?研究方向：编码与密码理论。个人介绍：?承担课题?获奖和成果?发表论文?联系电话010-62283366工作地点?Emailxxniu@bupt.edu.cn");
                    break;
                case "网络空间安全雷敏":
                    await context.PostAsync("雷敏,男,兼职中国通信学会通信软件技术委员会秘书，中国通信学会青年工作委员会秘书老师类型教学科研所属中心信息安全中心职称讲师承担课程信息系统安全实验、移动终端安全实践、信息安全实验研究方向物联网安全、智能家居安全分析、网络攻防");
                    break;
                case "网络空间安全李晖":
                    await context.PostAsync("李晖,女,无线通信安全(本科课程)无线移动通信安全技术(研究生课程)研究方向移动通信安全、移动终端安全、物联网安全、密码应用技术");
                    break;
                case "网络空间安全李丽香":
                    await context.PostAsync("李丽香，女，博导。教授。兼职美国《数学评论》评论员；SCI期刊PLoS One 和 Journal of Applied Mathematics杂志的编委。承担课程：信息论与编码（本科）、混沌计算（本科）、混沌理论及应用（研究生）、编码理论（研究生）、运筹学与优化（研究生）研究方向复杂网络安全与同步");
                    break;
                case "网络空间安全李祺":
                    await context.PostAsync("李祺,女,课程本科《嵌入式系统及安全》 、研究生《物联网安全》研究方向软件安全、物联网安全");
                    break;
                case "网络空间安全李小勇":
                    await context.PostAsync("李小勇性别男职务网络空间安全学院副院长学术兼职CCF高级会员、ACM/IEEE会员，CCF容错计算专委会委员、CCF开放系统专业委员会委员、CCF计算机应用专业委员会委员；IEEE TPDS/TKDE/TWC/TIFS等多个国际顶级期刊的审稿人；任Frontiers of Computer Science(Springer)、China Communications等SCI期刊的AE或者Guest AE及多个国内外会议的TPC成员");
                    break;
                case "网络空间安全刘健毅":
                    await context.PostAsync("刘建毅,男,承担课程计算机网络，数字内容安全研究方向数字内容安全，智能信息处理，数据挖掘");
                    break;
                case "网络空间安全芦效峰":
                    await context.PostAsync("芦效峰,男,安全中心党支部书记，副主任学术兼职IEEE会员老师类型硕导所属中心软件安全中心职称副教授承担课程软件工程技术基础、软件安全、软件开发安全，C++高级程序设计、Linux操作系统管理研究方向智能决策与数据安全、软件安全、工控软件安全等");
                    break;
                case "经济管理学院工会的主任":
                    await context.PostAsync("闫强");
                    break;
                case "网络空间安全路月明":
                    await context.PostAsync("男?，院学术委员会委员?，教授?、博士生导师。所属中心：?网络安全与治理中心?。??研究方向?：信息安全、大数据分析教育部新世纪人才获得者；从事信息安全、大数据分析、网络仿真等研究工作；承担和完成863、973等课题30多项，获得国家发明专利授权30项，在国内外重要学术刊物上发表论文100多篇");
                    break;
                case "网络空间安全罗群":
                    await context.PostAsync("罗群，女，教授。承担课程：高等数学研究方向复杂网络、混沌保密通信。?承担课题多重边复杂网络的模型与同步研究，国家自然科学基金项目面上项目");
                    break;
                case "网络空间安全罗守山":
                    await context.PostAsync("罗守山,男,课程信息与网络安全（本科），近世代数及其应用（研究生）研究方向密码学、网络安全。个人介绍北京邮电大学网络空间安全学院教授，博士生导师");
                    break;
                case "网络空间安全马兆丰":
                    await context.PostAsync("马兆丰性别男职务移动互联网与大数据安全联合实验室主任学术兼职1.中关村数字视频联盟副秘书长2.互联网安全工作组学术委员会委员 3.国家自然基金委项目评议同行老师类型教学科研型所属中心信息安全中心职称教师承担课程《网络信息安全编程实例开发》、《C语言高级程序设计》研究方向移动互联网技术创新与安全");
                    break;
                case "网络空间安全彭海朋":
                    await context.PostAsync("彭海朋，男，硕导。副教授。SCI期刊PLoS One 和 Mathematical Problems in Engineering杂志的编委。承担课程：信息论与编码（本科）、混沌计算（本科）、编码理论（研究生）、Walsh函数与Hadamard矩阵（研究生）研究方向复杂网络安全与同步、混沌密码、群体智能、压缩感知");
                    break;
                case "网络空间安全石瑞生":
                    await context.PostAsync("	石瑞生,男,硕导。高级工程师。属网络安全与治理中心可信实验室。承担课程：云计算原理与服务，大数据服务与隐私保护，数据库技术与应用研究方向移动云计算及其安全，大数据服务与隐私保护");
                    break;
                case "网络空间安全孙斌":
                    await context.PostAsync("孙斌,女,硕导。副教授。承担课程：高级计算机网络与网络安全，高级计算机体系结构与云计算研究方向云计算安全，大数据分析，无线网络安全");
                    break;
                case "网络空间安全王春露":
                    await context.PostAsync("王春露性别 女职务 学术兼职 自然科学基金评审专家2011年，IEEE ICC会议组委会成员（TPC）;IEEE Globcom 2014, 审稿人。《计算机学报》审稿人中国计算机学会，高级会员;中国智能交通学会，高级会员中国人工智能学会，人工智能与模式识别专委会，委员老师类型 硕导所属中心 网络空间安全与治理职称 副教授承担课程计算机系统结构高级计算机系统结构研究方向");
                    break;
                case "网络空间安全王东滨":
                    await context.PostAsync("王东滨,男,网络空间安全学科评议组秘书。硕导。副教授。承担课程：网络安全技术、Python语言与编程研究方向网络与信息安全、网络模拟、大数据分析、ad hoc网络");
                    break;
                case "网络空间安全王励成":
                    await context.PostAsync("王励成,男,博导。副教授。承担课程：密码分析。研究方向：后量子密码。个人介绍：2007年博士毕业于上海交通大学；2009~2010年赴日本国家通信技术研究所任客座研究员");
                    break;
                case "网络空间安全吴旭":
                    await context.PostAsync("吴旭,女,院党委副书记。全国工程硕士教指委信息检索教学专家组成员，北京科技情报学会常务理事、青工委主任，北邮网络空间安全学院学术委员会委员。硕士生导师。研究员。所属中心：网络安全与治理中心。承担课程：现代信息检索技术、竞争情报技术、大学计算机基础、信息检索与知识管理");
                    break;
                case "网络空间安全伍淳华":
                    await context.PostAsync("伍淳华性别女职务无学术兼职无老师类型教学科研所属中心信息安全中心职称讲师承担课程本科课程：《Java高级程序语言设计》研究生课程：《高级网络安全研究与应用》研究方向网络安全、大数据分析");
                    break;
                case "网络空间安全武斌":
                    await context.PostAsync("武斌,男,数据结构、网络安全实验研究方向网络安全个人介绍博士，2008年毕业于北京邮电大学计算机学院，获工学博士学位。主要从事网络与信息安全方向的教学科研工作");
                    break;
                case "网络空间安全肖达":
                    await context.PostAsync("肖达,男,硕导。讲师。承担课程：数据库技术与应用、数据结构。研究方向：机器学习（主要是深度学习，强化学习）的模型和算法研究及其在自然语言理解、攻击检测和程序分析等领域的应用，云存储安全");
                    break;
                case "网络空间安全颉夏青":
                    await context.PostAsync("颉夏青，女，教师类型：教辅，所属中心：实验教学中心，职称：工程师，研究方向：大数据安全与智能处理，个人介绍：北邮信息安全本科生、计算机科学与技术硕士研究生。2011年开始从事云安全、可信计算、大数据安全、大数据智能处理相关领域的科研工作");
                    break;
                case "网络空间安全辛阳":
                    await context.PostAsync("辛阳，男，灾备技术国家工程实验室副主任。灾备技术产业联盟秘书长、云安全北京市工程实验室主任、移动互联网系统与应用安全国家工程实验室技术委员会委员、中国密码学会教育与科普委员会委员。硕导。副教授");
                    break;
                case "网络空间安全徐国爱":
                    await context.PostAsync("徐国爱，男，软件安全中心主任。博导。教授。电子学会高级会员。承担课程：软件安全。研究方向：软件安全、信息安全管理、密码学	");
                    break;
                case "网络空间安全徐国胜":
                    await context.PostAsync("徐国胜，男，讲师。承担课程：信息安全数学基础、密码工程、软件安全。研究方向：大数据安全、机器学习和现代密码学");
                    break;
                case "网络空间安全杨文川":
                    await context.PostAsync("杨文川,男,大数据处理与网络信息挖掘， 高级计算机网络研究方向数据仓库与数据挖掘，大数据分析挖掘");
                    break;
                case "网络空间安全杨榆":
                    await context.PostAsync("杨榆,女,承担课程《信息隐藏理论与技术》《信息隐藏与数字水印》《网络安全实验》研究方向数字内容安全，信息安全，大数据与云安全");
                    break;
                case "网络空间安全张茹":
                    await context.PostAsync("张茹,女,硕导。副教授。通信学会多媒体安全专家委员会；防伪行业协会防伪专家委员会。承担课程：数字内容安全。研究方向：数字内容安全、信息隐藏、数字水印、工业系统安全。主要从事信息隐藏，数字水印，数字内容安全、工业系统安全等");
                    break;
                case "网络空间安全张天乐":
                    await context.PostAsync("	张天乐,男,兼职国际标准组织ISO/ JTC1/SC7/WG25工作组编辑老师类型教师所属中心可信分布式计算与服务教育部重点实验室职称副教授承担课程《操作系统》（英文授课）、《计算机组成原理》、《微机原理与接口技术》研究方向网络安全、移动互联网、智能电网");
                    break;
                case "网络空间安全张淼":
                    await context.PostAsync("张淼,男,课程软件安全、软件安全实验、移动终端安全研究方向网络安全对抗、移动互联网安全、软件安全");
                    break;
                case "网络空间安全张熙":
                    await context.PostAsync("张熙,男,兼职SCI学术期刊 Frontiers of Computer Science 青年AE老师类型,承担课程数据结构 操作系统研究方向数据挖掘和机器学习，多核处理器设计，计算机体系结构");
                    break;
                case "网络空间安全郑康峰":
                    await context.PostAsync("郑康锋，男，副教授。承担课程：网络安全、高级网络安全研究与应用研究方向网络安全、移动互联网安全、大数据分析");
                    break;
                case "网络空间安全郑世慧":
                    await context.PostAsync("郑世慧,女,承担课程：现代密码学、数字签名及其扩展。研究方向：密码设计与分析应用。个人介绍：承担课题自然科学基金、十二五预研项目等，目前参与并完成的科研项目有19项");
                    break;
                case "网络空间安全周亚建":
                    await context.PostAsync("周亚建,男,课程信息系统安全（本科），大数据分析（研究生）研究方向文本分类，密文检索，大数据分析，数据隐私保护");
                    break;
                case "网络空间安全朱洪亮":
                    await context.PostAsync("朱洪亮，男，灾备技术国家工程实验室主任助理，云安全北京市工程实验室副主任，灾备技术产业联盟副秘书长。硕导。讲师。承担课程信息安全、网络流量监控等研究方向网络与信息安全、移动互联网安全、大数据及云安全等");
                    break;
                case "网络空间安全邹仕洪":
                    await context.PostAsync("邹仕洪，男，学术兼职：中国计算机学会计算机安全专委会常委、中国计算机学会物联网专委会委员");
                    break;
                case "网络空间安全陶琳":
                    await context.PostAsync("陶琳,性别女,职务辅导员、院团委书记所属部门院机关职称讲师联系电话62283320工作地点教一楼213Emailtaolin@bupt.edu.cn");
                    break;
                case "网络空间安全魏然":
                    await context.PostAsync("魏然，女，所属部门：综合办公室。主要工作职责：党务管理、行政管理等。联系电话62281765。办公地点：教一楼208。E-mailweiran@bupt.edu.cn");
                    break;
                case "网络空间安全高发鑫":
                    await context.PostAsync("高发鑫，男，所属部门：学生管理办公室，主要工作职责：心理工作、助学工作、就业、新闻稿、公寓、征兵等。联系电话：62283170，办公地点教一213。E-mailgaofaxin@sina.com");
                    break;
                case "网络空间安全吴京宸":
                    await context.PostAsync("吴京宸，男，所属部门：学生管理办公室，主要工作职责：辅导员工作、党支部书记。联系电话66605115，办公地点：沙河校区行政办公楼316。E-maillulu@.bupt.edu.cn");
                    break;
                case "网络空间安全张丛越":
                    await context.PostAsync("张从越，女，所属部门：学生工作办公室，主要工作职责：信息安全专业16级辅导员。联系电话58828537;办公地点：北京邮电大学宏福校区综合楼306。E-mailw?ekizhang@126.com");
                    break;
                case "网络空间安全崔翔":
                    await context.PostAsync("崔翔,男?,?博士生导师。职称：研究员?。所属中心：网络安全与治理中心。研究方向：网络安全。中国科学院信息工程研究所第六研究室副主任");
                    break;
                case "网络空间安全郭莉":
                    await context.PostAsync("郭莉,女,正研级高级工程师，兼职硕士生导师。研究方向：网络与信息安全");
                    break;
                case "网络空间安全郭世泽":
                    await context.PostAsync("郭世泽?性别男职务?学术兼职中国科学院语言声学与内容理解重点实验室学术委员会委员，工业控制系统安全技术国家工程实验室副主任，网络安全应急技术国家工程实验室理事。老师类型兼职教授所属中心信息安全中心职称教授，博导承担课程?研究方向网络信息安全");
                    break;
                case "网络空间安全郭涛":
                    await context.PostAsync("涛?性别男职务?学术兼职兼职教授老师类型硕导所属中心软件安全中心职称研究员承担课程?研究方向软件安全缺陷分析，大数据安全");
                    break;
                case "网络空间安全李忠献":
                    await context.PostAsync("李忠献,男,研究方向网络安全个人介绍 承担课题 获奖和成果 发表论文 联系电话010-62283190工作地点新科研楼1110Emaillzx@ncs-cyber.com.cn");
                    break;
                case "网络空间安全齐佳音":
                    await context.PostAsync("齐佳音,女,上海对外经贸大学”数据科学与管理决策”重点实验室主任学术兼职兼职老师类型科研所属中心网络空间安全的立法与治理职称教授承担课程 研究方向网络内容分析与管理决策个人介绍 ");
                    break;
                case "网络空间安全陶小峰":
                    await context.PostAsync("陶小峰性别男?职务无?学术兼职1）IEEE 通信学会北京分会主席；2）中国科协联合国咨商信息技术专业委员会委员；3）《中国科学 信息科学》编委会委员；4）中国电子学会第四届云计算专家委员会委员?老师类型教学科研?所属中心泛网无线通信中心?职称");
                    break;
                case "网络空间安全吴志军":
                    await context.PostAsync("吴志军性别男职务?学术兼职天津市通信学会高级会员。主要研究领域为老师类型兼职教授所属中心信息安全中心职称教授承担课程?研究方向星基航空通信导航关键技术和网络信息安全个人介绍生于1965年5月，博士，教授");
                    break;
                case "网络空间安全许成谦":
                    await context.PostAsync("燕山大学信息科学与工程学院副院长。中国电子协会高级会员。博导、硕导（兼任）教授。承担课程：研究方向密码学与信息安全
                    break;
                case "网络空间安全袁东风":
                    await context.PostAsync("袁东风，男，山东大学信息科学与工程学院院长。IEEE高级会员，IEEE山东分会主席，国家教育部高等学校电子信息类专业教学指导委员会委员，中国电子学会理事，中国电子学会第七届学术工作委员会委员，中国人工智能学会智能数字内容安全专业委员会委员，享受国务院政府特殊津贴专家，山东省“中国虹计划”协同创新中心首席科学家");

                    break;
                case "网络空间安全詹榜华":
                    await context.PostAsync("詹榜华,男,软件安全中心职称教授承担课程 研究方向密码理论研究、密码系统设计与实现和信息安全保障体系设计与实现个人介绍1988 年—1999年在总参51研究 所任副研究员，获国家科技进步二等奖1次，全军科技进步一等奖2次，二等奖一次");
                    break;
                case "网络空间安全张洪欣":
                    await context.PostAsync("张洪欣，男，网络空间安全学院兼任教授。国家自然科学基金、北京市自然科学基金、浙江省自然科学基金、江苏省科技计划等项目评议专家，教育部学位与研究生教育发展中心评议专家，中国电子学会DSP应用专家委员会委员，中国工业和信息化部科技人才库专家，北京市科学技术奖励评审专家，北京电子电器协会电磁兼容分会委员，中国电子学会高级会员");
                    break;
             
                case "信息光子学与光通信研究院、":
                    await context.PostAsync("http://ipoc.bupt.edu.cn/iocolab/view/list/4028472831fac6eb0131fad0d6390001");
                    break;
                case "国际学院项目":
                    await context.PostAsync("国际学院是北京邮电大学实施中外合作办学项目的教学学院。学院现有“北京邮电大学与伦敦玛丽女王大学（原伦敦大学玛丽女王学院）学士学位联合培养项目”。");
                    break;
                case "感知技术研究院基地":
                    await context.PostAsync("http://istb.bupt.edu.cn/contents/38/19.html");
                    break;
                case "明安龙":
                    await context.PostAsync("北京邮电大学教授，博士生导师，现任感知技术与产业研究院常务副院长。主要研究方向是机器视觉与模式识别、图像处理与数字艺术等。主持多项国家级研究课题（科技支撑计划“影像作品艺术风格化系统与应用”、863项目“机动车辆行为过程快速获取与建模技术”、国家自然科学基金项目“多摄像机视频监控中的人物角色分类技术研究”等）。共发表SCI、EI论文20余篇，并申报国内发明专利授权11项（第一发明人8项）。");
                    break;
                case "宋桂岭":
                    await context.PostAsync("北京邮电大学讲师、工程师，硕士。主要研究方向是多媒体系统与网络，计算机视觉与模式识别等，现任感知技术与产业研究院院长助理。先后主持、参与省部级教科研项目6项，主持地市级科研项目2项，获地市级科技成果2项，地市级科技进度奖1项，曾获评江苏省信息产业厅先进工作者。");
                    break;
                case "马天琛":
                    await context.PostAsync("毕业于英国中央兰开夏大学,硕士研究生学历。中国大学生十大年度人物，四川省五四青年奖章获得者，四川省青年企业家协会常务理事，成都青岛商会执行会长，电子科技大学创新创业学院院长助理，四川大学锦城学院兼职教授。作为创始人设立的泰聚泰公司于2015年8月份在在全国股转系统挂牌上市，成为首家全职高校大学生创新创业在全国性股票交易市场上挂牌上市的企业，受到国务院总理李克强等国家省市领导人接见视察，被人民日报，中国日报，经济日报，中国青年报，金融时报，中国科学报，中国教育报，四川日报等众多主流媒体报道。");
                    break;
                case "杨放春":
                    await context.PostAsync("北京邮电大学教授，博士生导师。现任感知技术与产业研究院院长；信息产业部通信科技委委员，中国计算机学会理事，总装备部专业组专家，中国通信学会信息通信网络技术委员会委员。曾获得国家级突出贡献专家、北京市先进工作者、北京市产学研先进个人、北京市教育创新工程创新标兵、北京市高校优秀青年骨干教师、教育部全国高等学校优秀骨干教师等荣誉称号；入选教育部跨世纪优秀人才计划、国家杰出青年科学基金计划。曾主持国家重大科研项目20余项，其中国家自然科学基金项目5项，国家863计划项目8项，国家973项目2项，国防预研项目2项；发表被SCI、EI收录的学术论文100余篇，出版专著8部，获得国家发明专利20余项；科研成果先后有5次获得国家和省部级科技进步奖。曾在试验网一线主持智能网成果的推广示范工作，并通过技术转移和合资等多种方式推动智能网大规模产业化工作，受到过原信息产业部的表彰。依托智能网产业化经验以及的科研成果，又成功研制出一系列电信增值服务支撑系统和相关业务设备，并在现网中得到大规模商用，取得了良好的经济和社会效益。");
                    break;
                case "感知技术研究院":
                    await context.PostAsync("http://istb.bupt.edu.cn/contents/38/19.html");
                    break;
                case "信息光子学与光通信研究院":
                    await context.PostAsync("http://ipoc.bupt.edu.cn/iocolab/view/list/4028472831fac6eb0131fad0d6390001");
                    break;
                case "公共管理学院":
                    await context.PostAsync("http://sppm.bupt.edu.cn/content/content.php?p=2_1_1");
                    break;
                case "电子工程学院":
                    await context.PostAsync("http://see.bupt.edu.cn/content/content.php?p=2_3_1");
                    break;
                case "国际学院":
                    await context.PostAsync("http://is.bupt.edu.cn/xygk/xyjj.htm");
                    break;
                case "自动化学院博士生专业":
                    await context.PostAsync("详情请参见:http://sa.bupt.edu.cn/zsjy/bsszs/zyjs.htm");
                    break;
                case "自动化学院硕士生专业":
                    await context.PostAsync("详情请参见:http://sa.bupt.edu.cn/zsjy/ssszs/zyjs.htm");
                    break;
                case "自动化学院本科生专业":
                    await context.PostAsync("详情请参见:http://sa.bupt.edu.cn/zsjy/bkszs/zyjs.htm");
                    break;
                case "继续教育学院":
                    await context.PostAsync("	 北京邮电大学继续教育学院（原北京邮电大学培训中心）成立于一九八六年，多年来坚持面向通信与信息行业实施非学历继续教育，提供多角度、全方位的培训内容和服务，已成为通信与信息相关企业单位进行新技术培训、高层次知识研修、岗位考核认证以及人才选拔的高级继续教育基地。三十多年来，北京邮电大学继续教育学院紧跟通信与信息行业发展、追踪通信与信息企业单位变革、不断改进服务方式，采用多种培训模式，与众多国内外通信运营商、通信设备制造商、业务/内容提供商保持长期的合作关系。同时也积极拓展服务领域，尽力为全社会提供更多服务。2015年，北京邮电大学继续教育学院以全新的运营体制和模式，面向全社会，提供非学历教育服务。响应国家创新驱动发展战略，助力构建学习型社会与终身学习与发展，致力打造开放式的泛信息人才培养平台。");
                    break;
                default:
                    await context.PostAsync("");
                    break;

            }
            context.Wait(MessageReceived);
        }
        [LuisIntent("None")]
        public async Task None(IDialogContext context, LuisResult result)
        {
            string question = result.Query;
            //string solution = await QnAMaker.MakeRequest(question);

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
