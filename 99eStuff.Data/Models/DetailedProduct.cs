namespace _99eStuff.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DetailedProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DetailedProduct()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDDetailed { get; set; }

        [StringLength(50)]
        public string Material { get; set; }

        public int ProductWeight { get; set; }

        [StringLength(200)]
        public string Size { get; set; }

        public int Stock { get; set; }

        [Column(TypeName = "image")]
        public byte[] BigPicture { get; set; }

        [StringLength(200)]
        public string Detail1 { get; set; }

        [StringLength(200)]
        public string Detail2 { get; set; }

        [StringLength(200)]
        public string Detail3 { get; set; }

        [StringLength(200)]
        public string Detail4 { get; set; }

        [StringLength(200)]
        public string Detail5 { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
