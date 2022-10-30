using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dobra_Denis_Lab2.Models;

namespace Dobra_Denis_Lab2.Data
{
    public class Dobra_Denis_Lab2Context : DbContext
    {
        public Dobra_Denis_Lab2Context (DbContextOptions<Dobra_Denis_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Dobra_Denis_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Dobra_Denis_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Dobra_Denis_Lab2.Models.Author> Author { get; set; }
    }
}
