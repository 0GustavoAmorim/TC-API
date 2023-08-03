using Microsoft.AspNetCore.Mvc;
using TC_API.Infra.Data;

namespace TC_API.Endpoints.Categorias;

public class CategoriaPut
{
    public static string Template => "/categoria/{id:guid}";
    public static string[] Methods =>new string[] { HttpMethod.Put.ToString() };
    public static Delegate Handle => Action;

    public static IResult Action([FromRoute] Guid id, CategoriaRequest categoriaRequest, ApplicationDbContext context)
    {
        var categoria = context.Categorias.Where(c => c.Id == id).FirstOrDefault();

        if (categoria == null)
           return Results.NotFound();

        categoria.EditarInfo(categoriaRequest.Nome, categoriaRequest.Ativo);

        if(categoria != null)
         
            context.SaveChanges();

            return Results.Ok();


    }
}
