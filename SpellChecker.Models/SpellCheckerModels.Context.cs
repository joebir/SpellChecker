﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SpellChecker.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SpellCheckerEntities : DbContext
    {
        public SpellCheckerEntities()
            : base("name=SpellCheckerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public virtual DbSet<IdentityRole> IdentityRoles { get; set; }
        public virtual DbSet<IdentityUserClaim> IdentityUserClaims { get; set; }
        public virtual DbSet<IdentityUserLogin> IdentityUserLogins { get; set; }
        public virtual DbSet<IdentityUserRole> IdentityUserRoles { get; set; }
        public virtual DbSet<SpellbookEntry> SpellbookEntries { get; set; }
        public virtual DbSet<Spellbook> Spellbooks { get; set; }
        public virtual DbSet<Spell> Spells { get; set; }
    }
}
