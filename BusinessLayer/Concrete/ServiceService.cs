using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ServiceService : GenericService<Service>, IServiceService
    {
        public ServiceService(IGenericRepository<Service> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
