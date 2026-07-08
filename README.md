# 🚀 Meu Aprendizado em C# & Testes Unitários

Este repositório foi criado para centralizar e organizar meus estudos práticos de C# e .NET. Ele contém a resolução de desafios de plataformas de programação, laboratórios de sintaxe e uma estrutura dedicada a testes unitários.

Atualmente, concluí com sucesso o **Primeiro Módulo** da formação de C# da [Dio.me](https://www.dio.me/) e o projeto continuará evoluindo à medida que eu avançar para os próximos níveis!

---

## 📁 Estrutura do Projeto

O repositório está dividido utilizando o padrão de arquitetura que separa o código de execução dos códigos de testes:

```text
├── src/
│   └── MeuTeste/                  # Projeto principal (Console Application)
│       ├── Array.cs               # Estudos sobre arrays estruturados
│       ├── Beecrowd2006.cs        # Resolução do desafio 2006 da Beecrowd
│       ├── Calculadora.cs         # Lógica de operações matemáticas básicas
│       ├── Condicional.cs         # Estudos sobre estruturas if/else
│       ├── Desafio1Dio.cs         # Primeiro desafio prático da DIO.me
│       ├── Desafio2Dio.cs         # Segundo desafio prático da DIO.me
│       ├── Estacionamento.cs      # Sistema de gerenciamento de vagas de estacionamento
│       ├── Laco.cs                # Estudos sobre laços de repetição (while, do-while, for)
│       ├── SwitchCase.cs          # Estudos sobre a estrutura de controle switch-case
│       └── Program.cs             # Ponto de entrada (Main) do aplicativo
│
├── tests/
│   └── MeuTeste.Tests/            # Projeto de Testes Unitários
│       ├── Beecrowd2006Test.cs    # Testes para validar o desafio Beecrowd
│       ├── CalculadoraTest.cs     # Testes das operações da calculadora
│       ├── CondicionalTest.cs     # Testes de fluxos condicionais
│       ├── LacoTest.cs            # Testes de comportamentos de loops
│       └── SwitchCaseTest.cs      # Testes para fluxos baseados em switch
│
├── .gitignore                     # Arquivo para ignorar arquivos temporários (ex: bin/, obj/)
└── MeuProjetoTest.slnx            # Arquivo de Solução do Visual Studio (gerencia os projetos)
```
# 🎯 Conteúdos Praticados
## 🧩 Fundamentos da Linguagem & Aprendizado Autónomo
Estruturas de Controle: Prática extensiva de tomadas de decisão (Condicional.cs, SwitchCase.cs) e controles de fluxo repetitivos (Laco.cs).

Manipulação de Dados: Uso de coleções, arrays e listas dinâmicas (Array.cs, Estacionamento.cs) aplicando conceitos de entrada e saída com formatação segura de dados (int.TryParse e formatação de casas decimais).

## 🏆 Desafios de Plataformas
DIO.me: Códigos desenvolvidos para cumprir os requisitos dos desafios práticos do primeiro módulo (Desafio1Dio.cs e Desafio2Dio.cs).

Beecrowd: Resolução e otimização algorítmica para maratonas de programação (Beecrowd2006.cs).

## 🧪 Testes Unitários
Para garantir o pleno funcionamento das regras de negócio do sistema e entender como funciona o ecossistema de engenharia de software real, o projeto conta com uma camada dedicada de testes automatizados (tests/).

Validação de cenários ideais e de exceção.

Garantia de que alterações no código principal não quebrem funcionalidades já existentes.

## 🛠️ Tecnologias Utilizadas
Linguagem: C#

Framework: .NET Core / .NET SDK

IDE: Visual Studio / Visual Studio Code

Testes: xUnit / MSTest (de acordo com o framework configurado no .csproj)

## 🏎️ Como Executar o Projeto
Abra o terminal na pasta raiz do projeto.

Para rodar a aplicação principal:

Bash
dotnet run --project src/MeuTeste/MeuTeste.csproj
Para executar todos os testes unitários instalados e verificar os resultados:

Bash
dotnet test