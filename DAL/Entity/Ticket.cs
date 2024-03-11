using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entity
{
    [Table("Ticket", Schema = "dbo")]
    public class Ticket
    {
        [Key]
        [Column("Ticket")]
        public int IdTicket { get; set; }


        [Required(ErrorMessage = "Le titre du  ticket est requis.")] 
        public string? Titre { get; set; }
        public DateTime DateCreation { get; set; }

        public DateTime HeureCreation { get; set; }

        public string? Commentaire { get; set; }

        [ForeignKey("Client")]
        [Column("IdClient")]
        public int IdClient { get; set; }

        [Required(ErrorMessage = "La priorité du ticket est requise.")]
        public string Priorite { get; set; }

        [Required(ErrorMessage = "Le client associé au ticket est requis.")]
        public Client Client { get; set; }
    }

}