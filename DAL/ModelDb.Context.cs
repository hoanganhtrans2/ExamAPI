﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ExamDBEntities : DbContext
    {
        public ExamDBEntities()
            : base("name=ExamDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Attend> Attends { get; set; }
        public virtual DbSet<ExamDetail> ExamDetails { get; set; }
        public virtual DbSet<ExamInfo> ExamInfoes { get; set; }
        public virtual DbSet<Level> Levels { get; set; }
        public virtual DbSet<Option> Options { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Answer> Answers { get; set; }
    
        public virtual ObjectResult<Question> GetQuestions(Nullable<int> leveid, Nullable<int> number)
        {
            var leveidParameter = leveid.HasValue ?
                new ObjectParameter("leveid", leveid) :
                new ObjectParameter("leveid", typeof(int));
    
            var numberParameter = number.HasValue ?
                new ObjectParameter("number", number) :
                new ObjectParameter("number", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Question>("GetQuestions", leveidParameter, numberParameter);
        }
    }
}
