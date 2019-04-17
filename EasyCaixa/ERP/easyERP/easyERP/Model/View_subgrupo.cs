namespace easyERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_subgrupo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(50)]
        public string codSubgrupo { get; set; }

        [StringLength(100)]
        public string descSubgrupo { get; set; }

        [StringLength(150)]
        public string nvc1 { get; set; }

        [StringLength(100)]
        public string descGrupo { get; set; }
    }
}
