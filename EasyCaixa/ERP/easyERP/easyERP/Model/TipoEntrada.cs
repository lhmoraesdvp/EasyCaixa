namespace easyERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoEntrada")]
    public partial class TipoEntrada
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoEntrada()
        {
            Entradas = new HashSet<Entradas>();
        }

        public int id { get; set; }

        public int? codEntrada { get; set; }

        [StringLength(100)]
        public string descricaoEntrada { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entradas> Entradas { get; set; }
    }
}
