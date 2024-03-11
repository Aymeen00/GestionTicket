using Microsoft.AspNetCore.Mvc;
using Models.Client;
namespace Admin.Controllers
{
    public class ClientController : Controller
    {
        // Action pour afficher la liste des clients
        public IActionResult Index()
        {
            // Utilisez vos services BLL pour récupérer la liste des clients depuis la base de données
            var clients = new List<ClientViewModel>(); // Remplacez ceci par votre logique de récupération de données
            return View(clients);
        }

        // Action pour afficher le formulaire de création d'un nouveau client
        public IActionResult Create()
        {
            return View();
        }

        // Action pour traiter la soumission du formulaire de création d'un nouveau client
        [HttpPost]
        public IActionResult Create(ClientViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Utilisez vos services BLL pour enregistrer le nouveau client dans la base de données
                // Exemple : clientService.Create(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // Autres actions pour afficher, mettre à jour et supprimer des clients
    }
}
