using Microsoft.OpenApi.Models;

using Swashbuckle.AspNetCore.SwaggerGen;

namespace Pandora.API.Startup.Swagger
{
    public class DtoNameFilter : ISchemaFilter
    {
        public void Apply(OpenApiSchema schema, SchemaFilterContext context)
        {
            schema.Title = context.Type.Name.Replace("Dto", string.Empty);
        }
    }
}
