using Microsoft.EntityFrameworkCore;
using Peek_n_Pick.DAL.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peek_n_Pick.DAL.Peek_n_PickDbContext
{
    public class Peek_n_PickDbContext : DbContext
    {
        public Peek_n_PickDbContext(DbContextOptions<Peek_n_PickDbContext> options) : base(options)
        {

        }
        public DbSet<Photography> Photographies { get; set; }
    }
}
