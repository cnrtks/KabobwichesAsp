﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace KabobwichesAsp.Models
{
    public class Repository : DbContext
    {
        public DbSet<Kabobwich> Kabobwiches { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<PaymentInformation> PaymentInfos { get; set; }
        public DbSet<Order> Orders { get; set; }

       /* protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            foreach (var relationship in modelbuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelbuilder);

          
        }*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Kabobwich;Data Source=localhost"); //DESKTOP-KFKJOV0\SQLEXPRESS01
        }
    }
}
