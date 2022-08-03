using CORE_PROJE_API.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_PROJE_API.DAL.ApiContext
{
    public class Context : DbContext
    {
        public Context( DbContextOptions<Context> options) : base(options)
        {
        }


        public DbSet<Category> Categories { get; set; }
    }
}
