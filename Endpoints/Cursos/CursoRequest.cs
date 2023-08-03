namespace TC_API.Endpoints.Cursos;

public record CursoRequest(string Nome, Guid CategoriaId, string Descricao, bool Ativo, decimal Preco, string Duracao, string CriadoPor);
