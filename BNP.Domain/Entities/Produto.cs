using BNP.Domain.Entities.Base;
using System.Collections.Generic;

namespace BNP.Domain.Entities
{
    public class Produto : EntityBase
    {
        protected Produto()
        {
            ProdutoCosifs = new HashSet<ProdutoCosif>();
            MovimentoManuais = new HashSet<MovimentoManual>();
        }

        public string COD_PRODUTO { get; private set; }

        public string DES_PRODUTO { get; private set; }
        
        public string STA_STATUS { get; private set; }

        // Navigation property
        public virtual ICollection<ProdutoCosif> ProdutoCosifs { get; set; }
        public virtual ICollection<MovimentoManual> MovimentoManuais { get; set; }


    }
}
