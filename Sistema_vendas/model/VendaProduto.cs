using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_vendas.view;


namespace Sistema_vendas.model
{
    public class VendaProduto
    {
        //Declaração dos atributos

        public int idvenda { get; set; }
        public int idproduto { get; set; }
        public decimal quantidade { get; set; }
        public decimal valor_unitario { get; set; }

    }
}
