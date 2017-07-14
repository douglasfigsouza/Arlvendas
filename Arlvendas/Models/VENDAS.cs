namespace Arlvendas.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VENDAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VENDAS()
        {
            PRODUTOSDAVENDA = new HashSet<PRODUTOSDAVENDA>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDVENDA { get; set; }

        public DateTime DATAINICIO { get; set; }

        public int? IDCLI { get; set; }

        public int? IDMEC { get; set; }

        public int? IDVEIC { get; set; }

        public DateTime? DATATERMINO { get; set; }

        public decimal? VALORTOTAL { get; set; }

        public virtual CLIENTES CLIENTES { get; set; }

        public virtual MECANICOS MECANICOS { get; set; }

        public virtual VEICULOS VEICULOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUTOSDAVENDA> PRODUTOSDAVENDA { get; set; }
    }
}
