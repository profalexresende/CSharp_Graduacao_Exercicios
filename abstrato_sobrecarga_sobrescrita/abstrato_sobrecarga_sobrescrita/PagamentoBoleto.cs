using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrato_sobrecarga_sobrescrita
{
    class PagamentoBoleto : Pagamento
    {
        public override void ProcessarPagamento()
        {
            Console.WriteLine($"Pagamento de R$ {Valor} realizado via boleto.");
        }
    }
}
