using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Sistema_FuncioeSalario
{
    public class FuncionarioCLT:Pessoa
    {
        public decimal SalarioBase { get; set; }

        //calculando o desconto do salário
        public decimal CalcularSalarioLiquido()
        {
            return SalarioBase * 0.9m; // desconto de 10%
        }
    }
}
