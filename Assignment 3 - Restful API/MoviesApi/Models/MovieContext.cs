using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace MoviesApi.Models
{
    public class MovieContext
    {
        public string ConnectionString { get; set; }

        public MovieContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<MovieItem> GetAllMovie()
        {
            List<MovieItem> list = new List<MovieItem>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_movie", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MovieItem()
                        {
                            id = reader.GetInt32("id"),
                            name = reader.GetString("name"),
                            genre = reader.GetString("genre"),
                            duration = reader.GetString("duration"),
                            releaseDate = reader.GetString("release_date")
                        });
                    }
                }
            }
            return list;
        }

        public string PostMovieItem(MovieItem movie)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("insert into tb_movie(name, genre, duration, release_date) values(@name, @genre, @duration, @releaseDate)", conn))
                {
                    cmd.Parameters.AddWithValue("@name", movie.name);
                    cmd.Parameters.AddWithValue("@genre", movie.genre);
                    cmd.Parameters.AddWithValue("@duration", movie.duration);
                    cmd.Parameters.AddWithValue("@releaseDate", movie.releaseDate);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            return "success";
        }

        public string UpdateMovieItem(int id, MovieItem movie)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("update tb_movie set name=@name, genre=@genre, duration=@duration, release_date=@releaseDate where id=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@name", movie.name);
                    cmd.Parameters.AddWithValue("@genre", movie.genre);
                    cmd.Parameters.AddWithValue("@duration", movie.duration);
                    cmd.Parameters.AddWithValue("@releaseDate", movie.releaseDate);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            return "success";
        }

        public string DeleteMovieItem(int id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("delete from tb_movie where id=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            return "success";
        }

        public List<MovieItem> GetMovie(int id)
        {
            List<MovieItem> list = new List<MovieItem>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_movie WHERE id =@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MovieItem()
                        {
                            id = reader.GetInt32("id"),
                            name = reader.GetString("name"),
                            genre = reader.GetString("genre"),
                            duration = reader.GetString("duration"),
                            releaseDate = reader.GetString("release_date"),
                        });
                    }
                }
            }
            return list;
        }
    }
}