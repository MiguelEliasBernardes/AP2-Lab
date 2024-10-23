public class Biblioteca
{
    List<Livro> livros { get; set; } = new List<Livro>();
    List<Usuario> usuarios { get; set; } = new List<Usuario>();

    public void CadastrarLivro(Livro livro)
    {
        livros.Add(livro);
        Console.WriteLine($"Livro {livro.Titulo} cadastrado com sucesso!");
    }

    public void CadastrarUsuario(Usuario usuario)
    {
        usuarios.Add(usuario);
        Console.WriteLine($"Usuário {usuario.Nome} cadastrado com sucesso!");
    }

    public void PesquisarPorAutor(string autor){
        foreach (var item in livros)
        {
            if(item.Autor == autor){
            Console.WriteLine($"Título: {item.Titulo}");
            Console.WriteLine($"Autor: {item.Autor}");
            Console.WriteLine($"Genero: {item.Genero}");
            Console.WriteLine($"Estoque: {item.QuantidadeEmEstoque}");
            Console.WriteLine($"==========");
            }
        }
    }

    public void PesquisarPorTitulo(string titulo){
        foreach (var item in livros)
        {
            Console.WriteLine(item.Titulo);

            if(item.Titulo == titulo){
            Console.WriteLine($"Título: {item.Titulo}");
            Console.WriteLine($"Autor: {item.Autor}");
            Console.WriteLine($"Genero: {item.Genero}");
            Console.WriteLine($"Estoque: {item.QuantidadeEmEstoque}");
            Console.WriteLine($"==========");
            }
        }
    }

    public void PesquisarPorGenero(string genero){
        foreach (var item in livros)
        {
            if(item.Genero == genero){
            Console.WriteLine($"Título: {item.Titulo}");
            Console.WriteLine($"Autor: {item.Autor}");
            Console.WriteLine($"Genero: {item.Genero}");
            Console.WriteLine($"Estoque: {item.QuantidadeEmEstoque}");
            Console.WriteLine($"==========");
            }
        }
    }

    public void AtualizarInformacoes(string codigoLivro, string novoTitulo, string novoAutor, string novoGenero, string novoIsbn, int novaQuantidade)
    {
        Livro livro = livros.FirstOrDefault(l => l.Codigo == codigoLivro);

        if(livro != null){
            if(novoTitulo != null)
            livro.Titulo = novoTitulo;
            
            if(novoAutor != null)
            livro.Autor = novoAutor;

            if(novoIsbn != null)
            livro.Isbn = novoIsbn;

            if(novoGenero != null)
            livro.Genero = novoGenero;

            Console.WriteLine("Livro atualizado com sucesso!");
        }
    }

    public void AtualizarInformacoes(string numeroIdentificacao, string novoNome, string novoEndereco, string novoContato)
    {
        Usuario usuario = usuarios.FirstOrDefault(u => u.NumeroIdentificacao == numeroIdentificacao);

        if(usuario != null){
            if(novoNome != null)
            usuario.Nome = novoNome;
            
            if(novoEndereco != null)
            usuario.Endereco = novoEndereco;

            if(novoContato != null)
            usuario.Contato = novoContato;

            Console.WriteLine("Usuário atualizado com sucesso!");
        }
    }

    public void ListarLivros()
    {
        Console.WriteLine("Lista de livros cadastrados:");
        foreach (var livro in livros)
        {
            Console.WriteLine($"{livro.Codigo} - {livro.Titulo} - {livro.Autor} - {livro.Genero} - {livro.Isbn} - {livro.QuantidadeEmEstoque}");
        }
    }

    public void ListarUsuarios()
    {
        Console.WriteLine("Lista de usuarios cadastrados:");
        foreach (var usuario in usuarios)
        {
            Console.WriteLine($"{usuario.NumeroIdentificacao} - {usuario.Nome} - {usuario.Contato} - {usuario.Endereco}");

            usuario.ExibirHistorico();
        }
    }

    public void EmprestarLivro(string nomeLivro, string NomeUsuario)
    {
        Livro livro = livros.FirstOrDefault(l => l.Titulo == nomeLivro);
        Usuario usuario = usuarios.FirstOrDefault(u => u.Nome == NomeUsuario);

        if(livro != null && usuario != null){
            livro.Emprestar(usuario);
        }
        else
        {
            Console.WriteLine("Livro ou usuário não encontrado");
        }
    }

    public void DevolverLivro(string nomeLivro, string NomeUsuario)
    {
        Livro livro = livros.FirstOrDefault(l => l.Titulo == nomeLivro);
        Usuario usuario = usuarios.FirstOrDefault(u => u.Nome == NomeUsuario);

        if (livro != null){
            livro.Devolver();
        }else{
            Console.WriteLine("Livro não encontrado");
        }
    }

}
