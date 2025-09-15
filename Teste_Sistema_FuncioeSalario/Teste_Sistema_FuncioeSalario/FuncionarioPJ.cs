using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Sistema_FuncioeSalario
{
    public class FuncionarioPJ:Pessoa
    {
        public decimal SalarioBase { get; set; }

        //calculando o desconto do salário
        public decimal CalcularSalarioLiquido()
        {
            return SalarioBase;
        }
    }
}
