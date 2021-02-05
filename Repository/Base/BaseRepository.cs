using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Access;
using Data.Base;
using Microsoft.EntityFrameworkCore;

namespace Repository.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly DataContext _Context;
        private DbSet<T> _Entities;
        public BaseRepository(DataContext Context)
        {
            _Context = Context;
            _Entities = _Context.Set<T>();
        }

        public void Delete(int toDelete)
        {
            _Entities.Remove(_Entities.SingleOrDefault(x => x.Id == toDelete));
            _Context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            if (_Entities.Count() == 0)
                throw new NullReferenceException();
            else
                return _Entities;
        }

        public T GetById(int toGetId)
        {
            if (toGetId <= 0)
                throw new ArgumentOutOfRangeException();
            else
                return _Entities.SingleOrDefault(x => x.Id == toGetId);
        }

        public T GetById()
        {
            throw new NotImplementedException();
        }

        public void Insert(T? toInsert)
        {
            if (toInsert == null)
                throw new ArgumentNullException();
            else
                _Entities.Add(toInsert);
            _Context.SaveChanges();
        }

        public void Update(T toUpdate)
        {
            throw new NotImplementedException();
        }
        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
