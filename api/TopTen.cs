using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flappy_Bird.api
{
    class TopTen
    {
        public string username { get; set; }
        public int score { get; set; }
        public DateTime insertedDate { get; set; }
    }

    class Data
    {
        public int amount { get; set; }
        public List<TopTen> data { get; set; }
    }

    class IsTopTen
    {
        public int success { get; set; }
        public int place { get; set; }
    }
}
