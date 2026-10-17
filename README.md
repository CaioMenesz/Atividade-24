# StreamingFlix

## Visão geral

O **StreamingFlix** é uma aplicação em C# (.NET) que reúne as regras de negócio de uma plataforma de streaming fictícia. As regras ficam na classe `PlanoStreamingService` e são cobertas por testes unitários com xUnit.

### Regras implementadas

| Método | O que faz |
|---|---|
| `ObterClassificacaoPorQualidade(int telasSimultaneas)` | Retorna o nome do plano conforme o número de telas simultâneas: 1 → `BÁSICO`, 2 → `PADRÃO`, 4 ou mais → `PREMIUM`. Outros valores retornam `INDEFINIDO`. |
| `CalcularMensalidadeComDesconto(decimal valorBase, int mesesContratados)` | Aplica 10% de desconto para 6 a 11 meses contratados e 20% para 12 meses ou mais. Abaixo de 6 meses retorna o valor base. |
| `PodeAcessarConteudoAdulto(int idade, bool controleParentalAtivo)` | Retorna `true` somente se a idade for 18 ou mais **e** o controle parental estiver desativado. |

### Estrutura do repositório

```
StreamingFlix/
├── StreamingFlix.slnx                # Solução
├── StreamingFlix.App/                # Aplicação (console) e regras de negócio
│   ├── PlanoStreamingService.cs
│   └── Program.cs
└── StreamingFlix.Tests/              # Testes unitários (xUnit)
    └── PlanoStreamingServiceTests.cs
```

## Requisitos técnicos

| Requisito | Versão |
|---|---|
| [.NET SDK](https://dotnet.microsoft.com/download) | **10.0** (target framework `net10.0`) |
| Git | Qualquer versão recente |
| Sistema operacional | Windows, Linux ou macOS |

Pacotes de teste, restaurados automaticamente pelo NuGet: `xunit` 2.9.3, `xunit.runner.visualstudio` 3.1.4, `Microsoft.NET.Test.Sdk` 17.14.1 e `coverlet.collector` 6.0.4.

Para conferir o SDK instalado:

```bash
dotnet --version
```

A saída deve começar com `10.`.

## Como clonar e rodar a aplicação

1. **Clone o repositório:**

   ```bash
   git clone https://github.com/CaioMenesz/Atividade-24.git
   ```

2. **Entre na pasta do projeto.** Use a pasta que contém o arquivo `StreamingFlix.slnx`:

   ```bash
   cd Atividade-24
   ```

3. **Restaure as dependências:**

   ```bash
   dotnet restore
   ```

4. **Compile a solução:**

   ```bash
   dotnet build
   ```

5. **Execute a aplicação:**

   ```bash
   dotnet run --project StreamingFlix.App
   ```

   O `Program.cs` atual apenas imprime `Hello, World!`. As regras de negócio são exercitadas pelos testes unitários.

## Como executar os testes unitários

Na raiz do repositório, onde fica o `StreamingFlix.slnx`:

```bash
dotnet test
```

Esse comando restaura, compila e executa todos os testes da solução.

Outras formas úteis:

```bash
# Rodar apenas o projeto de testes
dotnet test StreamingFlix.Tests

# Saída detalhada, com o nome de cada teste
dotnet test StreamingFlix.Tests --logger "console;verbosity=detailed"

# Rodar um único teste pelo nome
dotnet test StreamingFlix.Tests --filter "FullyQualifiedName~ClassificacaoPlanos"

# Coletar cobertura de código
dotnet test StreamingFlix.Tests --collect:"XPlat Code Coverage"
```

### Resultado esperado

Ao final da execução, o resumo mostra os totais de testes aprovados, com falha e ignorados. Se algum teste falhar, a mensagem indica o valor esperado, o valor obtido e a linha do teste.
