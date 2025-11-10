namespace BibliotecaDigital
{
    /// <summary>
    /// Representa um livro no acervo da biblioteca digital.
    /// Cada livro possui um ID único que permite ordenação e busca eficiente.
    /// </summary>
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }
        public string Categoria { get; set; }

        public Livro(int id, string titulo, string autor, int anoPublicacao, string categoria)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = anoPublicacao;
            Categoria = categoria;
        }

        public override string ToString()
        {
            return $"ID: {Id:D4} | {Titulo} - {Autor} ({AnoPublicacao}) [{Categoria}]";
        }
    }
}
