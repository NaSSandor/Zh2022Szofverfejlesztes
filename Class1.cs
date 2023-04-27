using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TED
{
    class TedData
    {
        public string title { get; set; }
        public string author { get; set; }
        public string date { get; set; }
        public int views { get; set; }
        public int likes { get; set; }
        public string link { get; set; }
        public string idontknow;

        public TedData(string t, string a, string d, int v, int lik, string lin)
        {
            title = t;
            author = a;
            date = d;
            views = v;
            likes = lik;
            link = lin;
            idontknow = "";
        }
    }
}
