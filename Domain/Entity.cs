namespace TC_API.Domain;

public abstract class Entity
{
    public Entity() 
    { 
        Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }
    public string CriadoPor { get; set; }
    public DateTime CriadoQuando { get; set; }
    public string EditadoPor { get; set; }
    public DateTime EditadoQuando { get; set; }
}
