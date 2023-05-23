using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_vendas.view;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Sistema_vendas.model
{
    public class Usuario
    {
        //Declaração dos atributos
        public int idusuario { get;set; }
        public string nome { get; set; }
        public string login { get; set; }
        public string telefone { get; set; }
        public string senha { get; set; }
    }
}
