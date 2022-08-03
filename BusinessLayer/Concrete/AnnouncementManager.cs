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
    public class AnnouncementManager : GenericService<Announcement>, IAnnouncementService
    {
        public AnnouncementManager(IGenericRepository<Announcement> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
