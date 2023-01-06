using ETrade.Business.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Business.Concrete
{
    public class GenericRepository<Tentity, Tcontext> : IGenericRepository<Tentity>
        where Tentity : class,new() 
        where Tcontext : DbContext, new()
    {
        public void Add(Tentity entity)
        {
            //using (var db = new Tcontext())
            //{
            //    db.Set(entity).State = EntityState.Detached;
            //    db.SaveChanges();
            //} tamamlaaaa eksik
        }

        public void Delete(int id)
        {
            using (var db = new Tcontext())
            {
                var tentity = db.Set<Tentity>().Find(id);   
                db.Set<Tentity>().Remove(tentity);  
                db.SaveChanges();   
            }
        }

        public void Delete(Tentity entity)
        {
            using (var db = new Tcontext())
            {
               db.Entry(entity).State= EntityState.Detached;  
                db.SaveChanges();
            }
        }

        public Tentity Get(int id)
        {
            using (var db = new Tcontext())
            {
                var entity =db.Set<Tentity>().Find(id);
                return entity;

            }
        }
        public Tentity Get(Expression<Func<Tentity, bool>> filter)
        {
            using (var db = new Tcontext())
            {
                var entity = db.Set<Tentity>().Find(filter);
                return entity;
            }
        }
        public List<Tentity> GetAll(Expression<Func<Tentity, bool>> filter = null)
        {
            using (var db = new Tcontext())
            {
               return filter == null ? db.Set<Tentity>().ToList
                    ():db.Set<Tentity>().Where(filter).ToList();
                // Kullanım mantığı çok basit Şart ? İf Blogu : Else Bloğu. Lafı çok uzatmadan kullanımına geçeyim.
            }
        }

        public void Update(Tentity entity)
        {
            using (var db = new Tcontext())
            {
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
