using Microsoft.AspNetCore.Mvc;
using Models;

using DAL.Repos;
namespace Controllers
{
    public class TicketController : Controller
    {
        private readonly TicketRepository _ticketRepo;

        public TicketController(TicketRepository ticketRepo)
        {
            _ticketRepo = ticketRepo;
        }

        public IActionResult ListeTickets()
        {
            var tickets = _ticketRepo.GetAllTickets();
            return View(tickets);
        }
        public IActionResult Creer()
        {
            return View();
        }

        // Autres actions pour créer, éditer, supprimer des tickets...
    }
}
