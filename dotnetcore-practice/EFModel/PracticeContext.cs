using dotnetcore_practice.EFModel.Practice;
using Microsoft.EntityFrameworkCore;

namespace dotnetcore_practice.EFModel
{
    public class PracticeContext : DbContext
    {
        public virtual DbSet<Post> Posts { get; set; }
        
    }
}
