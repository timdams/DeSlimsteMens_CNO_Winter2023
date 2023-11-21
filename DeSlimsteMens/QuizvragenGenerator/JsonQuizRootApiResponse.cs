using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DeSlimsteMens.QuizvragenGenerator
{

    public class JsonQuizRootApiResponse
    {
        [JsonPropertyName("response_code")]
        public int ResponseCode { get; set; }
        [JsonPropertyName("results")]
        public List<QuizVraag> QuizVragen { get; set; }
    }

    

}
