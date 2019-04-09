namespace easyERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Saidas
    {
        public int id { get; set; }

        public int? tipoSaida { get; set; }

        public int? cupom { get; set; }

        public int produto { get; set; }

        public int? quantidade { get; set; }

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

        public virtual cupom cupom1 { get; set; }

        public virtual tipoSaida tipoSaida1 { get; set; }
    }
}
