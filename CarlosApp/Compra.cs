﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlosApp
{
    public class Compra
    {
        [DisplayName("Id")] public int Id { get; set; }
        [DisplayName("Id do Produto")] public int idProduto { get; set; }
        [DisplayName("Id do Fornecedor")] public int idFornecedor { get; set; }
        [DisplayName("Quantidade Comprada")] public int quantidade { get; set; }
        [DisplayName("Porcentagem de desconto")] public decimal desconto { get; set; }
        [DisplayName("data da compra")] public DateTime dataCompra { get; set; }
       
        public void loadData(string dataString)
        {
            string[] data = dataString.Split(',');
            Id = int.Parse(data[0]);
            idProduto = int.Parse(data[1]);
            idFornecedor = int.Parse(data[2]);
            quantidade = int.Parse(data[3]);
            desconto = decimal.Parse(data[4]);
            dataCompra = DateTime.Parse(data[5]);
        }
        public override string ToString()
        {
            return $"{Id};{idProduto};{idFornecedor};{quantidade};{desconto.ToString()};{dataCompra}";
        }

    }
}
