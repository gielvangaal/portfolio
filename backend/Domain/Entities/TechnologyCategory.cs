namespace Domain.Entities;

public class TechnologyCategory
{
    public int Id { get; set; }
    
    public int TechnologyId { get; set; }
    public int CategoryId { get; set; }

    public Technology Technology { get; set; } = null!;
    public Category Category { get; set; } = null!;
}