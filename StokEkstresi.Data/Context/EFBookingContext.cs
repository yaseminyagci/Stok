using StokEkstresi.Domain.Entity;
using System;
using System.Data.Entity;

namespace StokEkstresi.Data.Context
{
    public class EFBookingContext : DbContext
    {
        public EFBookingContext()
            : base("StokContext")
        {
        }

        //public override int SaveChanges()
        //{
        //    var result = 0;
        //    try
        //    {
        //        result =SaveChanges();
        //    }
        //    catch (Exception ex) 
        //    {

        //        throw new DatabaseException("DataBaseException",ex);
        //    }
        //    return base.SaveChanges();
        //}

        public DbSet<STI> STI { get; set; }

        public DbSet<STK> STK { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}