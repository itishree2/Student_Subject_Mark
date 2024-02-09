using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppStudent_Marks.Models;

namespace WebAppStudent_Marks.Data
{
    public class Student_MarksContext : DbContext
    {
        public Student_MarksContext (DbContextOptions<Student_MarksContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppStudent_Marks.Models.Student> Student { get; set; } = default!;
    }
}
