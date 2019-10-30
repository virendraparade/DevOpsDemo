using DevOpsDemo.Models;
using System.Collections.Generic;
namespace DevOpsDemo.Repository
{
    public class PostRepository : IPostRepository
    {
        public List<PostViewModel> GetPosts()
        {
            List<PostViewModel> firstlist = new List<PostViewModel>();
            PostViewModel p1 = new PostViewModel() { PostId = 101, Title = "DevOps Demo Title1", Description = "DevOps Demo Description 1", Author = "Mukesh Kumar1" };
            PostViewModel p2 = new PostViewModel() { PostId = 102, Title = "DevOps Demo Title2", Description = "DevOps Demo Description 2", Author = "Mukesh Kumar2" };
            PostViewModel p3 = new PostViewModel() { PostId = 103, Title = "DevOps Demo Title3", Description = "DevOps Demo Description 3", Author = "Mukesh Kumar3" };
            PostViewModel p4 = new PostViewModel() { PostId = 104, Title = "DevOps Demo Title4", Description = "DevOps Demo Description 4", Author = "Mukesh Kumar4" };
            PostViewModel p5 = new PostViewModel() { PostId = 105, Title = "DevOps Demo Title5", Description = "DevOps Demo Description 5", Author = "Mukesh Kumar5" };
            firstlist.Add(p1);
            firstlist.Add(p2);
            firstlist.Add(p3);
            firstlist.Add(p4);
            firstlist.Add(p5);

            return firstlist;
        }
    }
}