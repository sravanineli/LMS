﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryMSMVC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Libusers : DbContext
    {
        public Libusers()
            : base("name=Libusers")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<categoryLibrarian_Result> categoryLibrarian()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<categoryLibrarian_Result>("categoryLibrarian");
        }
    
        public virtual ObjectResult<categoryUser_Result> categoryUser()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<categoryUser_Result>("categoryUser");
        }
    }
}
