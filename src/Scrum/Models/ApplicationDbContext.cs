using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Scrum.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ProjectTool>()
                .HasKey(bi => new { bi.ProjectId, bi.ToolId });

            builder.Entity<ProjectTool>()
                .HasOne(bi => bi.Project)
                .WithMany(b => b.ProjectTools)
                .HasForeignKey(bi => bi.ProjectId);

            builder.Entity<ProjectTool>()
                .HasOne(bi => bi.Tool)
                .WithMany(b => b.ProjectTools)
                .HasForeignKey(bi => bi.ToolId);
            base.OnModelCreating(builder);
        }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Tool> Tools { get; set; }
        public virtual DbSet<Update> Updates { get; set; }
        public virtual DbSet<ToolType> ToolTypes { get; set; }
        public virtual DbSet<ProjectTool> ProjectTools { get; set; }
        public virtual DbSet<UserStory> UserStories { get; set; }
    }
}
