using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlosApp
{
    public class Fornecedor
    {
        [DisplayName("Id")] public int Id { get; set; }
        [DisplayName("Empresa")] public string nomeDaEmpresa { get; set; }
        [DisplayName("Telefone")] public string CNPJ { get; set; }
        [DisplayName("E-mail ")] public string emaill { get; set; }
        [DisplayName("Endereço da Empresa")] public string endereço { get; set; }


    }
}
