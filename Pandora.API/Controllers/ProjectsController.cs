using Microsoft.AspNetCore.Mvc;

using Pandora.Application.Dto;

namespace Pandora.API.Controllers
{
    [Route("api/v1/[controller]")]
    public class ProjectsController : PandoraAPIController
    {
        [HttpPost]
        public ProjectDto AddProject()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("{projectId:guid}")]
        public ProjectDto? GetProjectById(Guid projectId)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public IEnumerable<ProjectDto> GetProjects()
        {
            throw new NotImplementedException();
        }
    }
}
