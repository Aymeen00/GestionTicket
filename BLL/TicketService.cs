using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repos;
namespace BLL
{
    public class TicketService
    {
        private readonly TicketRepository _ticketRepository;

        public TicketService(TicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public List<Models.Ticket.TicketViewModel> GetTicketList()
        {
            List<Models.Ticket.TicketViewModel> ticketList = new List<Models.Ticket.TicketViewModel>();

            // Récupérer la liste des tickets à partir du référentiel
            var tickets = _ticketRepository.GetAllTickets();

            // Convertir les tickets en TicketViewModel
            foreach (var ticket in tickets)
            {
                Models.Ticket.TicketViewModel ticketViewModel = new Models.Ticket.TicketViewModel
                {
                    // Affecter les propriétés du ticket au ViewModel
                    // (ID, Date, Description, etc.)
                };
                ticketList.Add(ticketViewModel);
            }

            return ticketList;
        }
    }
}

