using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entity
{
    [Table("Agent", Schema = "dbo")]
    public class Agent
    {
        [Key]
        [Column("Agent")]
        public int IdAgent { get; set; }

        [Required(ErrorMessage = "Le nom de l'agent est requis.")]
        [StringLength(50, ErrorMessage = "La longueur maximale du nom est de 50 caractères.")]
        public string NomAgent { get; set; }

        [StringLength(50, ErrorMessage = "La longueur maximale du poste est de 50 caractères.")]
        public string PosteAgent { get; set; }

        [Required(ErrorMessage = "Le mot de passe est requis.")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "La longueur du mot de passe doit être comprise entre 6 et 100 caractères.")]
        public string MotDePasse { get; set; }
    }
}