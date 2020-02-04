namespace _99eStuff.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int IDDetailed { get; set; }

        [Required]
        [StringLength(50)]
        public string NameProduct { get; set; }

        [Required]
        [StringLength(20)]
        public string Category { get; set; }

        [Column(TypeName = "money")]
        public decimal CurentPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal OldPrice { get; set; }

        [Column(TypeName = "image")]
        public byte[] SmallPicture { get; set; }

        public virtual DetailedProduct DetailedProduct { get; set; }
    }
}
