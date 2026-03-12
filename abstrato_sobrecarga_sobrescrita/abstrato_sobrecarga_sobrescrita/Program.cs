using abstrato_sobrecarga_sobrescrita;

bool sair = false;

while (!sair)
{
    Console.WriteLine("\n=== SISTEMA DE PAGAMENTOS ===");
    Console.WriteLine("1 - Pagar com Cartão (à vista)");
    Console.WriteLine("2 - Pagar com Cartão (parcelado)");
    Console.WriteLine("3 - Pagar com Boleto");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha: ");
    string opcao = Console.ReadLine();

    if (opcao == "0") { sair = true; continue; }

    Console.Write("Digite o valor do pagamento: R$ ");
    decimal valor = decimal.Parse(Console.ReadLine());

    switch (opcao)
    {
        case "1":
            var cartaoVista = new PagamentoCartao { Valor = valor };
            cartaoVista.ProcessarPagamento();
            break;

        case "2":
            Console.Write("Número de parcelas: ");
            int parcelas = int.Parse(Console.ReadLine());
            var cartaoParcelado = new PagamentoCartao { Valor = valor };
            cartaoParcelado.ProcessarPagamento(parcelas); // sobrecarga
            break;

        case "3":
            var boleto = new PagamentoBoleto { Valor = valor };
            boleto.ProcessarPagamento();
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}

Console.WriteLine("Encerrando...");