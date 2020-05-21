using BNP.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BNP.Infra.Persistence.Map
{
    public class MapMovimentoManual : EntityTypeConfiguration<MovimentoManual>
    {
        public MapMovimentoManual()
        {
            ToTable("MOVIMENTO_MANUAL");

            HasKey(x => new { x.DAT_MES, x.DAT_ANO, x.NUM_LANCAMENTO});

            Property(x => x.DAT_MES).HasColumnType("NUMERIC");
            Property(x => x.DAT_ANO).HasColumnType("NUMERIC");
            Property(x => x.NUM_LANCAMENTO).HasColumnType("NUMERIC");

            Property(x => x.COD_PRODUTO).HasColumnType("char");
            Property(x => x.VAL_VALOR).HasColumnType("decimal");
            Property(x => x.DES_DESCRICAO).HasColumnType("VARCHAR");
            Property(x => x.DAT_MOVIMENTO).HasColumnType("SMALLDATETIME");
            Property(x => x.COD_USUARIO).HasColumnType("VARCHAR");

            HasRequired(p => p.ProdutoCosif)
                .WithMany(c => c.MovimentoManuais)
                .HasForeignKey(x => x.COD_COSIF);

            HasRequired(p => p.Produto)
                .WithMany(c => c.MovimentoManuais)
                .HasForeignKey(x => x.COD_PRODUTO);

        }
    }
}
