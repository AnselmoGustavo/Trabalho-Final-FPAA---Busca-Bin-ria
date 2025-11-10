namespace BibliotecaDigital
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            // Inicializa o acervo da biblioteca
            Livro[] acervo = InicializarAcervo();

            ExibirCabecalho();

            bool continuar = true;
            while (continuar)
            {
                ExibirMenu();
                string opcao = Console.ReadLine() ?? "";

                switch (opcao)
                {
                    case "1":
                        ExibirAcervo(acervo);
                        break;
                    case "2":
                        BuscarLivroIterativo(acervo);
                        break;
                    case "3":
                        BuscarLivroRecursivo(acervo);
                        break;
                    case "4":
                        CompararAlgoritmos(acervo);
                        break;
                    case "5":
                        DemonstracaoPassoAPasso(acervo);
                        break;
                    case "6":
                        AnalisarComplexidade(acervo);
                        break;
                    case "0":
                        continuar = false;
                        Console.WriteLine("\nEncerrando o sistema...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida!");
                        break;
                }

                if (continuar)
                {
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }

        static void ExibirCabecalho()
        {
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════════════════════════════════");
            Console.WriteLine("         SISTEMA DE BIBLIOTECA DIGITAL - BUSCA BINÁRIA");
            Console.WriteLine("═══════════════════════════════════════════════════════════════════");
            Console.WriteLine("  Demonstração: Técnica de Divisão e Conquista");
            Console.WriteLine("  Disciplina: Fundamentos de Projeto e Análise de Algoritmos");
            Console.WriteLine("  PUC Minas - Sistemas de Informação - 2025");
            Console.WriteLine("═══════════════════════════════════════════════════════════════════\n");
        }

        static void ExibirMenu()
        {
            Console.Clear();
            ExibirCabecalho();
            Console.WriteLine("MENU PRINCIPAL:");
            Console.WriteLine("  1 - Exibir todo o acervo");
            Console.WriteLine("  2 - Buscar livro (Busca Binária Iterativa)");
            Console.WriteLine("  3 - Buscar livro (Busca Binária Recursiva)");
            Console.WriteLine("  4 - Comparar: Busca Binária vs Busca Linear");
            Console.WriteLine("  5 - Demonstração passo a passo");
            Console.WriteLine("  6 - Análise de complexidade");
            Console.WriteLine("  0 - Sair");
            Console.WriteLine("\nEscolha uma opção: ");
        }

        static Livro[] InicializarAcervo()
        {
            return new Livro[]
            {
                new Livro(1001, "O Império Final", "Brandon Sanderson", 2006, "Mistborn Era 1"),
                new Livro(1015, "O Poço da Ascensão", "Brandon Sanderson", 2007, "Mistborn Era 1"),
                new Livro(1023, "O Herói das Eras", "Brandon Sanderson", 2008, "Mistborn Era 1"),
                new Livro(1035, "Mistborn: Secret History", "Brandon Sanderson", 2016, "Mistborn Novella"),
                new Livro(1045, "O Décimo Primeiro Metal", "Brandon Sanderson", 2011, "Mistborn Conto"),
                new Livro(1055, "A Liga da Lei", "Brandon Sanderson", 2011, "Mistborn Era 2"),
                new Livro(1067, "As Sombras de Si Mesmo", "Brandon Sanderson", 2015, "Mistborn Era 2"),
                new Livro(1075, "Arcanum Ilimitado (Seleção Cosmere)", "Brandon Sanderson", 2016, "Coletânea Cosmere"),
                new Livro(1080, "Os Braceletes da Perdição", "Brandon Sanderson", 2016, "Mistborn Era 2"),
                new Livro(1095, "The Lost Metal", "Brandon Sanderson", 2022, "Mistborn Era 2"),
                new Livro(1105, "O Nome do Vento", "Patrick Rothfuss", 2007, "Kingkiller Chronicle"),
                new Livro(1120, "O Temor do Sábio", "Patrick Rothfuss", 2011, "Kingkiller Chronicle"),
                new Livro(1132, "A Música do Silêncio", "Patrick Rothfuss", 2015, "Kingkiller Chronicle"),
                new Livro(1144, "O Estreito Caminho Entre Desejos", "Patrick Rothfuss", 2023, "Kingkiller Chronicle"),
                new Livro(1155, "O Caminho dos Reis", "Brandon Sanderson", 2010, "Stormlight Archive"),
                new Livro(1165, "Palavras de Radiância", "Brandon Sanderson", 2014, "Stormlight Archive"),
                new Livro(1175, "Oathbringer", "Brandon Sanderson", 2017, "Stormlight Archive"),
                new Livro(1185, "Edgedancer", "Brandon Sanderson", 2017, "Stormlight Novella"),
                new Livro(1195, "Dawnshard", "Brandon Sanderson", 2020, "Stormlight Novella"),
                new Livro(1205, "Rhythm of War", "Brandon Sanderson", 2020, "Stormlight Archive")
            };
        }

        static void ExibirAcervo(Livro[] acervo)
        {
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════════════════════════════════");
            Console.WriteLine($"  ACERVO COMPLETO ({acervo.Length} livros)");
            Console.WriteLine("  * Array ordenado por ID (pré-requisito da busca binária)");
            Console.WriteLine("═══════════════════════════════════════════════════════════════════\n");

            for (int i = 0; i < acervo.Length; i++)
            {
                Console.WriteLine($"  [{i:D2}] {acervo[i]}");
            }
        }

        static void BuscarLivroIterativo(Livro[] acervo)
        {
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════════════════════════════════");
            Console.WriteLine("  BUSCA BINÁRIA - VERSÃO ITERATIVA");
            Console.WriteLine("═══════════════════════════════════════════════════════════════════\n");

            Console.Write("Digite o ID do livro que deseja buscar: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                DateTime inicio = DateTime.Now;
                int indice = AlgoritmosBusca.BuscaBinaria(acervo, id);
                TimeSpan tempo = DateTime.Now - inicio;

                Console.WriteLine($"\n--- RESULTADO ---");
                if (indice != -1)
                {
                    Console.WriteLine($"✓ Livro encontrado na posição {indice}!");
                    Console.WriteLine($"\n{acervo[indice]}");
                }
                else
                {
                    Console.WriteLine($"✗ Livro com ID {id} não encontrado no acervo.");
                }

                Console.WriteLine($"\n--- ANÁLISE DE DESEMPENHO ---");
                Console.WriteLine($"Comparações realizadas: {AlgoritmosBusca.NumeroComparacoes}");
                Console.WriteLine($"Complexidade teórica máxima: {AlgoritmosBusca.ComplexidadeTeorica(acervo.Length)} comparações");
                Console.WriteLine($"Tempo de execução: {tempo.TotalMilliseconds:F4} ms");
            }
            else
            {
                Console.WriteLine("\nID inválido!");
            }
        }

        static void BuscarLivroRecursivo(Livro[] acervo)
        {
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════════════════════════════════");
            Console.WriteLine("  BUSCA BINÁRIA - VERSÃO RECURSIVA");
            Console.WriteLine("═══════════════════════════════════════════════════════════════════\n");

            Console.Write("Digite o ID do livro que deseja buscar: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                DateTime inicio = DateTime.Now;
                int indice = AlgoritmosBusca.BuscaBinariaRecursiva(acervo, id, 0, acervo.Length - 1);
                TimeSpan tempo = DateTime.Now - inicio;

                Console.WriteLine($"\n--- RESULTADO ---");
                if (indice != -1)
                {
                    Console.WriteLine($"✓ Livro encontrado na posição {indice}!");
                    Console.WriteLine($"\n{acervo[indice]}");
                }
                else
                {
                    Console.WriteLine($"✗ Livro com ID {id} não encontrado no acervo.");
                }

                Console.WriteLine($"\n--- ANÁLISE DE DESEMPENHO ---");
                Console.WriteLine($"Chamadas recursivas: {AlgoritmosBusca.NumeroComparacoes}");
                Console.WriteLine($"Complexidade teórica máxima: {AlgoritmosBusca.ComplexidadeTeorica(acervo.Length)} chamadas");
                Console.WriteLine($"Tempo de execução: {tempo.TotalMilliseconds:F4} ms");
            }
            else
            {
                Console.WriteLine("\nID inválido!");
            }
        }

        static void CompararAlgoritmos(Livro[] acervo)
        {
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════════════════════════════════");
            Console.WriteLine("  COMPARAÇÃO: BUSCA BINÁRIA vs BUSCA LINEAR");
            Console.WriteLine("═══════════════════════════════════════════════════════════════════\n");

            Console.Write("Digite o ID do livro para comparação: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                // Busca Binária
                DateTime inicioBinaria = DateTime.Now;
                int indiceBinaria = AlgoritmosBusca.BuscaBinaria(acervo, id);
                TimeSpan tempoBinaria = DateTime.Now - inicioBinaria;
                int compBinaria = AlgoritmosBusca.NumeroComparacoes;

                // Busca Linear
                DateTime inicioLinear = DateTime.Now;
                int indiceLinear = AlgoritmosBusca.BuscaLinear(acervo, id);
                TimeSpan tempoLinear = DateTime.Now - inicioLinear;
                int compLinear = AlgoritmosBusca.NumeroComparacoes;

                Console.WriteLine("\n┌─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine("│                     BUSCA BINÁRIA (Divisão e Conquista)        │");
                Console.WriteLine("└─────────────────────────────────────────────────────────────────┘");
                Console.WriteLine($"  Resultado: {(indiceBinaria != -1 ? $"Encontrado na posição {indiceBinaria}" : "Não encontrado")}");
                Console.WriteLine($"  Comparações: {compBinaria}");
                Console.WriteLine($"  Complexidade: O(log n) = {AlgoritmosBusca.ComplexidadeTeorica(acervo.Length)} (máximo)");
                Console.WriteLine($"  Tempo: {tempoBinaria.TotalMilliseconds:F4} ms");

                Console.WriteLine("\n┌─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine("│                          BUSCA LINEAR                           │");
                Console.WriteLine("└─────────────────────────────────────────────────────────────────┘");
                Console.WriteLine($"  Resultado: {(indiceLinear != -1 ? $"Encontrado na posição {indiceLinear}" : "Não encontrado")}");
                Console.WriteLine($"  Comparações: {compLinear}");
                Console.WriteLine($"  Complexidade: O(n) = {acervo.Length} (máximo)");
                Console.WriteLine($"  Tempo: {tempoLinear.TotalMilliseconds:F4} ms");

                Console.WriteLine("\n┌─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine("│                         VANTAGEM                                │");
                Console.WriteLine("└─────────────────────────────────────────────────────────────────┘");
                double reducaoComparacoes = ((double)(compLinear - compBinaria) / compLinear) * 100;
                Console.WriteLine($"  A Busca Binária realizou {reducaoComparacoes:F1}% menos comparações!");
                Console.WriteLine($"  Comparações evitadas: {compLinear - compBinaria}");
            }
            else
            {
                Console.WriteLine("\nID inválido!");
            }
        }

        static void DemonstracaoPassoAPasso(Livro[] acervo)
        {
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════════════════════════════════");
            Console.WriteLine("  DEMONSTRAÇÃO PASSO A PASSO - BUSCA BINÁRIA");
            Console.WriteLine("═══════════════════════════════════════════════════════════════════\n");

            Console.Write("Digite o ID do livro para demonstração: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine($"\nBuscando livro com ID: {id}");
                Console.WriteLine($"Tamanho do array: {acervo.Length}\n");

                int esquerda = 0;
                int direita = acervo.Length - 1;
                int passo = 1;
                bool encontrado = false;

                while (esquerda <= direita)
                {
                    int meio = esquerda + (direita - esquerda) / 2;

                    Console.WriteLine($"--- PASSO {passo} ---");
                    Console.WriteLine($"Intervalo: [{esquerda}..{direita}] (tamanho: {direita - esquerda + 1})");
                    Console.WriteLine($"Meio = {meio}");
                    Console.WriteLine($"Elemento no meio: ID {acervo[meio].Id} - {acervo[meio].Titulo}");

                    if (acervo[meio].Id == id)
                    {
                        Console.WriteLine($"\n✓ ENCONTRADO! O livro está na posição {meio}");
                        Console.WriteLine($"\n{acervo[meio]}");
                        encontrado = true;
                        break;
                    }
                    else if (acervo[meio].Id > id)
                    {
                        Console.WriteLine($"ID {acervo[meio].Id} > {id} → Buscar na metade ESQUERDA");
                        direita = meio - 1;
                    }
                    else
                    {
                        Console.WriteLine($"ID {acervo[meio].Id} < {id} → Buscar na metade DIREITA");
                        esquerda = meio + 1;
                    }

                    Console.WriteLine();
                    passo++;
                }

                if (!encontrado)
                {
                    Console.WriteLine($"\n✗ Livro com ID {id} não encontrado no acervo.");
                }

                Console.WriteLine($"\nTotal de passos (comparações): {passo}");
                Console.WriteLine($"Complexidade: O(log {acervo.Length}) = {AlgoritmosBusca.ComplexidadeTeorica(acervo.Length)} máximo");
            }
            else
            {
                Console.WriteLine("\nID inválido!");
            }
        }

        static void AnalisarComplexidade(Livro[] acervo)
        {
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════════════════════════════════");
            Console.WriteLine("  ANÁLISE DE COMPLEXIDADE - BUSCA BINÁRIA");
            Console.WriteLine("═══════════════════════════════════════════════════════════════════\n");

            Console.WriteLine("COMPLEXIDADE TEMPORAL:");
            Console.WriteLine("  • Melhor caso: O(1) - elemento está no meio");
            Console.WriteLine("  • Caso médio: O(log n)");
            Console.WriteLine("  • Pior caso: O(log n) - elemento está em uma extremidade ou não existe");
            Console.WriteLine($"\n  Para n = {acervo.Length} elementos:");
            Console.WriteLine($"  Máximo de comparações = ⌈log₂({acervo.Length})⌉ = {AlgoritmosBusca.ComplexidadeTeorica(acervo.Length)}");

            Console.WriteLine("\nCOMPLEXIDADE ESPACIAL (MEMÓRIA):");
            Console.WriteLine("  • Versão Iterativa: O(1) - usa apenas variáveis auxiliares");
            Console.WriteLine("  • Versão Recursiva: O(log n) - devido à pilha de recursão");

            Console.WriteLine("\nPRÉ-REQUISITOS:");
            Console.WriteLine("  ✓ Array deve estar ORDENADO");
            Console.WriteLine("  ✓ Acesso direto aos elementos (índice)");

            Console.WriteLine("\nTÉCNICA: DIVISÃO E CONQUISTA");
            Console.WriteLine("  1. Divisão: Divide o array ao meio");
            Console.WriteLine("  2. Conquista: Compara o elemento do meio com o alvo");
            Console.WriteLine("  3. Combina: Não há fase de combinação");
            Console.WriteLine("  4. Recursão: Aplica o mesmo processo na metade relevante");

            Console.WriteLine("\nCOMPARAÇÃO COM BUSCA LINEAR:");
            Console.WriteLine($"  Busca Linear: O(n) = até {acervo.Length} comparações");
            Console.WriteLine($"  Busca Binária: O(log n) = até {AlgoritmosBusca.ComplexidadeTeorica(acervo.Length)} comparações");
            Console.WriteLine($"  Ganho de eficiência: {(double)acervo.Length / AlgoritmosBusca.ComplexidadeTeorica(acervo.Length):F2}x mais rápida (pior caso)");

            Console.WriteLine("\nEXEMPLOS DE CRESCIMENTO:");
            int[] tamanhos = { 10, 100, 1000, 10000, 100000, 1000000 };
            Console.WriteLine("\n  Tamanho (n)  | Busca Linear | Busca Binária | Vantagem");
            Console.WriteLine("  ──────────────────────────────────────────────────────────");
            foreach (int n in tamanhos)
            {
                int logN = (int)Math.Ceiling(Math.Log2(n));
                double vantagem = (double)n / logN;
                Console.WriteLine($"  {n,12:N0} | {n,12:N0} | {logN,13} | {vantagem,7:F1}x");
            }
        }
    }
}
