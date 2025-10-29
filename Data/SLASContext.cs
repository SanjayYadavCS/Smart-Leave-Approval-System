using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;
using SLAS.Models.Entities;

namespace SLAS.Data;

public class SLASContext : IdentityDbContext<ApplicationUser,ApplicationRole,int>
{
    public SLASContext(DbContextOptions options) : base(options)
    {
    }

    protected SLASContext()
    {
    }

    public DbSet<Leave> Leaves { get; set; } = default!;
    public DbSet<LeaveAuditLog> LeaveAuditLogs { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //modelBuilder.Entity<Leave>().HasKey(m => m.Id);
        //modelBuilder.Entity<Leave>().Property(m => m.Id).ValueGeneratedOnAddOrUpdate();
        //modelBuilder.Entity<Leave>().Property(p => p.Reason).IsRequired().HasMaxLength(500);
        //modelBuilder.Entity<Leave>().Property(p => p.Comment).HasMaxLength(500);


        //modelBuilder.Entity<LeaveAuditLog>().HasKey(m => m.Id);
        //modelBuilder.Entity<LeaveAuditLog>().Property(m => m.Id).ValueGeneratedOnAddOrUpdate();
        //modelBuilder.Entity<LeaveAuditLog>().Property(p => p.Comment).HasMaxLength(500);
    }
}