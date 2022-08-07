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
    public class SocialMediaService : GenericService<SocialMedia>, ISocialMediaService
    {
        public SocialMediaService(IGenericRepository<SocialMedia> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
