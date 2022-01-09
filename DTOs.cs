using System;
using System.ComponentModel.DataAnnotations;

namespace Catalog.Api.DTOs
{
    public record ItemDTO(Guid Id, string Name, String Description, decimal Price, DateTimeOffset CreatedDate);
    public record CreateItemDTO([Required] string Name, string Description, [Range(1, 1000)] decimal Price);
    public record UpdateItemDTO(string Name, string Description, [Range(1, 1000)] decimal Price);
}