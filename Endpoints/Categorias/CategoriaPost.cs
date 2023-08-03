using TC_API.Domain.Cursos;
using TC_API.Infra.Data;

namespace TC_API.Endpoints.Categorias
{
    public class CategoriaPost
    {
        public static string Template => "/categoria";
        public static string[] Methods => new string[] { HttpMethod.Post.ToString() };
        public static Delegate Handle => Action;


        public static IResult Action(CategoriaRequest categoriaRequest, ApplicationDbContext context) 
        {
            var categoria = new Categoria(categoriaRequest.Nome);

            if (categoria != null)
            {
                context.Categorias.Add(categoria);
                context.SaveChanges();

                return Results.Created($"/categorias/{categoria.Id}", categoria.Id);
            }
            return Results.NotFound();
        }
    }
}
