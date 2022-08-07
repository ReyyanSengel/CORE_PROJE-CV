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
    public class TestimonialService : GenericService<Testimonial>, ITestimonialService
    {
        public TestimonialService(IGenericRepository<Testimonial> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
