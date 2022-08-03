using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private readonly IGenericRepository<T> _repository;
        private readonly IUnitOfWork _unitOfWork;
       
        public GenericService(IGenericRepository<T> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            
        }


        public void TAdd(T t)
        {
            _repository.Insert(t);
            _unitOfWork.Commit();
        }

        public void TDelete(T t)
        {
            _repository.Delete(t);
            _unitOfWork.Commit();
        }

              
        public T TGetById(int id)
        {
          return  _repository.GetById(id);
            
        }

        public List<T> TGetList()
        {
            return _repository.GetList();
        }

        public void TUpdate(T t)
        {
            _repository.Update(t);
            _unitOfWork.Commit();
        }

       
    }
}
