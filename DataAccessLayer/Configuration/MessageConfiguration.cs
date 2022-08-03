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
    internal class MessegeConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.HasKey(x => x.MessageID);
            builder.Property(x => x.MessageID).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Mail).IsRequired();
            builder.Property(x => x.Content).IsRequired();
        }
    }
}
