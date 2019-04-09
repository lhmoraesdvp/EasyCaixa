namespace easyERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Operador")]
    public partial class Operador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Operador()
        {
            cupom = new HashSet<cupom>();
            Entradas = new HashSet<Entradas>();
        }

        public int id { get; set; }

        [StringLength(100)]
        public string email { get; set; }

        [StringLength(50)]
        public string login { get; set; }

        [StringLength(50)]
        public string senha { get; set; }

        [StringLength(100)]
        public string nome { get; set; }

        [StringLength(150)]
        public string departamento { get; set; }

        [StringLength(100)]
        public string funcao { get; set; }

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
        public virtual ICollection<cupom> cupom { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entradas> Entradas { get; set; }
    }
}
