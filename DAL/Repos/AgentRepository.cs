using System.Collections.Generic;
using DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repos
{
    public class AgentRepository
    {
        public List<Agent> All()
        {
            using (MyDbContext db = new MyDbContext())
            {
                return db.Agents.ToList();
            }
        }

        public void Create(Agent entity)
        {
            using (MyDbContext db = new MyDbContext())
            {
                db.Agents.Add(entity);
                db.SaveChanges();
            }
        }

        public Agent Read(int id)
        {
            using (MyDbContext db = new MyDbContext())
            {
                return db.Agents.Find(id);
            }
        }

        public void Update(Agent entity)
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
                var entity = db.Agents.Find(id);
                if (entity != null)
                {
                    db.Agents.Remove(entity);
                    db.SaveChanges();
                }
            }
        }
    }
}