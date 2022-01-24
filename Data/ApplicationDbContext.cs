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

        public DbSet<Course> Courses;
        public DbSet<DoW> Dows;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<DoW>().HasKey(d => d.Id);

            builder.Entity<Course>().HasKey(c => c.Id);
            builder.Entity<Course>().Ignore(c => c.StartingDate);
            builder.Entity<Course>().Ignore(c => c.EndingDate);
            builder.Entity<Course>().Ignore(c => c.StartingTime);
            builder.Entity<Course>().HasMany(c => c.DayOfWeek)
                .WithMany(d => d.Courses);

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