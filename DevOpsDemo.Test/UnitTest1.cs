using DevOpsDemo.Controllers;
using DevOpsDemo.Models;
using DevOpsDemo.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Xunit;


namespace DevOpsDemo.Test
{
    public class PostTestController
    {
        HomeController Home;
        IPostRepository PostRepository;
        public PostTestController()
        {
            PostRepository = new PostRepository();
            Home = new HomeController(PostRepository);
        }
        [Fact]
        public void Test_Index_View_Result()
        {

            //Act
            var a = 1;
            var result = Home.Index();
            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Test_Index_Return_Result()
        {
            //Arrange

            //Act
            var result = Home.Index();
            //Assert
            Assert.NotNull(result);
        }


    }
}
