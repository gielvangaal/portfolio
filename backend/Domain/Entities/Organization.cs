using Domain.Enums;

namespace Domain.Entities;

public class Organization
{
    public int Id { get; set; }

    public required string Name { get; set; }

    public OrganizationType Type { get; set; }

    public string? WebsiteUrl { get; set; }

    public int? MediaId { get; set; }

    public Media? Media { get; set; }

    public ICollection<Education> Educations { get; set; } = [];

    public ICollection<WorkExperience> WorkExperiences { get; set; } = [];
}