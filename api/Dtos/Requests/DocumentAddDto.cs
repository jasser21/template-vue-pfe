using System.ComponentModel.DataAnnotations;

namespace Sdnd_api.Dtos.Requests;

public class DocumentAddDto
{
    [Required]
    public string Name { get; set; }
    public string contentType { get; set; }
    public string Description { get; set; }
}