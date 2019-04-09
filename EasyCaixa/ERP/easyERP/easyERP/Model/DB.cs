namespace easyERP.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DB : DbContext
    {
        public DB()
            : base("name=DB")
        {
        }

        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<ContasAReceber> ContasAReceber { get; set; }
        public virtual DbSet<cupom> cupom { get; set; }
        public virtual DbSet<Endereco> Endereco { get; set; }
        public virtual DbSet<Entradas> Entradas { get; set; }
        public virtual DbSet<Estoque> Estoque { get; set; }
        public virtual DbSet<Fornecedores> Fornecedores { get; set; }
        public virtual DbSet<GrupoProduto> GrupoProduto { get; set; }
        public virtual DbSet<Operador> Operador { get; set; }
        public virtual DbSet<Produtos> Produtos { get; set; }
        public virtual DbSet<Saidas> Saidas { get; set; }
        public virtual DbSet<SubgrupoProduto> SubgrupoProduto { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TipoEntrada> TipoEntrada { get; set; }
        public virtual DbSet<tipoSaida> tipoSaida { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clientes>()
                .Property(e => e.dec1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.dec2)
                .IsFixedLength();

            modelBuilder.Entity<Clientes>()
                .HasMany(e => e.ContasAReceber)
                .WithOptional(e => e.Clientes)
                .HasForeignKey(e => e.cliente);

            modelBuilder.Entity<Clientes>()
                .HasMany(e => e.cupom)
                .WithOptional(e => e.Clientes)
                .HasForeignKey(e => e.cliente);

            modelBuilder.Entity<ContasAReceber>()
                .Property(e => e.valorAPagar)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ContasAReceber>()
                .Property(e => e.valorTotal)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ContasAReceber>()
                .Property(e => e.dec1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ContasAReceber>()
                .Property(e => e.dec2)
                .IsFixedLength();

            modelBuilder.Entity<ContasAReceber>()
                .Property(e => e.dec3)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ContasAReceber>()
                .Property(e => e.dec4)
                .IsFixedLength();

            modelBuilder.Entity<cupom>()
                .Property(e => e.valorTotal)
                .HasPrecision(18, 0);

            modelBuilder.Entity<cupom>()
                .Property(e => e.valorPago)
                .HasPrecision(18, 0);

            modelBuilder.Entity<cupom>()
                .Property(e => e.troco)
                .HasPrecision(18, 0);

            modelBuilder.Entity<cupom>()
                .Property(e => e.prevPagamento)
                .HasPrecision(18, 0);

            modelBuilder.Entity<cupom>()
                .Property(e => e.dec1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<cupom>()
                .Property(e => e.dec2)
                .IsFixedLength();

            modelBuilder.Entity<cupom>()
                .HasMany(e => e.ContasAReceber)
                .WithOptional(e => e.cupom1)
                .HasForeignKey(e => e.cupom);

            modelBuilder.Entity<cupom>()
                .HasMany(e => e.Saidas)
                .WithOptional(e => e.cupom1)
                .HasForeignKey(e => e.cupom);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.dec1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.dec2)
                .IsFixedLength();

            modelBuilder.Entity<Endereco>()
                .HasMany(e => e.Clientes)
                .WithOptional(e => e.Endereco1)
                .HasForeignKey(e => e.endereco);

            modelBuilder.Entity<Endereco>()
                .HasMany(e => e.Fornecedores)
                .WithOptional(e => e.Endereco1)
                .HasForeignKey(e => e.endereco);

            modelBuilder.Entity<Entradas>()
                .Property(e => e.precoUnidadeCompra)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Entradas>()
                .Property(e => e.dec1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Entradas>()
                .Property(e => e.dec2)
                .IsFixedLength();

            modelBuilder.Entity<Estoque>()
                .Property(e => e.precoVenda)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Estoque>()
                .Property(e => e.dec1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Estoque>()
                .Property(e => e.dec2)
                .IsFixedLength();

            modelBuilder.Entity<Fornecedores>()
                .Property(e => e.dec1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Fornecedores>()
                .Property(e => e.dec2)
                .IsFixedLength();

            modelBuilder.Entity<Fornecedores>()
                .HasMany(e => e.Entradas)
                .WithOptional(e => e.Fornecedores)
                .HasForeignKey(e => e.fornecedor);

            modelBuilder.Entity<GrupoProduto>()
                .Property(e => e.dec1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<GrupoProduto>()
                .Property(e => e.dec2)
                .IsFixedLength();

            modelBuilder.Entity<GrupoProduto>()
                .HasMany(e => e.SubgrupoProduto)
                .WithOptional(e => e.GrupoProduto1)
                .HasForeignKey(e => e.grupoProduto);

            modelBuilder.Entity<Operador>()
                .Property(e => e.dec1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Operador>()
                .Property(e => e.dec2)
                .IsFixedLength();

            modelBuilder.Entity<Operador>()
                .HasMany(e => e.cupom)
                .WithOptional(e => e.Operador1)
                .HasForeignKey(e => e.operador);

            modelBuilder.Entity<Operador>()
                .HasMany(e => e.Entradas)
                .WithOptional(e => e.Operador1)
                .HasForeignKey(e => e.operador);

            modelBuilder.Entity<Produtos>()
                .Property(e => e.dec1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Produtos>()
                .Property(e => e.dec2)
                .IsFixedLength();

            modelBuilder.Entity<Produtos>()
                .HasMany(e => e.Entradas)
                .WithOptional(e => e.Produtos)
                .HasForeignKey(e => e.produto);

            modelBuilder.Entity<Produtos>()
                .HasMany(e => e.Estoque)
                .WithOptional(e => e.Produtos)
                .HasForeignKey(e => e.produto);

            modelBuilder.Entity<Saidas>()
                .Property(e => e.dec1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Saidas>()
                .Property(e => e.dec2)
                .IsFixedLength();

            modelBuilder.Entity<SubgrupoProduto>()
                .Property(e => e.dec1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SubgrupoProduto>()
                .Property(e => e.dec2)
                .IsFixedLength();

            modelBuilder.Entity<SubgrupoProduto>()
                .HasMany(e => e.Produtos)
                .WithOptional(e => e.SubgrupoProduto1)
                .HasForeignKey(e => e.subgrupoProduto);

            modelBuilder.Entity<TipoEntrada>()
                .Property(e => e.dec1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TipoEntrada>()
                .Property(e => e.dec2)
                .IsFixedLength();

            modelBuilder.Entity<TipoEntrada>()
                .HasMany(e => e.Entradas)
                .WithOptional(e => e.TipoEntrada1)
                .HasForeignKey(e => e.tipoEntrada);

            modelBuilder.Entity<tipoSaida>()
                .Property(e => e.dec1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tipoSaida>()
                .Property(e => e.dec2)
                .IsFixedLength();

            modelBuilder.Entity<tipoSaida>()
                .HasMany(e => e.Saidas)
                .WithOptional(e => e.tipoSaida1)
                .HasForeignKey(e => e.tipoSaida);
        }
    }
}
