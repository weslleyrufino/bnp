using BNP.Domain.Entities;

namespace BNP.Domain.Arguments.ProdutoCosfi
{
    public class ProdutoCosfiResponse
    {
        public string COD_COSIF { get; set; }
        public string COD_CLASSIFICACAO { get; set; }
        public string STA_STATUS { get; set; }

        public string COD_PRODUTO { get; set; }
        public string DES_PRODUTO { get; set; }
        public string PRODUTO_STA_STATUS { get; set; }

        public static explicit operator ProdutoCosfiResponse(ProdutoCosif entidade)
        {
            return new ProdutoCosfiResponse()
            {
                COD_COSIF = entidade.COD_COSIF,
                COD_CLASSIFICACAO = entidade.COD_CLASSIFICACAO,
                STA_STATUS = entidade.STA_STATUS,
                DES_PRODUTO = entidade.Produto.DES_PRODUTO,
                PRODUTO_STA_STATUS = entidade.Produto.STA_STATUS,
                COD_PRODUTO = entidade.Produto.COD_PRODUTO
            };
        }
    }
}
