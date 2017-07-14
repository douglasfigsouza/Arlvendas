using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Arlvendas.Models
{
    [Table("PRODUTOSDAVENDA")]
    public class PRODUTOSDAVENDA
    {
        [Key]
        [Column(Order = 0)]
        public int IDPRODVENDA { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDPROD { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDVENDA { get; set; }

        public decimal QTD { get; set; }

        public decimal? VALORTOTAL { get; set; }
        [StringLength(5)]
        public string UNIDMEDIDA { get; set; }

        public virtual VENDA VENDA { get; set; }
        public virtual PRODUTOS PRODUTOS { get; set; }
    }
}