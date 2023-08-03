namespace TC_API.Domain.Cursos
{
    public class Aula : Entity
    {
        public string Titulo { get; private set; }
        public Guid CursoId { get; private set; }
        public Curso Curso{ get; private set; }
        public string URLaula { get; private set; }
        public string Tempo { get; private set; }
        public bool Finalizada { get; private set; } = false;

        private Aula() { }

        public Aula(string titulo, Guid cursoId, Curso curso, string uRLaula, string tempo, bool finalizada, string criadoPor, string editadoPor)
        {
            Titulo = titulo;
            CursoId = cursoId;
            Curso = curso;
            URLaula = uRLaula;
            Tempo = tempo;
            Finalizada = finalizada;

            CriadoPor = criadoPor;
            CriadoQuando = DateTime.Now;
            EditadoPor = editadoPor;
            EditadoQuando = DateTime.Now;
        }
    }
}
