namespace BibliothèqueSqlite.DataConnection
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyModel : DbContext
    {
        public MyModel()
            : base("name=MyModel")
        {
        }

       
        public virtual DbSet<tblBooks> tblBooks { get; set; }
        public virtual DbSet<tblLoan> tblLoan { get; set; }
        public virtual DbSet<tblPublishing> tblPublishing { get; set; }
        public virtual DbSet<tblStudents> tblStudents { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
