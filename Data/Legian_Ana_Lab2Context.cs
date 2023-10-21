using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Legian_Ana_Lab2.Models;

namespace Legian_Ana_Lab2.Data
{
    public class Legian_Ana_Lab2Context : DbContext
    {
        public Legian_Ana_Lab2Context (DbContextOptions<Legian_Ana_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Legian_Ana_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Legian_Ana_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
