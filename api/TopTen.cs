using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flappy_Bird.api
{
    /// <summary>
    /// Deserialize the TopTen from the api response into an array.
    /// Used for the leaderboard.
    /// </summary>
    class TopTen
    {
        public string username { get; set; }
        public int score { get; set; }
        public DateTime insertedDate { get; set; }
    }

    /// <summary>
    /// Deserialize the data from the api response.
    /// </summary>
    class Data
    {
        public int amount { get; set; }
        public List<TopTen> data { get; set; }
    }

    /// <summary>
    /// Deserialize the data from the api. Checking if it's in the top ten or not
    /// Getting back the position it should be placed at.
    /// </summary>
    class IsTopTen
    {
        public int success { get; set; }
        public int place { get; set; }
    }
}
