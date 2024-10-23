using System.Reflection.Metadata;

public class Livro:ItemBiblioteca, IEmprestavel, IPesquisavel
{
    public string Autor { get; set; }
    public string Isbn { get; set; }
    public string Genero { get; set; }
    public int QuantidadeEmEstoque { get; set; }

    public Livro(string titulo, string codigo, string autor, string isbn, string genero, int quantidadeEmEstoque)
    :base(titulo, codigo)
    {
        Autor = autor;
        Isbn = isbn;
        Genero = genero;
        QuantidadeEmEstoque = quantidadeEmEstoque;
    }

    public override void Emprestar(Usuario usuario)
    {
        if (QuantidadeEmEstoque > 0){
            QuantidadeEmEstoque --;
            usuario.HistoricoImprestimo.Add(this);
            Console.WriteLine($"Livro {Titulo} emprestado ao usuario {usuario.Nome}");
        }else{
            Console.WriteLine($"O livro {Titulo} está indisponível no momento!");
        }
    }

    public override void Devolver()
    {
        QuantidadeEmEstoque ++;
        Console.WriteLine($"Livro {Titulo} devolvido");
    }


    public void PesquisarPorAutor(string autor)
    {
        
    }

    public void PesquisarPorGenero(string genero)
    {

    }

    public void PesquisarPorTitulo(string titulo)
    {
        
    }
}