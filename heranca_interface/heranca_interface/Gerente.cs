using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca_interface
{
     class Gerente: Funcionario,IBeneficio
    {
        public Gerente(string nome, decimal salario) : base(nome, salario) { }

        public override decimal CalcularSalarioFinal()
        {
            return salario * 1.20m; // bônus 20%
        }

        public void CalcularBeneficio()
        {
            Console.WriteLine($"Benefício do Gerente {nome}: R$ {salario * 0.20m:F2} (20% de bônus)");
        }
    }
}
