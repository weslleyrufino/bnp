using BNP.Domain.Arguments.MovimentoManual;
using BNP.Domain.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BNP.Domain.Entities
{
    public class MovimentoManual : EntityBase
    {
        public MovimentoManual()
        {

        }

        public MovimentoManual(AdicionarMovimentoManualRequest entidade)
        {
            DAT_MES = entidade.DAT_MES;
            DAT_ANO = entidade.DAT_ANO;
            COD_PRODUTO = entidade.COD_PRODUTO;
            COD_COSIF = entidade.COD_COSIF;
            VAL_VALOR = entidade.VAL_VALOR;
            DES_DESCRICAO = entidade.DES_DESCRICAO;
            DAT_MOVIMENTO = DateTime.Now;
            COD_USUARIO = "TESTE";
        }

        public int DAT_MES { get; private set; }
        public int DAT_ANO { get; private set; }
        public decimal VAL_VALOR { get; private set; }
        public string DES_DESCRICAO { get; private set; }
        public DateTime DAT_MOVIMENTO { get; private set; }
        public string COD_USUARIO { get; private set; }

        // Foreign key
        public string COD_COSIF { get; private set; }
        public string COD_PRODUTO { get; private set; }

        public virtual ProdutoCosif ProdutoCosif { get; set; }
        public virtual Produto Produto { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NUM_LANCAMENTO { get; set; }
    }
}
