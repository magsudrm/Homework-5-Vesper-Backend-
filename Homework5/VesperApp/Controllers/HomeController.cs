using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VesperApp.DAL;
using VesperApp.ViewModels;

namespace VesperApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly VesperDbContext _context;
        public HomeController(VesperDbContext context)
        {
                _context= context;
        }
        public IActionResult Index()
        {
            HomeViewModel viewModel = new HomeViewModel
            {
                TeamMembers = _context.TeamMembers.Include(x=>x.SocialMedias).ToList(),
                Services = _context.Services.ToList(),
                SocialMedias = _context.SocialMedias.Include(x => x.TeamMember).ToList()
            };
            return View(viewModel);
        }
    }
}
