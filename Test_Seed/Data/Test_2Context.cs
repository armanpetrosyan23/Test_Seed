using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Seed.Data
{
    public class Test_2Context:DbContext
    {

        public Test_2Context(DbContextOptions<Test_2Context> options):base(options)
        {

        }
        public DbSet<Order> Orders { get; set; }

    }

}
