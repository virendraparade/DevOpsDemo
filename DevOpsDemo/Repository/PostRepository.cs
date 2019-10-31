using DevOpsDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevOpsDemo.Repository
{
    public class PostRepository : IPostRepository
    {
        public List<PostViewModel> GetPosts()
        {
            List<PostViewModel> firstlist = new List<PostViewModel>();
            for (int i = 1; i <= 10000; i++)
            {
                var a= new PostViewModel() { PostId = Guid.NewGuid(), Title = RandomString(4)+"-"+RandomString(4) + "-"+ RandomString(4) + "-"+ RandomString(4), Description = RandomString(6) + "-" + RandomString(6) + "-" + RandomString(6) + "-" + RandomString(6), Author = RandomString(5) + "-" + RandomString(5) + "-" + RandomString(5) + "-" + RandomString(5) };
                firstlist.Add(a);

            }

            return firstlist;
        }
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}