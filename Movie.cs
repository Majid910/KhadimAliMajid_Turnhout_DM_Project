using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieConnector
{
    public class Movie : IMovie
    {

        private int id; //+
        private string title; //+
        private string overview; //+
        //private int showTimes;
        private DateTime releaseDate; //+
        private double voteAverage; //+
        private string posterPath;
        private byte[] image; //+
        private List<Cast> casts; //+
        private string genre; //+
        private int runtime; //+

        public Movie(int id, string title, string overview,
            DateTime releaseDate, double voteAverage, byte[] image,
            string genre, int runtime)
        {
            this.id = id;
            this.title = title;
            this.overview = overview;
            this.releaseDate = releaseDate;
            this.voteAverage = voteAverage;
            this.image = image;
            this.genre = genre;
            this.runtime = runtime;
        }

        public Movie(int id, string title, string overview,
            DateTime releaseDate, double voteAverage, string posterPath, 
            List<Cast> casts, string genre, int runtime)
        {
            this.id = id;
            this.title = title;
            this.overview = overview;
            this.releaseDate = releaseDate;
            this.voteAverage = voteAverage;
            this.posterPath = posterPath;
            this.casts = casts;
            this.genre = genre;
            this.runtime = runtime;
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }
        }

        public string Overview
        {
            get
            {
                return overview;
            }
        }

        
        public DateTime ReleaseDate
        {
            get
            {
                return releaseDate;
            }
        }

        public double VoteAverage
        {
            get
            {
                return voteAverage;
            }
        }

        public string PosterPath
        {
            get
            {
                return posterPath;
            }
        }

        public byte[] Image
        {
            get
            {
                return image;
            }
        }

        public List<Cast> Casts
        {
            get
            {
                return casts;
            }
        }
        

        public string Genre
        {
            get
            {
                return genre;
            }
        }

        public int Runtime
        {
            get
            {
                return runtime;
            }
        }

        public int getMovieId()
        {
            return id;
        }

        public Cast getCast(int id)
        {
            foreach (Cast m in casts)
            {
                if (m.Id == id)
                    return m;
            }
            return null;
        }

    }
}
