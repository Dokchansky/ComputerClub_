﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ComputerClub
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CompClubEntities : DbContext
    {
        public CompClubEntities()
            : base("name=CompClubEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Computers> Computers { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<Feedback> Feedback { get; set; }
        public virtual DbSet<Games> Games { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<Members> Members { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<Promotions> Promotions { get; set; }
        public virtual DbSet<Reservations> Reservations { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
    }
}