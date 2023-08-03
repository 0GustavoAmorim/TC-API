namespace TC_API.Endpoints.Cursos;

public record CursoResponse(string Nome, string CategoriaNome, string Descricao, bool Ativo, string Duracao, decimal Preco);
