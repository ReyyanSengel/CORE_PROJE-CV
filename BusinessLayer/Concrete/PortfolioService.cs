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
    public class PortfolioService : GenericService<Portfolio>, IPortfolioService
    {
        public PortfolioService(IGenericRepository<Portfolio> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
