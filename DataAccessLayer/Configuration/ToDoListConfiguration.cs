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
    class ToDoListConfiguration : IEntityTypeConfiguration<ToDoList>
    {
        public void Configure(EntityTypeBuilder<ToDoList> builder)
        {
            builder.HasKey(x => x.ToDoListID);
            builder.Property(x => x.ToDoListID).UseIdentityColumn();
        }
    }
}
