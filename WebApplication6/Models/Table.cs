namespace WebApplication6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Table")]
    public partial class Table
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(10)]
        public string Name { get; set; }

        [StringLength(10)]
        public string Mama { get; set; }

        [StringLength(10)]
        public string Papa { get; set; }
    }
}
