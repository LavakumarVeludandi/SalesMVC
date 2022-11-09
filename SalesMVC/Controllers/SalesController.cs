using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class SalesController: Controller
	{
        private readonly ILogger<HomeController> _logger;

        private static List<SalesAgentViewModel> salesAgents = new List<SalesAgentViewModel>();

        public SalesController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Agents()
        {
            return View(salesAgents);
        }

        public IActionResult Create()
        {
            SalesAgentViewModel salesAgentViewModel = new SalesAgentViewModel();
            return View(salesAgentViewModel );
        }

        public IActionResult CreateAgent(SalesAgentViewModel salesAgentViewModel)
        {
            salesAgents.Add(salesAgentViewModel);
            return RedirectToAction(nameof(Agents));
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}