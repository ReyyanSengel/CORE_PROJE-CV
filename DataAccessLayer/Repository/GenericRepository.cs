using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly Context _context;
        

      

        public GenericRepository(Context context)
        {
            _context = context;
           
        }

        public void Delete(T t)
        {
            _context.Set<T>().Remove(t);
           
        }

       
        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return _context.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            _context.Set<T>().Add(t);
           
        }

        public void Update(T t)
        {
            _context.Set<T>().Update(t);
            
        }
    }
}
 