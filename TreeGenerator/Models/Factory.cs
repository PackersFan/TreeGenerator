using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TreeGenerator.Models
{
    public class Factory
    {
        public int ID { get; set; }
        public int parent { get; set; }
        public int depth { get; set; }
        public string name { get; set; }
        public int childrenCount { get; set; }
        public int lowBound { get; set; }
        public int upBound { get; set; }
        public List<Factory> children { get; set; }


    }
}