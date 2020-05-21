using BNP.Domain.Entities.Base;
using System.Collections.Generic;

namespace BNP.Domain.Entities
{
    public class ProdutoCosif : EntityBase
    {
        public ProdutoCosif()
        {
            MovimentoManuais = new HashSet<MovimentoManual>();
        }
        
        public string COD_COSIF { get; private set; }
        public string COD_CLASSIFICACAO { get; private set; }
        public string STA_STATUS { get; private set; }

        // Foreign key
        public string COD_PRODUTO { get; private set; }

        public virtual Produto Produto { get; set; }

        // Navigation property
        public virtual ICollection<MovimentoManual> MovimentoManuais { get; set; }

    }
}
