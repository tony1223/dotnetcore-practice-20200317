using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using dotnetcore_practice.EFModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dotnetcore_practice.Models;

namespace dotnetcore_practice.Controllers
{
    public class PostController : Controller
    {
        private readonly ILogger<PostController> _logger;
        private PracticeContext _practiceContext;
        public PostController(ILogger<PostController> logger, PracticeContext practiceContext)
        {
            _logger = logger;
            this._practiceContext = practiceContext;
        }

        public IActionResult Index()
        {
            var posts = _practiceContext.Posts.ToList();
            return View(posts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
