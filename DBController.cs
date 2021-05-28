using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net;
using System.IO;

namespace MovieDB
{
    public class DBController
    {
     
        string connectionString = Properties.Settings.Default.dbConnectionString;

        public DBController()
        {
        }

        public bool checkIfMovieInDatabase(int movieId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(@"SELECT id FROM movie WHERE id = @id");
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@id", movieId);
                    connection.Open();
                    SqlDataReader myReader = cmd.ExecuteReader();
                    while (myReader.Read())
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (SqlException e)
            {
                return false;
            }
        }

        public MovieConnector.Movie getMovieContent(int movieId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(@"SELECT * FROM movie WHERE id = @id");
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@id", movieId);
                    connection.Open();
                    SqlDataReader myReader = cmd.ExecuteReader();
                    while (myReader.Read())
                    {
                        return new MovieConnector.Movie(movieId, myReader["title"].ToString(), myReader["overview"].ToString(), Convert.ToDateTime(myReader["releaseDate"].ToString()),
                            Double.Parse(myReader["voteAverage"].ToString()), (byte[])myReader["image"], myReader["genre"].ToString(), Int32.Parse(myReader["runtime"].ToString()));
                    }
                }
                return null;
            }
            catch (SqlException e)
            {
                return null;
            }
        }

        public string deleteMovie(int movieId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(@"DELETE FROM movie WHERE id = @movieId");
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@movieId", movieId);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                return "Success for movie";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public List<MovieConnector.Movie> getAllMovies()
        {
            List<MovieConnector.Movie> movies = new List<MovieConnector.Movie>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(@"SELECT * FROM movie");
                    cmd.Connection = connection;
                    connection.Open();
                    SqlDataReader myReader = cmd.ExecuteReader();
                    while (myReader.Read())
                    {
                        movies.Add(new MovieConnector.Movie(Int32.Parse(myReader["id"].ToString()), myReader["title"].ToString(), myReader["overview"].ToString(), Convert.ToDateTime(myReader["releaseDate"].ToString()),
                            Double.Parse(myReader["voteAverage"].ToString()), (byte[])myReader["image"], myReader["genre"].ToString(), Int32.Parse(myReader["runtime"].ToString())));
                    }
                }
                return movies;
            }
            catch (SqlException e)
            {
                return null;
            }
        }

        public List<MovieConnector.Movie> getRecentMovies()
        {
            List<MovieConnector.Movie> movies = new List<MovieConnector.Movie>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(@"SELECT * FROM movie WHERE releaseDate >= '2016-11-14'");
                    cmd.Connection = connection;
                    connection.Open();
                    SqlDataReader myReader = cmd.ExecuteReader();
                    while (myReader.Read())
                    {
                        movies.Add(new MovieConnector.Movie(Int32.Parse(myReader["id"].ToString()), myReader["title"].ToString(), myReader["overview"].ToString(), Convert.ToDateTime(myReader["releaseDate"].ToString()),
                            Double.Parse(myReader["voteAverage"].ToString()), (byte[])myReader["image"], myReader["genre"].ToString(), Int32.Parse(myReader["runtime"].ToString())));
                    }
                }
                return movies;
            }
            catch (SqlException e)
            {
                return null;
            }
        }

        public MovieConnector.Movie insertToMovie(int id, string title, string overview,
            DateTime releaseDate, double voteAverage, string posterPath,
            string genre, int runtime)
        {
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(new Uri("http://image.tmdb.org/t/p/w185" + posterPath), @"1.jpg");
            }
            try {
                byte[] myFile;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (Stream inStream = File.Open(@"C: \Users\Majid\Desktop\C#\MovieDB\MovieDB\MovieDB\1.jpg", FileMode.Open))
                    {
                        myFile = new byte[inStream.Length];
                        for (int i = 0; i < inStream.Length; i++)
                            myFile[i] = ((byte)inStream.ReadByte());
                    }
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO movie (id, title, overview, releaseDate, voteAverage, image, genre, runtime) 
                    VALUES (@id, @title, @overview, @releaseDate, @voteAverage, @image, @genre, @runtime)");
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@overview", overview);
                    cmd.Parameters.AddWithValue("@releaseDate", releaseDate);
                    cmd.Parameters.AddWithValue("@voteAverage", voteAverage);
                    cmd.Parameters.AddWithValue("@image", myFile);
                    cmd.Parameters.AddWithValue("@genre", genre);
                    cmd.Parameters.AddWithValue("@runtime", runtime);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                return new MovieConnector.Movie(id, title, overview, releaseDate, voteAverage,
                myFile, genre, runtime);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public string insertToCast(int id, string character, string name, string profilePath)
        {
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(new Uri("http://image.tmdb.org/t/p/w185" + profilePath), @"2.jpg");
            }
            try
            {
                byte[] myFile;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (Stream inStream = File.Open(@"C: \Users\Majid\Desktop\C#\MovieDB\MovieDB\MovieDB\2.jpg", FileMode.Open))
                    {
                        myFile = new byte[inStream.Length];
                        for (int i = 0; i < inStream.Length; i++)
                            myFile[i] = ((byte)inStream.ReadByte());
                    }
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO cast (id, character, name, image) 
                    VALUES (@id, @character, @name, @image)");
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@character", character);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@image", myFile);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                return "Success for cast";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string insertToCast(int id, string character, string name, byte[] image)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO cast (id, character, name, image) 
                    VALUES (@id, @character, @name, @image)");
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@character", character);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@image", image);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                return "Success for cast";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public bool checkIfCastInDatabase(int castId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(@"SELECT id FROM cast WHERE id = @id");
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@id", castId);
                    connection.Open();
                    SqlDataReader myReader = cmd.ExecuteReader();
                    while (myReader.Read())
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (SqlException e)
            {
                return false;
            }
        }

        public MovieConnector.Cast getCastContent(int castId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(@"SELECT * FROM cast WHERE id = @id");
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@id", castId);
                    connection.Open();
                    SqlDataReader myReader = cmd.ExecuteReader();
                    while (myReader.Read())
                    {
                        return new MovieConnector.Cast(castId, myReader["character"].ToString(), myReader["name"].ToString(), (byte[])myReader["image"]);
                    }
                }
                return null;
            }
            catch (SqlException e)
            {
                return null;
            }
        }

        public string insertCastToMovie(int movieId, int castId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO movieCast (movieId, castId) 
                    VALUES (@movieId, @castId)");
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@movieId", movieId);
                    cmd.Parameters.AddWithValue("@castId", castId);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                return "Success for movieCast";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string deleteCastToMovie(int movieId, int castId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(@"DELETE FROM movieCast WHERE movieId = @movieId AND castId = @castId");
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@movieId", movieId);
                    cmd.Parameters.AddWithValue("@castId", castId);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                return "Success for movieCast";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string updateCast(int castId, string character, string name, byte[] image)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(@"UPDATE cast SET character = @character, name = @name, image = @image 
                    WHERE id = @id");
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@id", castId);
                    cmd.Parameters.AddWithValue("@character", character);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@image", image);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                return "Success for movieCast";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string deleteCast(int castId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(@"DELETE FROM cast WHERE id = @id");
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@id", castId);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                return "Success for movieCast";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public List<MovieConnector.Cast> getAllCastsForMovie(int movieId)
        {
            List<MovieConnector.Cast> casts = new List<MovieConnector.Cast>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(@"SELECT * FROM cast c
                                                        INNER JOIN movieCast mC
                                                        ON c.id = mC.castId 
                                                        INNER JOIN movie m 
                                                        ON mC.movieId = m.id 
                                                        WHERE m.id = @id");
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@id", movieId);
                    connection.Open();
                    SqlDataReader myReader = cmd.ExecuteReader();
                    while (myReader.Read())
                    {
                        casts.Add(new MovieConnector.Cast(Int32.Parse(myReader["id"].ToString()), myReader["character"].ToString(), myReader["name"].ToString(), (byte[])myReader["image"]));
                    }
                }
                return casts;
            }
            catch (SqlException e)
            {
                return null;
            }
        }
    }
}
