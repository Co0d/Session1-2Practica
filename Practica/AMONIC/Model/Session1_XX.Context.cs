﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AMONIC.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Net.Http;
    using System.Reflection.Emit;

    public partial class Session1_XXEntities2 : DbContext
    {
        private static Session1_XXEntities2 _context;
        public Session1_XXEntities2()
            : base("name=Session1_XXEntities2")
        {
        }

        public static Session1_XXEntities2 GetContext()
        {
            if (_context == null)
                _context = new Session1_XXEntities2();
            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }


        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Offices> Offices { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}