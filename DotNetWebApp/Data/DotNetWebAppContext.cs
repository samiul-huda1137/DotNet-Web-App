using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DotNetWebApp.Models;

namespace DotNetWebApp.Data
{
    public class DotNetWebAppContext : DbContext
    {
        public DotNetWebAppContext (DbContextOptions<DotNetWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<DotNetWebApp.Models.Riddle> Riddle { get; set; } = default!;
    }
}
