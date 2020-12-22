using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APIClient.Models;

namespace APIClient.Data
{
    public class APIClientContext : DbContext
    {
        public APIClientContext (DbContextOptions<APIClientContext> options)
            : base(options)
        {
        }

        public DbSet<APIClient.Models.Client> Client { get; set; }
    }
}
