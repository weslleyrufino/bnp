namespace BNP.Domain.Arguments.MovimentoManual
{
    public class AdicionarMovimentoManualResponse
    {
        public int DAT_MES { get; private set; }
        public int DAT_ANO { get; private set; }
        public string COD_COSIF { get; private set; }
        public string COD_PRODUTO { get; private set; }
        public string Message { get; set; }

        public static explicit operator AdicionarMovimentoManualResponse(Entities.MovimentoManual entidade)
        {
            return new AdicionarMovimentoManualResponse()
            {
                DAT_MES = entidade.DAT_MES,
                DAT_ANO = entidade.DAT_ANO,
                COD_COSIF = entidade.COD_COSIF,
                COD_PRODUTO = entidade.COD_PRODUTO,
                Message = Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO
            };
        }
    }
}
