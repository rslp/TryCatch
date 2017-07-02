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
                return bing.BingToSearch(question);
            }
            else
            {
                return solution;
            }
        }
    }
}