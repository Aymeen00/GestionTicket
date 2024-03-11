using System;
using System.ComponentModel.DataAnnotations;

namespace Models.Ticket;

public class TicketViewModel
{
    [Key]
    public int IdTicket { get; set; }

    public string Titre { get; set; }
    public DateTime DateCreation { get; set; }

    public DateTime HeureCreation { get; set; }
    public int IdClient { get; set; }
    public string Commentaire { get; set; } = string.Empty;

    [Required(ErrorMessage = "La priorité du ticket est requise.")]
    public string Priorite { get; set; } = string.Empty;

}