using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MoviesApp.Models
{
    public class MoviesContext
    {
        public string ConnectionString { get; set; }

        public MoviesContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<ItemData> GetAllMovies()
        {
            List<ItemData> list = new List<ItemData>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM data_movies", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new ItemData()
                        {
                            Id = reader.GetInt32("id"),
                            Name = reader.GetString("Name"),
                            Genre = reader.GetString("Genre"),
                            Duration = reader.GetString("Duration"),
                            ReleaseDate = reader.GetString("ReleaseDate")
                        });
                    }
                }
            }
            return list;
        }

        public List<ItemData> GetMoviesById(int id)
        {
            List<ItemData> list = new List<ItemData>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM data_movies where id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new ItemData()
                        {
                            Id = reader.GetInt32("id"),
                            Name = reader.GetString("Name"),
                            Genre = reader.GetString("Genre"),
                            Duration = reader.GetString("Duration"),
                            ReleaseDate = reader.GetString("ReleaseDate")
                        });
                    }
                }
            }
            return list;
        }

        public void InsertMovie(ItemData movie)
        {
            List<ItemData> list = new List<ItemData>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO data_movies(Name, Genre, Duration, ReleaseDate) VALUES(@name,@genre,@duration,@releasedate)", conn))
                    {
                        cmd.Parameters.AddWithValue("@name", movie.Name);
                        cmd.Parameters.AddWithValue("@genre", movie.Genre);
                        cmd.Parameters.AddWithValue("@duration", movie.Duration);
                        cmd.Parameters.AddWithValue("@releasedate", movie.ReleaseDate);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                   
                }
                catch 
                {
                    
                }
            }
        }
        public void UpdateMovie(int id, ItemData movie)
        {
            List<ItemData> list = new List<ItemData>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand("UPDATE data_movies SET Name = @name, Genre = @genre, Duration = @duration, ReleaseDate = @releasedate where id = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@name", movie.Name);
                        cmd.Parameters.AddWithValue("@genre", movie.Genre);
                        cmd.Parameters.AddWithValue("@duration", movie.Duration);
                        cmd.Parameters.AddWithValue("@releasedate", movie.ReleaseDate);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                }
                catch
                {

                }
            }
        }
        public void DeleteMovie(int id)
        {
            List<ItemData> list = new List<ItemData>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand("DELETE FROM data_movies where id=@id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                }
                catch
                {

                }
            }
        }

    }
}