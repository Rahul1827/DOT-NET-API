
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CodeFirstApproach.Models
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
