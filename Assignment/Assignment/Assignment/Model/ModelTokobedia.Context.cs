﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TokobediaEntities2 : DbContext
    {
        public TokobediaEntities2()
            : base("name=TokobediaEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DetailTran> DetailTrans { get; set; }
        public virtual DbSet<HeaderTran> HeaderTrans { get; set; }
        public virtual DbSet<MsProducts> MsProducts { get; set; }
        public virtual DbSet<MsProductType> MsProductTypes { get; set; }
        public virtual DbSet<MsRole> MsRoles { get; set; }
        public virtual DbSet<MsUser> MsUsers { get; set; }
    }
}
