namespace BibliothèqueSqlite.DataConnection
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblBooks
    {
        public long Id { get; set; }

        public DateTime? dateBook { get; set; }

        [StringLength(50)]
        public string TitalBook { get; set; }

        [StringLength(50)]
        public string AuthorName { get; set; }

        public long? NmbCopieBook { get; set; }

        public long? QteBook { get; set; }

        [Column(TypeName = "real")]
        public double? PriceBook { get; set; }

        public long? idPublishing { get; set; }

        public long? idClassBook { get; set; }

        [StringLength(50)]
        public string SiteBook { get; set; }

        [StringLength(50)]
        public string BookStatus { get; set; }
    }
}
