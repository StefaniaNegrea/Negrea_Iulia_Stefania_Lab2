using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Negrea_Iulia_Stefania_Lab2.Models;

namespace Negrea_Iulia_Stefania_Lab2.Data
{
    public class Negrea_Iulia_Stefania_Lab2Context : DbContext
    {
        public Negrea_Iulia_Stefania_Lab2Context (DbContextOptions<Negrea_Iulia_Stefania_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Negrea_Iulia_Stefania_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Negrea_Iulia_Stefania_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
