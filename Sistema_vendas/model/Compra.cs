using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_vendas.model
{
    internal class Compra
    {
        public int idcompra { get; set; }
        public int idfornecedor { get; set; }
        public DateTime data_compra { get; set; }
        public decimal valor_total { get; set; }
        public int idusuario { get; set; }

        public List<CompraProduto> produtos { get; set; }

        public Compra()
        {
            this.produtos = new List<CompraProduto>();
        }

    }
}
