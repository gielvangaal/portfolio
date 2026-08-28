namespace Domain.Entities;

public class Contact
{
    public int Id { get; set; }

    public string Language { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Location { get; set; } = string.Empty;

    public string GitHubUrl { get; set; } = string.Empty;

    public string LinkedInUrl { get; set; } = string.Empty;

    public string InstagramUrl { get; set; } = string.Empty;

    public string SpotifyUrl { get; set; } = string.Empty;

    public string CreditText { get; set; } = string.Empty;
}