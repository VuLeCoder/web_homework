using Microsoft.EntityFrameworkCore;
using Lab5.Models;

namespace Lab5.Data;

public class SchoolContext: DbContext
{
    public SchoolContext(DbContextOptions<SchoolContext> options) : base(options) { }

    public DbSet<Major> Majors { get; set; }
    public DbSet<Learner> Learners { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Major>().HasData(
            new Major { MajorID = 1, MajorName = "IT" },
            new Major { MajorID = 2, MajorName = "Economics" },
            new Major { MajorID = 3, MajorName = "Mathematics" }
        );

        modelBuilder.Entity<Learner>().HasData(
            new Learner { LearnerID = 1, FirstMidName = "Carson", LastName = "Alexander", EnrollmentDate = DateTime.Parse("2005-09-01"), MajorID = 1 },
            new Learner { LearnerID = 2, FirstMidName = "Meredith", LastName = "Alonso", EnrollmentDate = DateTime.Parse("2002-09-01"), MajorID = 2 }
        );
    }
}