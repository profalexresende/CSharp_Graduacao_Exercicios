using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrato_sobrecarga_sobrescrita
{
    class PagamentoCartao : Pagamento
    {
        public override void ProcessarPagamento()
        {
            Console.WriteLine($"Pagamento de R$ {Valor} realizado no cartão à vista.");
        }

        // Sobrecarga com parcelas
        public void ProcessarPagamento(int parcelas)
        {
            Console.WriteLine($"Pagamento de R$ {Valor} realizado no cartão em {parcelas}x de R$ {Valor / parcelas:F2}.");
        }
    }
}
