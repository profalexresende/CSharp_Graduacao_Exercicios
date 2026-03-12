using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrato_sobrecarga_sobrescrita
{
    abstract class Pagamento
    {
        public decimal Valor { get; set; }
        public abstract void ProcessarPagamento();
    }
}
