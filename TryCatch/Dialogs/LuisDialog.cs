﻿using Microsoft.Bot.Builder.Dialogs;
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
