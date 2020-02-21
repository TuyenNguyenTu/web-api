using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppStep01.Models
{
    public class StudentManagementDbContext : DbContext
    {
        public StudentManagementDbContext(DbContextOptions<StudentManagementDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { set; get; }
        protected override void OnModelCreating(ModelBuilder model)
        {

        }
    }
}
