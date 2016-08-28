using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trello_API_Wrapper
{
    public class TrelloApiWrapper
    {
        internal APIConfiguration Configuration;

        public 

        public TrelloApiWrapper(string APIKey)
        {
            Configuration = new APIConfiguration();
            Configuration.Key = APIKey;
        }
    }
}
