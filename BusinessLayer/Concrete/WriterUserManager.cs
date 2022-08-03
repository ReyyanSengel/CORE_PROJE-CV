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
    public class WriterUserManager : GenericService<WriterUser>, IWriterUserService
    {
        public WriterUserManager(IGenericRepository<WriterUser> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
