public class Usuario {
    public string Nome {get; set; }
    public string NumeroIdentificacao {get; set;}
    public string Endereco {get; set; }
    public string Contato { get; set;}
    public List<ItemBiblioteca> HistoricoEmprestimos {get; private set;}

    public Usuario( string nome, string numeroIdentificacao, string endereco, string contato)
    {
        Nome = nome;
        NumeroIdentificacao = numeroIdentificacao;
        Endereco = endereco;
        Contato = contato;
        HistoricoEmprestimos = new List<ItemBiblioteca>();
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}, ID: {NumeroIdentificacao}, Endereço: {Endereco}, Contato: {Contato}");
    }

    public void AdicionarEmprestimo( ItemBiblioteca item)
    {
        HistoricoEmprestimos.Add( item );
    }

    public void ExibirHistorico() {
        foreach (var item in HistoricoEmprestimos)
        {
            Console.WriteLine($"Item: {item.Titulo}, Código: {item.Codigo}");
        }
    }
}
