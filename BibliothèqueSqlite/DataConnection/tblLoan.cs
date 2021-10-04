namespace BibliothèqueSqlite.DataConnection
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblLoan")]
    public partial class tblLoan
    {
        public long Id { get; set; }

        public long? idBook { get; set; }

        public long? idStudents { get; set; }

        [StringLength(50)]
        public string BookStatus { get; set; }

        public DateTime? dateExit { get; set; }

        public DateTime? dateEntry { get; set; }

        public DateTime? dateActualEnty { get; set; }
    }
}
