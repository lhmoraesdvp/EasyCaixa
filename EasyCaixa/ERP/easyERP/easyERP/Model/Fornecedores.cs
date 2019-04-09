namespace easyERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Fornecedores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fornecedores()
        {
            Entradas = new HashSet<Entradas>();
        }

        public int id { get; set; }

        [StringLength(100)]
        public string razaoSocial { get; set; }

        public int? endereco { get; set; }

        [StringLength(100)]
        public string cnpj { get; set; }

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

        public virtual Endereco Endereco1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entradas> Entradas { get; set; }
    }
}
