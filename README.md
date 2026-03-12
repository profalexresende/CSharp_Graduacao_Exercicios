# 💻 Exercícios C# — POO com .NET

Exercícios práticos de **Programação Orientada a Objetos** em C# Console, desenvolvidos como atividade acadêmica.

---

## 📁 Projetos

### 1. Sistema de Pagamentos
> Conceitos: Classe Abstrata · Sobrescrita · Sobrecarga

### 2. Sistema de Funcionários
> Conceitos: Modificadores de Acesso · Herança · Interfaces

---

## 🔷 Exercício 1 — Sistema de Pagamentos

### Estrutura

```
Pagamento (abstract)
├── PagamentoCartao
│   ├── ProcessarPagamento()          → override (à vista)
│   └── ProcessarPagamento(parcelas)  → sobrecarga (parcelado)
└── PagamentoBoleto
    └── ProcessarPagamento()          → override
```

### Conceitos aplicados

| Conceito | Onde é usado |
|---|---|
| Classe abstrata | `Pagamento` com método `abstract` |
| Sobrescrita (`override`) | `PagamentoCartao` e `PagamentoBoleto` implementam `ProcessarPagamento()` |
| Sobrecarga | `PagamentoCartao` possui duas versões de `ProcessarPagamento()` |

### Menu de opções

```
=== SISTEMA DE PAGAMENTOS ===
1 - Pagar com Cartão (à vista)
2 - Pagar com Cartão (parcelado)
3 - Pagar com Boleto
0 - Sair
```

---

## 🔷 Exercício 2 — Sistema de Funcionários

### Estrutura

```
IBeneficio (interface)
└── CalcularBeneficio()

Funcionario (classe base)
├── Gerente   → bônus 20% + IBeneficio
└── Desenvolvedor → bônus 10% + IBeneficio
```

### Conceitos aplicados

| Conceito | Onde é usado |
|---|---|
| Modificadores de acesso | Atributos `protected` em `Funcionario`, métodos `public` |
| Herança | `Gerente` e `Desenvolvedor` herdam de `Funcionario` |
| Override | `CalcularSalarioFinal()` sobrescrito em cada subclasse |
| Interface | `IBeneficio` implementada por `Gerente` e `Desenvolvedor` |

### Regras de negócio

- **Gerente** → salário final = salário base + 20%
- **Desenvolvedor** → salário final = salário base + 10%

### Menu de opções

```
=== SISTEMA DE FUNCIONÁRIOS ===
1 - Cadastrar e exibir Gerente
2 - Cadastrar e exibir Desenvolvedor
0 - Sair
```

---

## 🚀 Como executar

### Pré-requisitos
- [.NET SDK](https://dotnet.microsoft.com/download) instalado

### Passos

```bash
# Clone o repositório
git clone https://github.com/seu-usuario/seu-repositorio.git

# Acesse a pasta do projeto desejado
cd SistemaPagamentos   # ou SistemaFuncionarios

# Execute
dotnet run
```

Ou abra o arquivo `.cs` no **Visual Studio**, cole no `Program.cs` de um projeto Console e pressione `F5`.

---

## 🛠️ Tecnologias

- C# / .NET
- Console Application

---

## 📚 Conteúdo Acadêmico

Exercícios desenvolvidos para a disciplina de **.NET**
Professor: Alex Sander
