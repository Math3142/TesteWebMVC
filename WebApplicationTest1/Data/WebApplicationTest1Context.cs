using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationTest1.Models
{
    public class WebApplicationTest1Context : DbContext
    {
        public WebApplicationTest1Context (DbContextOptions<WebApplicationTest1Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationTest1.Models.Conhecimento> Conhecimento { get; set; }
    }
}
