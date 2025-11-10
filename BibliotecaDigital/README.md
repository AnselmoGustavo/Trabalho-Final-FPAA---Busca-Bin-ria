# Sistema de Biblioteca Digital - Busca Binária

## 📚 Sobre o Projeto

Este projeto foi desenvolvido como trabalho acadêmico para a disciplina de **Fundamentos de Projeto e Análise de Algoritmos** do curso de Sistemas de Informação da PUC Minas.

O objetivo é demonstrar de forma prática o funcionamento da **Busca Binária**, uma técnica clássica de **Divisão e Conquista**, através de uma aplicação de console que simula um sistema de biblioteca digital com foco em literatura de fantasia épica.

O acervo agora contém títulos das séries **Mistborn (Era 1, Era 2 e Novellas)**, **The Stormlight Archive** (incluindo novellas) e **Kingkiller Chronicle** de Patrick Rothfuss. Esses livros foram organizados por ID numérico para permitir a busca eficiente. O tema literário torna a demonstração mais envolvente sem alterar os conceitos fundamentais do algoritmo.

## 🎯 Objetivos

- Implementar o algoritmo de Busca Binária (versões iterativa e recursiva)
- Demonstrar a técnica de Divisão e Conquista
- Analisar a complexidade do algoritmo
- Comparar com a Busca Linear
- Apresentar exemplos práticos de uso

## 🏗️ Estrutura do Projeto

```
BibliotecaDigital/
├── BibliotecaDigital.csproj    # Arquivo de configuração do projeto
├── Program.cs                   # Programa principal com menu interativo
├── Livro.cs                     # Modelo de dados (Livro)
├── AlgoritmosBusca.cs          # Implementações dos algoritmos
└── README.md                    # Este arquivo
```

## 🔧 Tecnologias Utilizadas

- **Linguagem**: C# (.NET 8.0)
- **IDE Recomendada**: Visual Studio 2022 ou Visual Studio Code
- **Console Application**

## 🚀 Como Executar

### Pré-requisitos
- .NET 8.0 SDK instalado

### Passos

1. Navegue até o diretório do projeto:
```bash
cd BibliotecaDigital
```

2. Compile e execute o projeto:
```bash
dotnet run
```

## 📖 Funcionalidades

O sistema oferece um menu interativo com as seguintes opções:

1. **Exibir todo o acervo** - Mostra todos os 20 livros de fantasia ordenados por ID
2. **Buscar livro (Iterativa)** - Busca usando implementação iterativa
3. **Buscar livro (Recursiva)** - Busca usando implementação recursiva
4. **Comparar algoritmos** - Compara Busca Binária vs Busca Linear
5. **Demonstração passo a passo** - Mostra cada iteração do algoritmo
6. **Análise de complexidade** - Apresenta análise teórica completa

## 🧮 Análise do Algoritmo

### Busca Binária

**Complexidade Temporal:**
- Melhor caso: O(1) - elemento está no meio
- Caso médio: O(log n)
- Pior caso: O(log n)

**Complexidade Espacial:**
- Iterativa: O(1)
- Recursiva: O(log n) - pilha de recursão

**Pré-requisitos:**
- Array deve estar ordenado
- Acesso direto aos elementos por índice

### Técnica: Divisão e Conquista

1. **Divisão**: Divide o array ao meio
2. **Conquista**: Compara o elemento do meio com o alvo
3. **Combina**: Não há fase de combinação
4. **Recursão**: Aplica o mesmo processo na metade relevante

### Comparação com Busca Linear

Para um array de 20 elementos:
- **Busca Linear**: até 20 comparações O(n)
- **Busca Binária**: até 5 comparações O(log n)
- **Vantagem**: 4x mais eficiente

## 📊 Exemplo de Uso

```
Digite o ID do livro que deseja buscar: 1055

--- RESULTADO ---
✓ Livro encontrado na posição 6!

ID: 1055 | A Liga da Lei - Brandon Sanderson (2011) [Mistborn Era 2]

--- ANÁLISE DE DESEMPENHO ---
Comparações realizadas: 4
Complexidade teórica máxima: 5 comparações
Tempo de execução: 0.00XX ms
```

Outro exemplo (busca que não existe):

```
Digite o ID do livro que deseja buscar: 1300

--- RESULTADO ---
✗ Livro com ID 1300 não encontrado no acervo.

--- ANÁLISE DE DESEMPENHO ---
Comparações realizadas: 5
Complexidade teórica máxima: 5 comparações
```

## 🎓 Contexto Acadêmico

Este projeto faz parte do conteúdo da disciplina que aborda:
- Análise de Algoritmos
- Técnicas de Projeto de Algoritmos
- Divisão e Conquista
- Complexidade Computacional (Notação Big O)
- Recursividade

## 👥 Autores

- Ana Beatriz Costa Viana
- Gustavo Anselmo Santos Silva
- Karina Oliveira Bicalho de Almeida

**Orientadora**: Prof.ª Roselene Henrique Pereira Costa

**Instituição**: Pontifícia Universidade Católica de Minas Gerais  
**Curso**: Sistemas de Informação  
**Ano**: 2025

## 📝 Observações

- O acervo contém 20 livros de fantasia épica (Mistborn, Stormlight e Kingkiller Chronicle)
- Todos os IDs estão entre 1001 e 1205 e estão em ordem crescente (pré-requisito da busca binária)
- O sistema conta as comparações para fins didáticos
- Implementações iterativa e recursiva disponíveis
- A comparação com a busca linear evidencia o ganho prático (redução de ~75% no pior caso para n=20)

## 📚 Referências

### Algoritmos e Análise
- CORMEN, Thomas H. et al. **Algoritmos: Teoria e Prática**. 3. ed. Rio de Janeiro: Elsevier, 2012.
- TENEMBAUM, Aaron M; AUGENSTEIN, Moshe J; LANGSAM, Yedidyah. **Estrutura de Dados Usando C**. São Paulo: MAKRON Books, 1995.
- DE PAULA, Marlubia Corrêa; VIALI, Lori; RIZZON, Eliamar Ceresoli. **Contexto Histórico Do Método de Divisão e Conquista**. Vetor, Rio Grande, 2018.

### Obras Literárias (Contexto do Acervo)
- SANDERSON, Brandon. **Mistborn Series** (2006–2022).
- SANDERSON, Brandon. **The Stormlight Archive** (2010–2020 + Novellas).
- ROTHFUSS, Patrick. **The Kingkiller Chronicle** (2007–2023).

As obras literárias são utilizadas apenas como dados de exemplo para demonstrar o algoritmo de busca binária.
