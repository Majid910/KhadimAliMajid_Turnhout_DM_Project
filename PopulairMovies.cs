using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace MovieDB
{
    class PopulairMovies
    {
        public class Movie
        {
            public string tmsId { get; set; }
            public string rootid { get; set; }
            public string subType { get; set; }
            public string title { get; set; }
            public int releaseYear { get; set; }
            public string releaseDate { get; set; }
            public string titleLang { get; set; }
            public string descriptionLang { get; set; }
            public string entityType { get; set; }
            public string[] genres { get; set; }
            public string longDescription { get; set; }
            public string shortDescription { get; set; }
            public string[] topCast { get; set; }
            public string[] directors { get; set; }
            public string officialUrl { get; set; }
            public Rating[] ratings { get; set; }
            public string[] advisories { get; set; }
            public string runTime { get; set; }
            public PreferredImage preferredImage { get; set; }
            public Showtimes[] showtimes { get; set; }
        }

        public class Rating
        {
            public string body { get; set; }
            public string code { get; set; }
        }
        public class PreferredImage
        {
            public string width { get; set; }
            public string height { get; set; }
            public Caption caption { get; set; }
            public string uri { get; set; }
            public string category { get; set; }
            public string text { get; set; }
            public string primary { get; set; }

        }

        public class Caption
        {
            public string content { get; set; }
            public string lang { get; set; }
        }

        public class Showtimes
        {
            public Theatre theatre { get; set; }
            public string dateTime { get; set; }
            public string quals { get; set; }
            public bool barg { get; set; }
        }

        public class Theatre
        {
            public string id { get; set; }
            public string name { get; set; }
        }

        public static List<Movie> getNowPlayingList (string postalCode, string radius)
        {
            List<Movie> movies = null;

            string URL = "http://data.tmsapi.com/v1.1/movies/showings?startDate=" + DateTime.Now.ToString("yyyy-MM-dd") + "&zip=" + postalCode + "&radius=" + radius + "&units=km&api_key=dew6y4w77mw4xawmhqqq22wu";
            HttpClient client = new HttpClient();
            Task task = client.GetAsync(URL)
             .ContinueWith((taskwithresponse) =>
             {
                 var response = taskwithresponse.Result;
                 var jsonString = response.Content.ReadAsStringAsync();
                 jsonString.Wait();
                 movies = JsonConvert.DeserializeObject<List<Movie>>(jsonString.Result);
                 return movies;
             });
            task.Wait(10000);
            return movies;
        } 
    }
}
