using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TreeGenerator.Models
{
    public class Factory
    {
        int ID { get; set; }
        int parent { get; set; }
        string name { get; set; }
        int childrenCount { get; set; }
        int lowBound { get; set; }
        int upBound { get; set; }



    }
}