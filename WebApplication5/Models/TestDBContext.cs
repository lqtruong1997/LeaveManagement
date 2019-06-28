using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication5.Models
{
    public partial class TestDBContext : DbContext
    {
        public virtual DbSet<LeaveRequests> LeaveRequests { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<LeaveTypes> LeaveTypes { get; set; }
        public virtual DbSet<Holiday> Holiday { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TestDB;Data Source=VNMPCTRLE;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LeaveRequests>().ToTable("LeaveRequests");
            modelBuilder.Entity<Users>().ToTable("Users");
            modelBuilder.Entity<LeaveTypes>().ToTable("LeaveTypes");
            modelBuilder.Entity<Holiday>().ToTable("Holiday");
        }
    }
}
