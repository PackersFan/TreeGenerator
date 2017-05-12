using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TreeGenerator.Models
{
    public class Root
    {
       public int ID { get; set; }
       public string name { get; set; }
       public string children_count { get; set; }
       public int active { get; set; }

    }

}