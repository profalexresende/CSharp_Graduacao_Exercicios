using heranca_interface;

bool sair = false;

while (!sair)
{
    Console.WriteLine("\n=== SISTEMA DE FUNCIONÁRIOS ===");
    Console.WriteLine("1 - Cadastrar e exibir Gerente");
    Console.WriteLine("2 - Cadastrar e exibir Desenvolvedor");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha: ");
    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "0":
            sair = true;
            break;

        case "1":
            Console.Write("Nome do Gerente: ");
            string nomeG = Console.ReadLine();
            Console.Write("Salário base: R$ ");
            decimal salarioG = decimal.Parse(Console.ReadLine());

            Gerente gerente = new Gerente(nomeG, salarioG);
            gerente.ExibirDados();
            Console.WriteLine($"Salário final: R$ {gerente.CalcularSalarioFinal():F2}");
            gerente.CalcularBeneficio();
            break;

        case "2":
            Console.Write("Nome do Desenvolvedor: ");
            string nomeD = Console.ReadLine();
            Console.Write("Salário base: R$ ");
            decimal salarioD = decimal.Parse(Console.ReadLine());

            Desenvolvedor dev = new Desenvolvedor(nomeD, salarioD);
            dev.ExibirDados();
            Console.WriteLine($"Salário final: R$ {dev.CalcularSalarioFinal():F2}");
            dev.CalcularBeneficio();
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}

Console.WriteLine("Encerrando...");
 