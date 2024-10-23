public abstract class ItemBiblioteca
{
    public string Titulo { get; set; }
    public string Codigo { get; set; }

    public ItemBiblioteca(string titulo, string codigo)
    {
        Titulo = titulo;
        Codigo = codigo;
    }
    public abstract void Emprestar(Usuario usuario);
    public abstract void Devolver();

}