using BNP.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BNP.Infra.Persistence.Map
{
    public class MapProduto : EntityTypeConfiguration<Produto>
    {
        public MapProduto()
        {
            ToTable("PRODUTO");
            HasKey(p => p.COD_PRODUTO);

            Property(p => p.COD_PRODUTO).HasColumnType("char");
            Property(p => p.DES_PRODUTO).HasColumnType("varchar").IsOptional();
            Property(p => p.STA_STATUS).HasColumnType("char").IsOptional();
            
        }
    }
}
