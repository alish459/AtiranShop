﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersianShop.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PersianEntities : DbContext
    {
        public PersianEntities()
            : base("name=PersianEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<cust_act> cust_act { get; set; }
        public virtual DbSet<CUSTOMERS> CUSTOMERS { get; set; }
        public virtual DbSet<sys_users> sys_users { get; set; }
        public virtual DbSet<Field> Field { get; set; }
        public virtual DbSet<Form> Form { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<SubSystem> SubSystem { get; set; }
        public virtual DbSet<SubSystemPermission> SubSystemPermission { get; set; }
        public virtual DbSet<UserFavorites> UserFavorites { get; set; }
        public virtual DbSet<UserFieldPermission> UserFieldPermission { get; set; }
        public virtual DbSet<UserFormPermission> UserFormPermission { get; set; }
        public virtual DbSet<UserPersonalizationForColor> UserPersonalizationForColor { get; set; }
        public virtual DbSet<UserPersonalizationForFont> UserPersonalizationForFont { get; set; }
        public virtual DbSet<overal_setting> overal_setting { get; set; }
    }
}
