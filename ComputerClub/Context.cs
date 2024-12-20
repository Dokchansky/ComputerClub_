using ComputerClub;
using System;
using System.Data.Entity;

public class Context : DbContext
{
    public Context() : base("name=CompClubEntities")
    {
    }

    public DbSet<Members> Members { get; set; }
    public DbSet<Computers> Computers { get; set; }
    public DbSet<Games> Games { get; set; }
    public DbSet<Reservations> Reservations { get; set; }
    public DbSet<Staff> Staff { get; set; }
    public DbSet<Events> Events { get; set; }
    public DbSet<Payments> Payments { get; set; }
    public DbSet<Feedback> Feedbacks { get; set; }
    public DbSet<Promotions> Promotions { get; set; }
    public DbSet<Inventory> Inventory { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
       
        modelBuilder.Entity<Reservations>()
            .HasRequired(r => r.Members)
            .WithMany()
            .HasForeignKey(r => r.MemberID);

        modelBuilder.Entity<Reservations>()
            .HasRequired(r => r.Computers)
            .WithMany()
            .HasForeignKey(r => r.ComputerID);

        modelBuilder.Entity<Payments>()
            .HasRequired(p => p.Members)
            .WithMany()
            .HasForeignKey(p => p.MemberID);

        modelBuilder.Entity<Feedback>()
            .HasRequired(f => f.Members)
            .WithMany()
            .HasForeignKey(f => f.MemberID);

        

        base.OnModelCreating(modelBuilder);
    }
}