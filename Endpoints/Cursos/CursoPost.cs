using TC_API.Domain.Cursos;
using TC_API.Infra.Data;

namespace TC_API.Endpoints.Cursos;

public class CursoPost
{
    public static string Template = "/cursos";
    public static string[] Methods => new string[] { HttpMethod.Post.ToString() };
    public static Delegate Handle => Action;

    public static IResult Action(CursoRequest cursoRequest, ApplicationDbContext context)
    {
        var categoria = context.Categorias.FirstOrDefault(c => c.Id == cursoRequest.CategoriaId);
        var curso = new Curso(cursoRequest.Nome, categoria, cursoRequest.Descricao, cursoRequest.Ativo, cursoRequest.Preco, cursoRequest.Duracao, cursoRequest.CriadoPor);
    
        if (curso != null)
        {
            context.Cursos.Add(curso);
            context.SaveChanges();

            return Results.Created($"/cursos/{curso.Id}",curso.Id);
        }
        return Results.NotFound();
       
    }
}
