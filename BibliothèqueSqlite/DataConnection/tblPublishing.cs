namespace BibliothèqueSqlite.DataConnection
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblPublishing")]
    public partial class tblPublishing
    {
        public long Id { get; set; }

        [StringLength(50)]
        public string Publishing { get; set; }

        public bool isPublishing { get; set; }
    }
}
