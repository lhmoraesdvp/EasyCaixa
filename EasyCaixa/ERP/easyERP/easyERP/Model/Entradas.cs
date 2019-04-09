namespace easyERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Entradas
    {
        [Key]
        [Column("int")]
        public int _int { get; set; }

        public int? operador { get; set; }

        public int? tipoEntrada { get; set; }

        public int? produto { get; set; }

        public int? nf { get; set; }

        public int? quantidadeSistema { get; set; }

        public int? quantidadeAtual { get; set; }

        public int? quantidadeEntrada { get; set; }

        public int? fornecedor { get; set; }

        public decimal? precoUnidadeCompra { get; set; }

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

        public virtual Fornecedores Fornecedores { get; set; }

        public virtual Operador Operador1 { get; set; }

        public virtual Produtos Produtos { get; set; }

        public virtual TipoEntrada TipoEntrada1 { get; set; }
    }
}
