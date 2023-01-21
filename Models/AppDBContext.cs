using Microsoft.EntityFrameworkCore;
namespace C2CPortal.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }
        public DbSet<CollegeRegistration> CollegeRegistration { get; set; }
        public DbSet<CompanyRegistration> CompanyRegistration { get; set; }
        public DbSet<StudentDetails> StudentDetails { get; set; }
        public DbSet<RecruitmentDetails> RecruitmentDetails { get; set; }
        public DbSet<StudentEligibility> StudentEligibility { get; set; }
        public DbSet<RecruitmentPost> RecruitmentPost { get; set; }
    }
}
