using System.Threading.Tasks;

namespace TryCatch.Dialogs
{
    public class NotFind
    {
        public static async Task<string> Sub_Process(string question)
        {
            string solution = await QnAMaker.MakeRequest(question);

            if (solution == null)
            {                
                BingSearch bing = new BingSearch();
                string no = "以下答案来源于其他途径，并不保证正确： ";
                return (no + bing.BingToSearch(question));
            }
            else
            {
                return solution;
            }
        }
    }
}