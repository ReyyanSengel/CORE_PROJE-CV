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
    public class FeatureManager : GenericService<Feature>, IFeatureService
    {
        public FeatureManager(IGenericRepository<Feature> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
