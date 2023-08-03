namespace TC_API.Domain.Cursos
{
    public class Categoria : Entity
    {
        public string Nome { get; private set; }
        public bool Ativo { get; private set; }
        
        
        public Categoria(string nome/*string criadoPor, string editadoPor*/)
        {
            Nome = nome;
            Ativo = true;

            //CriadoPor = criadoPor;
            //EditadoPor = editadoPor;
            CriadoQuando = DateTime.Now;
            EditadoQuando = DateTime.Now;
        }

        public void EditarInfo(string nome, bool ativo)
        {
            Nome = nome;
            Ativo = ativo;
        }

    }
}
