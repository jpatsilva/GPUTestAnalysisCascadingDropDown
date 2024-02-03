using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace GPUTestAnalysisCascadingDropDown.Models
{
    public partial class dbContext : DbContext
    {
        public dbContext() 
        { 
        }

        public dbContext(DbContextOptions<dbContext> options)
            : base(options) 
        {
        }

        public virtual DbSet<GPU> GPUs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<GPU>(entity =>
            {
                entity.HasNoKey();

                // Todo: Not sure if the view statement is needed here
                // entity.ToView("GPU_TYPES")

                entity.Property(e => e.Type)
                .HasColumnType("VARCHAR")
                .HasMaxLength(15)
                .HasColumnName("GPU_Type");

                entity.Property(e => e.Parameter_Name)
                .HasColumnType("VARCHAR")
                .HasMaxLength(30)
                .HasColumnName("Metric_Parameter_Name");

                entity.Property(e => e.Expression)
                .HasColumnType("VARCHAR")
                .HasMaxLength(80)
                .HasColumnName("Metric_Expression");

                entity.Property(e => e.Description)
                .HasColumnType("VARCHAR")
                .HasMaxLength(500)
                .HasColumnName("Metric_Description");

            });
        }
    }
}
