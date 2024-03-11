using System.ComponentModel.DataAnnotations;

namespace Models.Client;

public class ClientViewModel
{
    public int IdClient { get; set; }

    [Required(ErrorMessage = "Le nom du client est requis.")]
    public string NomClient { get; set; } = string.Empty;

    [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Le numéro de téléphone doit être composé de 10 chiffres.")]
    public string TelClient { get; set; } = string.Empty;

    [Required(ErrorMessage = "L'adresse e-mail du client est requise.")]
    [EmailAddress(ErrorMessage = "L'adresse e-mail n'est pas valide.")]
    public string EmailClient { get; set; } = string.Empty;
}