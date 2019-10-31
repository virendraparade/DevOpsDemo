using DevOpsDemo.Models;
using DevOpsDemo.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using ClosedXML.Excel;
using System.Collections.Generic;
using System.IO;
namespace DevOpsDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostRepository postRepository;

        public HomeController(IPostRepository _postRepository)
        {
            postRepository = _postRepository;
        }
        public IActionResult Index()
        {

            var model = postRepository.GetPosts();
            var workbook = new XLWorkbook();
            workbook.AddWorksheet("sheetName");
            var ws = workbook.Worksheet("sheetName");
            int row = 1;
            foreach (var c in model)
            {
                ws.Cell("A" + row.ToString()).Value = c.PostId;
                ws.Cell("B" + row.ToString()).Value = c.Title;
                ws.Cell("C" + row.ToString()).Value = c.Description;
                ws.Cell("D" + row.ToString()).Value = c.Author;
                row++;
            }

            MemoryStream stream = new MemoryStream();
            workbook.SaveAs(stream);
            return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Grid.xlsx");

        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None,
       NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id
           ?? HttpContext.TraceIdentifier
            });
        }
    }
}