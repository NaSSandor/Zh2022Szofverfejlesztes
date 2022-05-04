using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TED
{

    public class Rootobject
    {
        public Main[] Property1 { get; set; }
        public List[] list { get; set; }
    }

    public class Main
    {
        public string title { get; set; }
        public string author { get; set; }
        public string date { get; set; }
        public int views { get; set; }
        public int likes { get; set; }
        public string link { get; set; }
    }


    public class List
    {
        public int dt { get; set; }
        public Main main { get; set; }
    
    }
}
