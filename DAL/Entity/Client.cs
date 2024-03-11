using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entity
{
    [Table("Client", Schema = "dbo")]
    public class Client
    {
        [Key]
        [Column("Client")]
        public int IdClient { get; set; }

        [StringLength(50, ErrorMessage = "La longueur maximale du nom est de 50 caractères.")]
        public string NomClient { get; set; }


        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Le numéro de téléphone doit être composé de 10 chiffres.")]
        public string TelClient { get; set; }

        [EmailAddress(ErrorMessage = "L'adresse e-mail n'est pas valide.")]
        public string EmailClient { get; set; }
    }
}
 