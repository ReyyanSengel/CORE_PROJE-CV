using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Configuration
{
    public class WriterMessageCongiguration : IEntityTypeConfiguration<WriterMessage>
    {
        public void Configure(EntityTypeBuilder<WriterMessage> builder)
        {
            builder.HasKey(x => x.WriterMessageID);
            builder.Property(x => x.WriterMessageID).UseIdentityColumn();
        }
    }
}
