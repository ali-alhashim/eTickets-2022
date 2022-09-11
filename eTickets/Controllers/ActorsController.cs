using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorService _service;

        public ActorsController(IActorService service)
            {
            _service = service;
            }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }

        //get : Actors/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("FullName", "ProfilePictureURL", "Bio")]Actor actor)
        {
            if(!ModelState.IsValid)
            {
                var errors = ModelState.SelectMany(x => x.Value.Errors.Select(z => z.Exception));
                Console.WriteLine(errors);
                return View(actor);
                
            }
            _service.Add(actor);
            return RedirectToAction(nameof(Index));
        }
    }
}
