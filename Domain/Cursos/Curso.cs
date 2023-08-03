namespace TC_API.Domain.Cursos;

public class Curso : Entity
{
    public string Nome { get; private set; }
    public Guid CategoriaId { get; private set; }
    public Categoria Categoria { get; private set; }
    public string Descricao { get; private set; }
    public bool Ativo { get; private set; } = true;
    public decimal? Preco { get; private set; }
    public string Duracao { get; private set; }
    public ICollection<Aula> Aulas { get; private set; }
    //private Curso() { }

    public Curso(string nome, Categoria categoria, string descricao, bool ativo, decimal? preco, string duracao, string criadoPor)
    {
        Nome = nome;
        Categoria = categoria;
        Descricao = descricao;
        Ativo = ativo;
        Preco = preco;
        Duracao = duracao;

        CriadoPor = criadoPor;
        EditadoPor = criadoPor;
        CriadoQuando = DateTime.Now;
        EditadoQuando = DateTime.Now;

    }
}
