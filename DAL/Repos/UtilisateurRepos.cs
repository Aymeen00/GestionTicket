using System.Linq;
using DAL.Entity;

namespace DAL.Repos
{
    public class UtilisateurRepos
    {
        private readonly MyDbContext _dbContext;

        public UtilisateurRepos(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Méthode pour obtenir un agent en fonction de ses identifiants
        public Agent GetAgentByCredentials(string compte, string motPasse)
        {
            return _dbContext.Agents.FirstOrDefault(a => a.NomAgent == compte && a.MotDePasse == motPasse);
        }
    }
}
