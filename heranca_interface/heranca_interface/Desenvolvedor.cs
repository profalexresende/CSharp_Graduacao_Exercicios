using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca_interface
{
    class Desenvolvedor : Funcionario, IBeneficio
    {
        public Desenvolvedor(string nome, decimal salario) : base(nome, salario) { }

        public override decimal CalcularSalarioFinal()
        {
            return salario * 1.10m; // bônus 10%
        }

        public void CalcularBeneficio()
        {
            Console.WriteLine($"Benefício do Desenvolvedor {nome}: R$ {salario * 0.10m:F2} (10% de bônus)");
        }
    }
}
