public class Usuario
{
    public string Nome { get; set; }
    public string NumeroIdentificacao { get; set; }
    public string Endereco { get; set; }
    public string Contato { get; set; }


    public Usuario(string nome, string numeroIdentificacao, string endereco, string contato)
    {
        Nome = nome;
        NumeroIdentificacao = numeroIdentificacao;
        Endereco = endereco;
        Contato = contato;
    }

    public List<ItemBiblioteca> HistoricoImprestimo { get; set; } = new List<ItemBiblioteca>();

    public void ExibirInformacoes()
    {
        Console.WriteLine($"---Dados do Usuário---");
        Console.WriteLine("");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Numero de Identificação: {NumeroIdentificacao}");
        Console.WriteLine($"Endereço: {Endereco}");
        Console.WriteLine($"Contato: {Contato}");
    }

    public void ExibirHistorico()
    {
        Console.WriteLine($"Histórico de empréstimos do usuário {Nome}");
        foreach (var imprestimo in HistoricoImprestimo)
        {
            Console.WriteLine($"Título: {imprestimo.Titulo}, Código: {imprestimo.Codigo}");
            Console.WriteLine("===");
        }
    }
}