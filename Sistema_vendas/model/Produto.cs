using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_vendas.view;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Sistema_vendas.model
{
    public class Produto
    {
        //Declaração dos atributos
        public int idproduto { get;set; }
        public string nome { get; set; }
        public string unidade_medida { get; set; }
        public string marca { get; set; }
        public string cor { get; set; }
        public float quantidade { get; set; }
        public float valor_unitario { get; set; }
        public int idfornecedor { get; set; }

    }
}
