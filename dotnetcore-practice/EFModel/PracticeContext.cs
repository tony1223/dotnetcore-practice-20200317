using System.Linq;
using dotnetcore_practice.EFModel.Practice;
using Microsoft.EntityFrameworkCore;

namespace dotnetcore_practice.EFModel
{
    public class PracticeContext : DbContext
    {
        public virtual DbSet<Post> Posts { get; set; }


        public PracticeContext()
        {
            this.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public PracticeContext(DbContextOptions<PracticeContext> options)
            : base(options)
        {
            this.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

    }

}
