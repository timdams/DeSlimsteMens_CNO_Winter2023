using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace DeSlimsteMens.QuizvragenGenerator
{
    internal class QuizvragenGenerator
    {
        public static List<QuizVraag> GenereerVraag(int aantal = 1)
        {
            string query = $"https://opentdb.com/api.php?amount={aantal}&type=multiple";

            WebClient wc = new WebClient();
            var json = wc.DownloadString(query);
            var rootQuiz = JsonSerializer.Deserialize<JsonQuizRootApiResponse>(json);
            if(rootQuiz.ResponseCode==0)
            {
                return rootQuiz.QuizVragen;
            }
            return null;
        }
    }
}
