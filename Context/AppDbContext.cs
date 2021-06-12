using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiTelas.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiTelas.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        {

        }
        public DbSet<Tela> tela { get; set; }
    }
}
