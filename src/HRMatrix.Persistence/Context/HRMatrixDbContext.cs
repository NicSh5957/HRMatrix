using HRMatrix.IdentityService.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HRMatrix.Persistence.Contexts
{
    public class HRMatrixDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int, ApplicationUserClaim, ApplicationUserRole, ApplicationUserLogin, ApplicationRoleClaim, ApplicationUserToken>
    {
        public HRMatrixDbContext(DbContextOptions<HRMatrixDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(HRMatrixDbContext).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationUser).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
