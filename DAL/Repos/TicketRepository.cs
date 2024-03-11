using System.Collections.Generic;
using DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repos
{
    public class TicketRepository
    {
        public List<Ticket> GetAllTickets()
        {
            MyDbContext dbContext = new MyDbContext();
            return dbContext.Tickets.ToList();
      
        }

        public void Create(Ticket entity)
        {
            using (MyDbContext db = new MyDbContext())
            {
                db.Tickets.Add(entity);
                db.SaveChanges();
            }
        }

        public Ticket Read(int id)
        {
            using (MyDbContext db = new MyDbContext())
            {
                return db.Tickets.Find(id);
            }
        }

        public void Update(Ticket entity)
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
                var entity = db.Tickets.Find(id);
                if (entity != null)
                {
                    db.Tickets.Remove(entity);
                    db.SaveChanges();
                }
            }
        }
    }
}