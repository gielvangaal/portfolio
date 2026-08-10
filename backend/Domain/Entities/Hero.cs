namespace Domain.Entities;

public class Hero
{
    public int Id { get; set; }

    public string Language { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public string JobTitle { get; set; } = string.Empty;

    public string CatchPhrase { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public int? MediaId { get; set; }

    public Media? Media { get; set; }
}