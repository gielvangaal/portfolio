namespace Domain.Entities;

public class AboutProfile
{
    public int Id { get; set; }

    public string Language { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string ImagePath { get; set; } = string.Empty;
}