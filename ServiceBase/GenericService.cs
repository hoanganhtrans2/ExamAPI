using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceBase;

namespace ServiceBase
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private IGenericRepository<T> repository = null;
        public GenericService(IGenericRepository<T> genericRepository)
        {
            this.repository = genericRepository;
        }
        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return repository.GetAll();
        }

        public T GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
