using Domain.Enums;

namespace Domain.Entities;

public class Media
{
    public int Id { get; set; }

    public string Path { get; set; } = string.Empty;

    public string AltText { get; set; } = string.Empty;

    public MediaType Type { get; set; }
}