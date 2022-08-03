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
    internal class AboutConfiguration : IEntityTypeConfiguration<About>
    {
        public void Configure(EntityTypeBuilder<About> builder)
        {
            builder.HasKey(x => x.AboutID);
            builder.Property(x => x.AboutID).UseIdentityColumn();
            builder.Property(x => x.Mail).IsRequired();
            builder.Property(x => x.Phone).IsRequired().HasMaxLength(11);
        }
    }
}
