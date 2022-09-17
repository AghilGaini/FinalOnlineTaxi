using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseDomain.OtherModels
{
    public class ActionItem
    {
        public string Action { get; set; }
        public string Controller { get; set; }
        public string Title { get; set; }
        public string OnClickFunction { get; set; }
    }
}
