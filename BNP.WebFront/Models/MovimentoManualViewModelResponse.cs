namespace BNP.WebFront.Models
{
    public class MovimentoManualViewModelResponse
    {
        public int DAT_MES { get; set; }
        public int DAT_ANO { get; set; }
        public string COD_PRODUTO { get; set; }
        public string DES_PRODUTO { get; set; }
        public int NUM_LANCAMENTO { get; set; }
        public string DES_DESCRICAO { get; set; }
        public decimal VAL_VALOR { get; set; }
    }
}