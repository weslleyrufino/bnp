namespace BNP.Domain.Arguments.MovimentoManual
{
    public class AdicionarMovimentoManualRequest
    {
        public int DAT_MES { get; set; }
        public int DAT_ANO { get; set; }
        public string COD_PRODUTO { get; set; }
        public string COD_COSIF { get; set; }
        public decimal VAL_VALOR { get; set; }
        public string DES_DESCRICAO { get; set; }
    }
}
