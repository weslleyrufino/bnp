namespace BNP.Domain.Arguments.Produto
{
    public class ProdutoResponse
    {
        public string COD_PRODUTO { get; set; }
        public string DES_PRODUTO { get; set; }
        public string STA_STATUS { get; set; }

        public static explicit operator ProdutoResponse(Entities.Produto entidade)
        {
            return new ProdutoResponse()
            {
                COD_PRODUTO = entidade.COD_PRODUTO,
                DES_PRODUTO = entidade.DES_PRODUTO,
                STA_STATUS = entidade.STA_STATUS
            };
        }
    }
}
