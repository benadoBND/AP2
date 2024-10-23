public class Biblioteca {
    public List<Livro> Livros {get;set;}
    public List<Usuario> Usuarios { get; set;}

    public Biblioteca()
    {
        Livros = new List<Livro>();
        Usuarios = new List<Usuario>();
    }
    public void CadastrarLivro(Livro livro)
    {
        Livros.Add(livro);
        Console.WriteLine($"Livro '{livro.Titulo}' cadastrado com sucesso.");
    }

    public void CadastrarUsuario(Usuario usuario)
    {
        Usuarios.Add(usuario);
        Console.WriteLine($"Usuário '{usuario.Nome}' cadastrado com sucesso.");
    }
    public void EmprestarLivro(string codigoLivro, string numeroUsuario) {
        Livro livro = Livros.Find (l => l.Codigo == codigoLivro);
        Usuario usuario = Usuarios.Find (u => u.NumeroIdentificacao == numeroUsuario);
        if (livro != null && usuario != null)
        {
            livro.Emprestar(usuario);
        }
        else
        {
            Console.WriteLine("Livro ou usuário não encontrado.");
        }
    }
    public void DevolverLivro(string codigoLivro)
    {
        Livro livro = Livros.Find (l => l.Codigo == codigoLivro);
        if (livro != null)
        {
            livro.Devolver();
        }
        else
        {
            Console.WriteLine("Livro não encontrado.");
        }
    }
    public void ListarLivros()
    {
        foreach (var livro in Livros)
        {
            Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, Gênero: {livro.Genero}, Estoque: {livro.QuantidadeEmEstoque}");
        }
    }
    public void ListarUsuarios()
    {
        foreach (var usuario in Usuarios)
        {
            usuario.ExibirInformacoes();
        }
    }
}
