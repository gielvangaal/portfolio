using Domain.Enums;

namespace Domain.Entities;

public class Credential
{
    public int Id { get; set; }

    public int EducationId { get; set; }

    public Education Education { get; set; } = null!;

    public required string Name { get; set; }

    public CredentialType Type { get; set; }

    public CredentialStatus Status { get; set; }

    public int? Year { get; set; }

    public string? CredentialUrl { get; set; }

    public string? DocumentUrl { get; set; }
}