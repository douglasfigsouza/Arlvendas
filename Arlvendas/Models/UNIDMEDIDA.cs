namespace Arlvendas.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UNIDMEDIDA")]
    public partial class UNIDMEDIDA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UNIDMEDIDA()
        {
            PRODUTOS = new HashSet<PRODUTOS>();
        }

        [Key]
        public int IDUNID { get; set; }

        [StringLength(50)]
        public string DESCUNID { get; set; }

        [Required]
        [StringLength(2)]
        public string SIGLAUNID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUTOS> PRODUTOS { get; set; }
    }
}
