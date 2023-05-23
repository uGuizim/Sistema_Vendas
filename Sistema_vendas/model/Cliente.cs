﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_vendas.view;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Sistema_vendas.model
{
    public class Cliente
    {
        //Declaração dos atributos
        public int idcliente { get;set; }
        public string nome { get; set; }
        public string cpf_cnpj { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string logradouro { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
    }
}
