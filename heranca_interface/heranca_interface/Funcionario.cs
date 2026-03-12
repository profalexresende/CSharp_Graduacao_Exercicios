using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca_interface
{
     class Funcionario
    
    {
        protected string nome;
        protected decimal salario;

        public Funcionario(string nome, decimal salario)
        {
            this.nome = nome;
            this.salario = salario;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {nome} | Salário base: R$ {salario:F2}");
        }

        public virtual decimal CalcularSalarioFinal()
        {
            return salario;
        }
    }
}
