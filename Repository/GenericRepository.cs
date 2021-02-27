using DAL;
using InterfaceBase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private ExamDBEntities _context = null;
        private DbSet<T> table = null;
        public GenericRepository()
        {
            _context = new ExamDBEntities();
            table = _context.Set<T>();
        }
        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object id)
        {
            return table.Find(id);
        }

        public void Insert(T obj)
        {
            table.Add(obj);
            _context.SaveChanges();
        }

        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
