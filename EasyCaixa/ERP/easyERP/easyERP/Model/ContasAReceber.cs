namespace easyERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContasAReceber")]
    public partial class ContasAReceber
    {
        public int id { get; set; }

        public int? cliente { get; set; }

        public decimal? valorAPagar { get; set; }

        public decimal? valorTotal { get; set; }

        public int? cupom { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dtEstipulada { get; set; }

        [StringLength(150)]
        public string valorPago { get; set; }

        [StringLength(150)]
        public string nvc2 { get; set; }

        [StringLength(150)]
        public string nvc3 { get; set; }

        public int? int1 { get; set; }

        public int? int2 { get; set; }

        public int? int3 { get; set; }

        public decimal? dec1 { get; set; }

        [StringLength(10)]
        public string dec2 { get; set; }

        public decimal? dec3 { get; set; }

        [StringLength(10)]
        public string dec4 { get; set; }

        public virtual Clientes Clientes { get; set; }

        public virtual cupom cupom1 { get; set; }
    }
}
