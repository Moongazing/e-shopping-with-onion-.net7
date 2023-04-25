using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TAO.Application.Abstractions.Services;
using TAO.Application.CustomAttributes;
using TAO.Application.Enums;
using TAO.Application.Features.Commands.AppUser.AssignRoleToUser;
using TAO.Application.Features.Commands.AppUser.CreateUser;
using TAO.Application.Features.Commands.AppUser.UpdatePassword;
using TAO.Application.Features.Queries.AppUser.GetAllUsers;
using TAO.Application.Features.Queries.AppUser.GetRolesToUser;

namespace TAO.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        readonly IConfiguration _configuration;

        public FilesController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("[action]")]
        public IActionResult GetBaseStorageUrl()
        {
            return Ok(new
            {
                Url = _configuration["BaseStorageUrl"]
            });
        }

    }
}
