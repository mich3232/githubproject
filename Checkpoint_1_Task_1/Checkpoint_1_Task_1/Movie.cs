using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint_1_Task_1
{
    class Movie
    {
        private string movieTitle;
        private string movieGenre;
        private DateTime movieReleaseDate;
        private int movieRank;

        public string Title
        {
            get { return movieTitle; }
            set { movieTitle = value; }
        }
        
        public string Genre
        {
            get { return movieGenre; }
            set { movieGenre = value; }
        }
       
        public DateTime ReleaseDate
        {
            get { return movieReleaseDate; }
            set { movieReleaseDate = value; }
        }

        public int Rank
        {
            get { return movieRank; }
            set { movieRank = value; }

        }
    }
}
