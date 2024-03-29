﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WarehouseManagement
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WarehouseManagementDBEntities : DbContext
    {
        public WarehouseManagementDBEntities()
            : base("name=WarehouseManagementDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<IssuanceOrderItem> IssuanceOrderItems { get; set; }
        public virtual DbSet<IssuanceOrder> IssuanceOrders { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ItemSupplier> ItemSuppliers { get; set; }
        public virtual DbSet<OrderNumber> OrderNumbers { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<SupplyOrderItem> SupplyOrderItems { get; set; }
        public virtual DbSet<SupplyOrder> SupplyOrders { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TransferItem> TransferItems { get; set; }
        public virtual DbSet<Transfer> Transfers { get; set; }
        public virtual DbSet<WarehouseCustomer> WarehouseCustomers { get; set; }
        public virtual DbSet<WarehouseItem> WarehouseItems { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }
        public virtual DbSet<WarehouseSupplier> WarehouseSuppliers { get; set; }
    }
}
