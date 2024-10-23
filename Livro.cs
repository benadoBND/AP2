public class Livro : ItemBiblioteca, IEmprestavel
{
    public string Autor {get; set; }
    public string ISBN {get; set;}
    public string Genero {get; set; }
    public int QuantidadeEmEstoque { get; set;}
    public Livro(string titulo, string codigo, string autor, string isbn, string genero, int quantidade):base(titulo, codigo)
    {
        Autor = autor;
        ISBN = isbn;
        Genero = genero;
        QuantidadeEmEstoque = quantidade;
    }
    public override void Emprestar(Usuario usuario)
    {
        if (QuantidadeEmEstoque > 0)
        {
            QuantidadeEmEstoque--;
            usuario.AdicionarEmprestimo(this);
            Console.WriteLine($"Livro '{Titulo}' emprestado a {usuario.Nome}.");
        }
        else
        {
            Console.WriteLine("Livro indisponível no momento.");
        }
    }
    public override void Devolver()
    {
        QuantidadeEmEstoque++;
        Console.WriteLine($"Livro '{Titulo}' devolvido.");
    }
}
