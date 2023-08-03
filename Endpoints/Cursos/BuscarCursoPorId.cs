using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Template;
using Microsoft.EntityFrameworkCore;
using TC_API.Domain.Cursos;
using TC_API.Infra.Data;

namespace TC_API.Endpoints.Cursos;

public class BuscarCursoPorId
{
    public static string Template => "/cursos/{id}";
    public static string[] Methods => new string[] { HttpMethod.Get.ToString() };
    public static Delegate Handle => Action;


    public static IResult Action([FromRoute] Guid id, ApplicationDbContext context)
    {
        var curso = context.Cursos.Include(c => c.Categoria).Where(c => c.Id == id)
                                          .OrderBy(c => c.Nome).Where(c => c.Id == id);

        if (curso != null)
            return Results.Ok(curso);

        return Results.NotFound();
    }

}
