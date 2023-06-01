using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_vendas.model
{
    public class CompraProduto
    {
        //Declaração dos atributos

        public int compra { get; set; }
        public int idproduto { get; set; }
        public decimal quantidade { get; set; }
        public decimal valor_unitario { get; set; }
    }
}
