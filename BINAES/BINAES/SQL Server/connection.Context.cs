﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BINAES.SQL_Server
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db_BINAES : DbContext
    {
        public db_BINAES()
            : base("name=db_BINAES")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ACTIVITY> ACTIVITY { get; set; }
        public virtual DbSet<AREA> AREA { get; set; }
        public virtual DbSet<ATTENDANCE> ATTENDANCE { get; set; }
        public virtual DbSet<AUTHOR> AUTHOR { get; set; }
        public virtual DbSet<CELEBRATION> CELEBRATION { get; set; }
        public virtual DbSet<COLLECTION_> COLLECTION_ { get; set; }
        public virtual DbSet<COPY_> COPY_ { get; set; }
        public virtual DbSet<EDITORIAL> EDITORIAL { get; set; }
        public virtual DbSet<FLOOR_> FLOOR_ { get; set; }
        public virtual DbSet<FORMAT_> FORMAT_ { get; set; }
        public virtual DbSet<GENRE> GENRE { get; set; }
        public virtual DbSet<GOAL> GOAL { get; set; }
        public virtual DbSet<INSTITUTION> INSTITUTION { get; set; }
        public virtual DbSet<LABEL_> LABEL_ { get; set; }
        public virtual DbSet<LABEL_TYPE> LABEL_TYPE { get; set; }
        public virtual DbSet<LANGUAGE_> LANGUAGE_ { get; set; }
        public virtual DbSet<LOAN_BOOKING> LOAN_BOOKING { get; set; }
        public virtual DbSet<MANAGER> MANAGER { get; set; }
        public virtual DbSet<OCCUPANCY> OCCUPANCY { get; set; }
        public virtual DbSet<ROLE_> ROLE_ { get; set; }
        public virtual DbSet<TYPE_> TYPE_ { get; set; }
        public virtual DbSet<USER_> USER_ { get; set; }
        public virtual DbSet<WORDS_LIST> WORDS_LIST { get; set; }
    }
}
