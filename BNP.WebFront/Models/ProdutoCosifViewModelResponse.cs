using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BNP.WebFront.Models
{
    public class ProdutoCosifViewModelResponse
    {
        public string COD_COSIF { get; set; }
        public string COD_CLASSIFICACAO { get; set; }
        public string STA_STATUS { get; set; }

        public string COD_PRODUTO { get; set; }
        public string DES_PRODUTO { get; set; }
        public string PRODUTO_STA_STATUS { get; set; }
    }
}