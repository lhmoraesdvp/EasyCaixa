namespace easyERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tipoSaida")]
    public partial class tipoSaida
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tipoSaida()
        {
            Saidas = new HashSet<Saidas>();
        }

        [Key]
        [Column("int")]
        public int _int { get; set; }

        [StringLength(50)]
        public string codSaida { get; set; }

        [StringLength(150)]
        public string descSaida { get; set; }

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
        public virtual ICollection<Saidas> Saidas { get; set; }
    }
}
