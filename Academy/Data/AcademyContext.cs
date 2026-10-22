using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Models;

namespace Academy.Data
{
    public class AcademyContext : DbContext
    {
        public AcademyContext (DbContextOptions<AcademyContext> options)
            : base(options)
        {
        }

        public DbSet<ContosoUniversity.Models.Student> Student { get; set; } = default!;
    }
}
