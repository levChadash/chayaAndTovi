using System;
using System.Threading.Tasks;
using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DL
{
    public partial class DonationManagementContext : DbContext
    {
        public DonationManagementContext()
        {
        }

        public DonationManagementContext(DbContextOptions<DonationManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Donor> Donors { get; set; }
        public virtual DbSet<DonorsVisit> DonorsVisits { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<Massage> Massages { get; set; }
        public virtual DbSet<Raise> Raises { get; set; }
        public virtual DbSet<RaisesInGroup> RaisesInGroups { get; set; }
        public virtual DbSet<RisingVisit> RisingVisits { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<Time> Times { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=srv2\\pupils;Database=DonationManagement;Trusted_Connection=True;");
            }
        }

        internal Task RemoveAsync(Raise raise)
        {
            throw new NotImplementedException();
        }

        internal Task RemoveAsync(Donor d)
        {
            throw new NotImplementedException();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Hebrew_CI_AS");

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.Property(e => e.ContactType).IsRequired();
            });

            modelBuilder.Entity<Donor>(entity =>
            {
                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Degree).HasDefaultValueSql("((1))");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Donors)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_Donors_Contacts");
            });

            modelBuilder.Entity<DonorsVisit>(entity =>
            {
                entity.ToTable("DonorsVisit");

                entity.Property(e => e.VisitingTime).HasColumnType("datetime");

                entity.HasOne(d => d.Donor)
                    .WithMany(p => p.DonorsVisits)
                    .HasForeignKey(d => d.DonorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DonorsVisit_Donors");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.DonorsVisits)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DonorsVisit_Groups");

                entity.HasOne(d => d.PreferredTime)
                    .WithMany(p => p.DonorsVisits)
                    .HasForeignKey(d => d.PreferredTimeId)
                    .HasConstraintName("FK_DonorsVisit_Times");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.DonorsVisits)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DonorsVisit_Statuses");
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.HasOne(d => d.PreferredTime)
                    .WithMany(p => p.Groups)
                    .HasForeignKey(d => d.PreferredTimeId)
                    .HasConstraintName("FK_Groups_Times");

                entity.HasOne(d => d.TeamHead)
                    .WithMany(p => p.Groups)
                    .HasForeignKey(d => d.TeamHeadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Groups_Raises");
            });

            modelBuilder.Entity<Manager>(entity =>
            {
                entity.ToTable("Manager");

                entity.HasIndex(e => e.Id, "IX_Manager");

                entity.HasIndex(e => e.Id, "IX_Manager_1");

                entity.Property(e => e.ManagerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Massage>(entity =>
            {
                entity.Property(e => e.Text).IsRequired();

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Massages)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_Massages_Groups");
            });

            modelBuilder.Entity<Raise>(entity =>
            {
                entity.HasIndex(e => e.Id, "IX_Raises");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IdNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RaisesInGroup>(entity =>
            {
                entity.ToTable("RaisesInGroup");

                entity.HasIndex(e => e.Id, "IX_RaisesInGroup");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.RaisesInGroups)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RaisesInGroup_Groups");

                entity.HasOne(d => d.Raise)
                    .WithMany(p => p.RaisesInGroups)
                    .HasForeignKey(d => d.RaiseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RaisesInGroup_Raises");
            });

            modelBuilder.Entity<RisingVisit>(entity =>
            {
                entity.HasOne(d => d.Raise)
                    .WithMany(p => p.RisingVisits)
                    .HasForeignKey(d => d.RaiseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RisingVisits_Raises");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.RisingVisits)
                    .HasForeignKey(d => d.VisitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RisingVisits_DonorsVisit");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.Property(e => e.Status1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Status");
            });

            modelBuilder.Entity<Time>(entity =>
            {
                entity.Property(e => e.Time1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Time");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
