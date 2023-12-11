using DAL.Abstract;
using Dapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DAL.Concrete
{
    public class PostRepository : IPostRepository
    {
        public void CreatePost(Post post)
        {
            string sql = "INSERT INTO Post (Author, Content) VALUES (@Author, @content)";
            
            using(var connection = new SqlConnection(DatabaseOptions.DatabaseConnectionString))
            {
                connection.Execute(sql, new { Author = post.Author, Content = post.Content });
            }
        }

        public IList<Post> GetPosts()
        {
            List<Post> posts;
            string sql = "SELECT * FROM Post WHERE Created >= DATEADD(day, -10, GETDATE()) ORDER BY Created DESC";

            using (var connection = new SqlConnection(DatabaseOptions.DatabaseConnectionString))
            {
                posts = connection.Query<Post>(sql).ToList();
            }

            return posts;
        }
    }
}
