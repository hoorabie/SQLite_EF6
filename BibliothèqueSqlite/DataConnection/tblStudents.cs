namespace BibliothèqueSqlite.DataConnection
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblStudents
    {
        public long Id { get; set; }

        [StringLength(50)]
        public string nomPrnom { get; set; }

        [StringLength(50)]
        public string cardNumber { get; set; }

        [StringLength(50)]
        public string phoneNumber { get; set; }
    }
}
