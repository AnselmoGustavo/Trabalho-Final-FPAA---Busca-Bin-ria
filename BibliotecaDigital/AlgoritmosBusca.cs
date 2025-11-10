namespace BibliotecaDigital
{
    /// <summary>
    /// Classe responsável por implementar algoritmos de busca.
    /// Demonstra a técnica de Divisão e Conquista através da Busca Binária.
    /// </summary>
    public static class AlgoritmosBusca
    {
        // Contador para fins didáticos - mostra quantas comparações foram feitas
        public static int NumeroComparacoes { get; private set; }

        /// <summary>
        /// Implementação da Busca Binária (Iterativa)
        /// Complexidade: O(log n)
        /// Pré-condição: O array deve estar ordenado
        /// 
        /// TÉCNICA: DIVISÃO E CONQUISTA
        /// - Divide: Encontra o elemento do meio
        /// - Conquista: Compara com o alvo e decide qual metade seguir
        /// - Combina: Não há combinação necessária
        /// </summary>
        public static int BuscaBinaria(Livro[] array, int idProcurado)
        {
            NumeroComparacoes = 0;
            int esquerda = 0;
            int direita = array.Length - 1;

            while (esquerda <= direita)
            {
                // Calcula o índice do meio
                int meio = esquerda + (direita - esquerda) / 2;
                NumeroComparacoes++;

                // Verifica se encontrou o elemento
                if (array[meio].Id == idProcurado)
                {
                    return meio; // Retorna o índice do elemento encontrado
                }

                // Se o elemento procurado é menor, ignora a metade direita
                if (array[meio].Id > idProcurado)
                {
                    direita = meio - 1;
                }
                // Se o elemento procurado é maior, ignora a metade esquerda
                else
                {
                    esquerda = meio + 1;
                }
            }

            // Elemento não encontrado
            return -1;
        }

        /// <summary>
        /// Implementação da Busca Binária (Recursiva)
        /// Complexidade: O(log n)
        /// Demonstra a natureza recursiva da Divisão e Conquista
        /// </summary>
        public static int BuscaBinariaRecursiva(Livro[] array, int idProcurado, int esquerda, int direita)
        {
            NumeroComparacoes++;

            // Caso base: elemento não encontrado
            if (esquerda > direita)
            {
                return -1;
            }

            // Calcula o meio
            int meio = esquerda + (direita - esquerda) / 2;

            // Caso base: elemento encontrado
            if (array[meio].Id == idProcurado)
            {
                return meio;
            }

            // Chamada recursiva: busca na metade esquerda
            if (array[meio].Id > idProcurado)
            {
                return BuscaBinariaRecursiva(array, idProcurado, esquerda, meio - 1);
            }

            // Chamada recursiva: busca na metade direita
            return BuscaBinariaRecursiva(array, idProcurado, meio + 1, direita);
        }

        /// <summary>
        /// Busca Linear para fins de comparação
        /// Complexidade: O(n)
        /// </summary>
        public static int BuscaLinear(Livro[] array, int idProcurado)
        {
            NumeroComparacoes = 0;

            for (int i = 0; i < array.Length; i++)
            {
                NumeroComparacoes++;
                if (array[i].Id == idProcurado)
                {
                    return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Calcula a complexidade teórica da busca binária
        /// </summary>
        public static int ComplexidadeTeorica(int tamanhoArray)
        {
            if (tamanhoArray <= 0) return 0;
            return (int)Math.Ceiling(Math.Log2(tamanhoArray));
        }
    }
}
