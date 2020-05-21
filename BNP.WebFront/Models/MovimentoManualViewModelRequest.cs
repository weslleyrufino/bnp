using System.ComponentModel.DataAnnotations;

namespace BNP.WebFront.Models
{
    public class MovimentoManualViewModelRequest
    {
        public int DAT_MES { get; set; }
        public int DAT_ANO { get; set; }
        public string COD_PRODUTO { get; set; }
        public string COD_COSIF { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public string VAL_VALOR { get; set; }// Não é a melhor prática, mas tive dificuldade no front para deixar como decimal e persistir na tabela.
        public string DES_DESCRICAO { get; set; }
    }
}