using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Configuration
{
    class TestimonialConfiguration : IEntityTypeConfiguration<Testimonial>
    {
        public void Configure(EntityTypeBuilder<Testimonial> builder)
        {
            builder.HasKey(x => x.TestimonialID);
            builder.Property(x => x.TestimonialID).UseIdentityColumn();
            builder.Property(x => x.ClientName).IsRequired().HasMaxLength(50);
        }
    }
}
