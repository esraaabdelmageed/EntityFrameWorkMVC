using EntityFrameWorkMVC1.Models;
using Microsoft.EntityFrameworkCore;
namespace EntityFrameWorkMVC1.Context
{
    public class CompanyContext:DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options) 
        {
        }

        public virtual DbSet<Company> Company { get; set; } //tables in the database-->more than one record //virtual added so if i wanted to override
    }
}
