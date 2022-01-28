using CourseManagement.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CourseManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<DoW> Dows { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Teacher>().HasKey(t => t.Id);
            builder.Entity<Student>().HasKey(s => s.Id);

            builder.Entity<DoW>().HasKey(d => d.Id);

            builder.Entity<Course>().HasKey(c => c.Id);
            builder.Entity<Course>().Ignore(c => c.StartingDate);
            builder.Entity<Course>().Ignore(c => c.EndingDate);
            builder.Entity<Course>().Ignore(c => c.StartingTime);
            builder.Entity<Course>().HasMany(c => c.DayOfWeek)
                .WithMany(d => d.Courses);
            builder.Entity<Course>().HasMany(c => c.Students)
                .WithMany(s => s.Courses);
            builder.Entity<Course>().HasOne(c => c.Teacher)
                .WithMany(t => t.Courses);

            builder.Entity<DoW>().HasData
            (
                new DoW[]
                {
                    new DoW{Id = 1, DayOfWeek = DayOfWeek.Monday },
                    new DoW{Id = 2, DayOfWeek = DayOfWeek.Tuesday },
                    new DoW{Id = 3, DayOfWeek = DayOfWeek.Wednesday },
                    new DoW{Id = 4, DayOfWeek = DayOfWeek.Thursday },
                    new DoW{Id = 5, DayOfWeek = DayOfWeek.Friday },
                    new DoW{Id = 6, DayOfWeek = DayOfWeek.Saturday },
                    new DoW{Id = 7, DayOfWeek = DayOfWeek.Sunday }
                }
            );
        }
    }
}