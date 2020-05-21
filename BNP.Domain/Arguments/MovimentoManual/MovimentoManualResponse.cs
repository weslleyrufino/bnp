using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNP.Domain.Arguments.MovimentoManual
{
    public class MovimentoManualResponse
    {
        public int DAT_MES              { get; private set; }
        public int DAT_ANO              { get; private set; }
        public string COD_PRODUTO       { get; private set; }
        public string DES_PRODUTO       { get; private set; }
        public int NUM_LANCAMENTO       { get; private set; }
        public string DES_DESCRICAO     { get; private set; }
        public decimal VAL_VALOR        { get; private set; }

        public static explicit operator MovimentoManualResponse(Entities.MovimentoManual entidade)
        {
            return new MovimentoManualResponse()
            {
                DAT_MES = entidade.DAT_MES,
                DAT_ANO = entidade.DAT_ANO,
                COD_PRODUTO = entidade.Produto.COD_PRODUTO,
                DES_PRODUTO = entidade.Produto.DES_PRODUTO,
                NUM_LANCAMENTO = entidade.NUM_LANCAMENTO,
                DES_DESCRICAO = entidade.DES_DESCRICAO,
                VAL_VALOR = entidade.VAL_VALOR
            };
        }
    }
}
