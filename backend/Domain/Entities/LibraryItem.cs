using Domain.Enums;

namespace Domain.Entities;

public class LibraryItem
{
    public int Id { get; set; }

    public required string Title { get; set; }

    public required string Creator { get; set; }

    public LibraryItemType Type { get; set; }

    public int SortOrder { get; set; }

    public int? MediaId { get; set; }
    public Media? Media { get; set; }

    public ICollection<Technology> Technologies { get; set; } = [];
    public ICollection<Skill> Skills { get; set; } = [];
    public ICollection<Tooling> Tooling { get; set; } = [];
}