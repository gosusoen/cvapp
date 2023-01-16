using CvApp.Models;
using CvApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CvApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IDataRepository _repo;
        public HomeController(ILogger<HomeController> logger, IDataRepository repo)
        {
            _repo = repo;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Create(CvModel model)
        {

            return View();
        }

        public async Task<IActionResult> Edit(int id)
        {
            CvModel model = await _repo.GetCvModel(id);
            return View(model);
        }

        public async Task<IActionResult> Edit(CvModel model)
        {
            await _repo.EditCv(model);
            return View(model);
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