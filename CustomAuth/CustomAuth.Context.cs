﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CustomAuth
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CustomAuthEntities : DbContext
    {
        public CustomAuthEntities()
            : base("name=CustomAuthEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<t_users> t_users { get; set; }
        public virtual DbSet<t_usersType> t_usersType { get; set; }

        public System.Data.Entity.DbSet<CustomAuth.Models.UserDetails> UserDetails { get; set; }
    }
}