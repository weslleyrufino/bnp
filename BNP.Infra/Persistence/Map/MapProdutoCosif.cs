using BNP.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BNP.Infra.Persistence.Map
{
    public class MapProdutoCosif : EntityTypeConfiguration<ProdutoCosif>
    {
        public MapProdutoCosif()
        {
            ToTable("PRODUTO_COSIF");

            HasKey(x => x.COD_COSIF);

            Property(x => x.COD_COSIF).HasColumnType("char");
            Property(x => x.COD_CLASSIFICACAO).HasColumnType("char").IsOptional();
            Property(x => x.STA_STATUS).HasColumnType("char").IsOptional();

            HasRequired(p => p.Produto)
                .WithMany(c => c.ProdutoCosifs)
                .HasForeignKey(x => x.COD_PRODUTO);

        }
    }
}
