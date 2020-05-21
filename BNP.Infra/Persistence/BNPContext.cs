using BNP.Domain.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace BNP.Infra.Persistence
{
    public class BNPContext : DbContext
    {
        public BNPContext() : base("BNP")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public IDbSet<Produto> Produtos { get; set; }
        public IDbSet<ProdutoCosif> ProdutoCosif { get; set; }
        public IDbSet<MovimentoManual> MovimentoManual { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.HasDefaultSchema("Apoio");

            //Remove a pluralização dos nomes das tabelas
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //Remove exclusão em cascata
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //Setar para usar varchar ou invés de nvarchar
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            //Caso eu esqueça de informar o tamanho do campo ele irá colocar varchar de 100
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

            //Mapeia as entidades
            //modelBuilder.Configurations.Add(new JogadorMap());
            //modelBuilder.Configurations.Add(new PlataformaMap());

            #region Adiciona entidades mapeadas - Automaticamente via Assembly
            modelBuilder.Configurations.AddFromAssembly(typeof(BNPContext).Assembly);
            #endregion

            Database.SetInitializer<BNPContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}
