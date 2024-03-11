using DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repos
{
    public class ClientRepository
    {
        public List<Client> All()
        {
            using (MyDbContext db = new MyDbContext())
            {
                return db.Clients.ToList();
            }
        }

        public void Create(Client entity)
        {
            using (MyDbContext db = new MyDbContext())
            {
                db.Clients.Add(entity);
                db.SaveChanges();
            }
        }

        public Client Read(int id)
        {
            using (MyDbContext db = new MyDbContext())
            {
                return db.Clients.Find(id);
            }
        }

        public void Update(Client entity)
        {
            using (MyDbContext db = new MyDbContext())
            {
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (MyDbContext db = new MyDbContext())
            {
                var entity = db.Clients.Find(id);
                if (entity != null)
                {
                    db.Clients.Remove(entity);
                    db.SaveChanges();
                }
            }
        }
    }
}