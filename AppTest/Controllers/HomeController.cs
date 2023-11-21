using AppTest.Models;
using AppTest.Services;
using AppTest.Services.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json.Serialization;

namespace AppTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDataCollectionGenerator _dataGenerator;

        public HomeController(ILogger<HomeController> logger,
            IDataCollectionGenerator dataGenerator)
        {
            _logger = logger;
            _dataGenerator = dataGenerator;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> getData()
        {
            return Json(await _dataGenerator.GetData());
        }

        [HttpPost]
        public async Task<IActionResult> SaveData(List<DataCollectionGeneratorRequest> request) 
        {
            var req = await _dataGenerator.GetData();
            var status = await _dataGenerator.SaveData(req);

            return Json(new { status=true, });
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
