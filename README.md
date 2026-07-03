# 🏋️‍♂️ Sistema de Cadastro de Treinos - AcademiaApp

Este repositório demonstra a evolução de um sistema de gerenciamento de treinos de academia, aplicando os conceitos fundamentais de **Programação Orientada a Objetos (POO)**. O projeto foi originalmente estruturado em **Java** e, posteriormente, migrado e evoluído para **C# (.NET)** para fins de estudo, comparação de sintaxe e adoção de boas práticas (*Clean Code*).

---

## 🚀 Evolução do Projeto

### ☕ Versão 1: Java (Encapsulamento e Composição)
Na primeira etapa desenvolvida em Java, o foco foi aplicar os padrões tradicionais de mercado:
* **Encapsulamento:** Atributos definidos como `private` com métodos *Getters* e *Setters* manuais, incluindo regras de validação para impedir entradas inválidas (como séries ou repetições zeradas/negativas).
* **Composição Rígida:** A classe `Treino` controlava de forma fixa a quantidade de objetos `Exercicio` que recebia.

### ⚔️ Versão 2: C# / .NET (Propriedades, Listas Dinâmicas e Interatividade)
Na migração para C#, o código foi refatorado para reduzir o código repetitivo (*boilerplate*) e tornar a aplicação flexível:
* **Propriedades Automáticas (`{ get; set; }`):** Substituição de dezenas de linhas de Getters/Setters manuais por propriedades limpas e nativas do C#.
* **Coleções Dinâmicas (`List<T>`):** Em vez de uma composição engessada com número fixo de exercícios, o sistema passou a utilizar uma lista dinâmica que aceita n treinos.
* **Interatividade via Terminal:** Implementação de um loop com `while` e `Console.ReadLine()` (`int.Parse`) para permitir que o usuário cadastre quantos exercícios quiser direto pelo teclado antes de rodar a ficha completa.

---

## 🛠️ Tecnologias e Conceitos Aplicados

* **Linguagens:** Java / C# (.NET)
* **Paradigma:** Programação Orientada a Objetos (Classes, Objetos, Construtores, Encapsulamento)
* **Estrutura de Dados:** Listas Dinâmicas (`List`) e Laços de Repetição (`while`, `foreach`)
* **Boas Práticas:** Clean Code, tipagem forte e legibilidade de código.
