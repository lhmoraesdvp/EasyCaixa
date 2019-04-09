namespace easyERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cupom")]
    public partial class cupom
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cupom()
        {
            ContasAReceber = new HashSet<ContasAReceber>();
            Saidas = new HashSet<Saidas>();
        }

        public int id { get; set; }

        [StringLength(50)]
        public string codCupom { get; set; }

        public int? aberto { get; set; }

        public decimal? valorTotal { get; set; }

        public decimal? valorPago { get; set; }

        [StringLength(50)]
        public string formaPagamento { get; set; }

        public int? cliente { get; set; }

        public decimal? troco { get; set; }

        public int? parcelas { get; set; }

        public decimal? prevPagamento { get; set; }

        public int? operador { get; set; }

        public int? caixa { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data { get; set; }

        [StringLength(150)]
        public string nvc1 { get; set; }

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

        public virtual Clientes Clientes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContasAReceber> ContasAReceber { get; set; }

        public virtual Operador Operador1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Saidas> Saidas { get; set; }
    }
}
