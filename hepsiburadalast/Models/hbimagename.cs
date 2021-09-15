using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hepsiburadalast.Models
{
    public class hbimagename
    {
        public class hbimagenames
        {

            public string image { get; set; }
            public string name { get; set; }
            public string hepsiburadaSku { get; set; }
            public string Url { get; set; }
        }
        public class HBProductLists
        {
            public List<hbimagenames> hbimagenamelist { get; set; }

        }

    }
}
