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
    internal class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasKey(x => x.ContactID);
            builder.Property(x => x.ContactID).UseIdentityColumn();
            builder.Property(x => x.Mail).IsRequired();
            builder.Property(x => x.Phone).IsRequired().HasMaxLength(11);
        }
    }
}
