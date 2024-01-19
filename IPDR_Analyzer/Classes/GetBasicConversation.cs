using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPDR_Analyzer.Classes
{
    class GetBasicConversation
    {
        public string BasicConversation { get; set; }
        public int BasicConversationCount { get; set; }
       
        public GetBasicConversation(string BasicConversation, int BasicConversationCount)
        {
            this.BasicConversation = BasicConversation;
            this.BasicConversationCount = BasicConversationCount;
        }
    }
}
