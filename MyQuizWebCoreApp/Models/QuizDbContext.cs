using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyQuizWebCoreApp.Models
{
    public class QuizDbContext : DbContext
    {
        public QuizDbContext (DbContextOptions<QuizDbContext> options) : base(options) { }

        public DbSet<Question> Questions { get; set; }
    }
}
