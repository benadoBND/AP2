class Program {
    static void Main()
    {
        Biblioteca biblioteca = new Biblioteca();

        Livro livro1 = new Livro("Diário de um Banana", "1", "Jeff Kinney", "123456789", "Infantojuvenil", 47);
        biblioteca.CadastrarLivro(livro1);

        Usuario usuario1 = new Usuario("Bernardo Borba", "999", "Rua Presidente, 123", "9999-9999");
        biblioteca.CadastrarUsuario(usuario1);

        biblioteca.EmprestarLivro("1", "001");

        biblioteca.ListarLivros();
        biblioteca.ListarUsuarios();

        biblioteca.DevolverLivro("1");
    }
}
