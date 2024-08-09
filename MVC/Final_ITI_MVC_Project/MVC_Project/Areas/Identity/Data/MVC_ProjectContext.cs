using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_Project.Areas.Identity.Data;

namespace MVC_Project.Areas.Identity.Data;

public class MVC_ProjectContext : IdentityDbContext<MVC_ProjectUser>
{
    public MVC_ProjectContext(DbContextOptions<MVC_ProjectContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
    }
}

public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<MVC_ProjectUser>
{
    public void Configure(EntityTypeBuilder<MVC_ProjectUser> builder)
    {
        builder.Property(n => n.FristName).HasMaxLength(100);
        builder.Property(n => n.LastName).HasMaxLength(100);
    }
}
