using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace BasicWebASP2
{
    public class DDLData
    {
        public int ValueId { get; set; }
        public string DisplayText { get; set; }

        public DDLData(int valueid, string displaytext)
        {
            ValueId = valueid;
            DisplayText = displaytext;
        }
        public DDLData()
        {

        }
    }
}