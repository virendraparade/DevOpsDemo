using DevOpsDemo.Models;
using System;
using System.Collections.Generic;
namespace DevOpsDemo.Repository
{
    public class PostRepository : IPostRepository
    {
        public List<PostViewModel> GetPosts()
        {
            List<PostViewModel> firstlist = new List<PostViewModel>();
            for (int i = 1; i <= 10000; i++) {
            var a= new PostViewModel() { PostId = 10+i, Title = "DevOps Demo Title1", Description = "DevOps Demo Description"+i, Author = "There is also a Blazor WebAssembly preview update available with this release, Daniel Roth, principal program manager for ASP.NET, said in announcing ASP.NET Core and Blazor updates in .NET Core 3.0 RC1. This update to Blazor WebAssembly still has a Preview 9 version, but carries an updated build number. This is not a release candidate for Blazor WebAssembly. Blazor WebAssembly isn't expected to ship as a stable release until some time after .NET Core 3.0 ships (details coming soon!)." };
                firstlist.Add(a);

            }

            return firstlist;
        }
    }
}