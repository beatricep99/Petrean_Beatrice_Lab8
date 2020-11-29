using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Petrean_Beatrice_Lab8.Models;

namespace Petrean_Beatrice_Lab8.Data
{
    public class Petrean_Beatrice_Lab8Context : DbContext
    {
        public Petrean_Beatrice_Lab8Context (DbContextOptions<Petrean_Beatrice_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Petrean_Beatrice_Lab8.Models.Book> Book { get; set; }

        public DbSet<Petrean_Beatrice_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Petrean_Beatrice_Lab8.Models.Category> Category { get; set; }
    }
}
