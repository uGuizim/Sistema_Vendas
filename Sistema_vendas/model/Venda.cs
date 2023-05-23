using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_vendas.view;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Sistema_vendas.model
{
    public class Venda
    {
        //Declaração dos atributos

        public int idvenda { get; set; }
        public int idcliente { get; set; }
        public DateTime data_venda { get; set; }
        public decimal valor_total { get; set; }
        public int idusuario { get; set; }

        //Lista de produtos de uma venda
        public List<VendaProduto> produtos { get; set; }

        public Venda()
        {
            this.produtos = new List<VendaProduto>();
        }

    }


}
