namespace Application.DTOs.Responses;

public class ToolingResponse
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Usage { get; set; } = string.Empty;

    public MediaResponse? Media { get; set; }
}