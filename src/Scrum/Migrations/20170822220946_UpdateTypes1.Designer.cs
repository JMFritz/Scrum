using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Scrum.Models;

namespace Scrum.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170822220946_UpdateTypes1")]
    partial class UpdateTypes1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Scrum.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Scrum.Models.Phase", b =>
                {
                    b.Property<int>("PhaseId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("PhaseId");

                    b.ToTable("Phases");
                });

            modelBuilder.Entity("Scrum.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("Title");

                    b.Property<string>("userId");

                    b.HasKey("ProjectId");

                    b.HasIndex("userId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Scrum.Models.ProjectTool", b =>
                {
                    b.Property<int>("ProjectId");

                    b.Property<int>("ToolId");

                    b.HasKey("ProjectId", "ToolId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("ToolId");

                    b.ToTable("ProjectTools");
                });

            modelBuilder.Entity("Scrum.Models.Task", b =>
                {
                    b.Property<int>("TaskId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Complete");

                    b.Property<string>("Description");

                    b.Property<int>("PhaseId");

                    b.Property<int?>("ProjectId");

                    b.HasKey("TaskId");

                    b.HasIndex("PhaseId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("Scrum.Models.Tool", b =>
                {
                    b.Property<int>("ToolId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Documentation");

                    b.Property<string>("Name");

                    b.Property<int>("ToolTypeId");

                    b.HasKey("ToolId");

                    b.HasIndex("ToolTypeId");

                    b.ToTable("Tools");
                });

            modelBuilder.Entity("Scrum.Models.ToolType", b =>
                {
                    b.Property<int>("ToolTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ToolTypeId");

                    b.ToTable("ToolTypes");
                });

            modelBuilder.Entity("Scrum.Models.Update", b =>
                {
                    b.Property<int>("UpdateId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Note");

                    b.Property<int?>("ProjectId");

                    b.Property<DateTime>("TimeStamp");

                    b.Property<int>("UpdateTypeId");

                    b.Property<string>("UserId");

                    b.HasKey("UpdateId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("UpdateTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Updates");
                });

            modelBuilder.Entity("Scrum.Models.UpdateType", b =>
                {
                    b.Property<int>("UpdateTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("UpdateTypeId");

                    b.ToTable("UpdateTypes");
                });

            modelBuilder.Entity("Scrum.Models.UserStory", b =>
                {
                    b.Property<int>("UserStoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ProjectId");

                    b.Property<string>("Spec");

                    b.HasKey("UserStoryId");

                    b.HasIndex("ProjectId");

                    b.ToTable("UserStories");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Scrum.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Scrum.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Scrum.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Scrum.Models.Project", b =>
                {
                    b.HasOne("Scrum.Models.ApplicationUser", "user")
                        .WithMany()
                        .HasForeignKey("userId");
                });

            modelBuilder.Entity("Scrum.Models.ProjectTool", b =>
                {
                    b.HasOne("Scrum.Models.Project", "Project")
                        .WithMany("ProjectTools")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Scrum.Models.Tool", "Tool")
                        .WithMany("ProjectTools")
                        .HasForeignKey("ToolId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Scrum.Models.Task", b =>
                {
                    b.HasOne("Scrum.Models.Phase", "Phase")
                        .WithMany("Tasks")
                        .HasForeignKey("PhaseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Scrum.Models.Project", "Project")
                        .WithMany("Tasks")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("Scrum.Models.Tool", b =>
                {
                    b.HasOne("Scrum.Models.ToolType", "ToolType")
                        .WithMany("Tools")
                        .HasForeignKey("ToolTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Scrum.Models.Update", b =>
                {
                    b.HasOne("Scrum.Models.Project", "Project")
                        .WithMany("Updates")
                        .HasForeignKey("ProjectId");

                    b.HasOne("Scrum.Models.UpdateType", "UpdateType")
                        .WithMany("Updates")
                        .HasForeignKey("UpdateTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Scrum.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Scrum.Models.UserStory", b =>
                {
                    b.HasOne("Scrum.Models.Project", "Project")
                        .WithMany("UserStories")
                        .HasForeignKey("ProjectId");
                });
        }
    }
}
