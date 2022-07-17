using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using API.Errors;
namespace API.Controllers
{
    [ApiController]
    [Route("errors/{code}")]
    public class ErrorController:BaseApiController
    {
        [HttpGet]
        public IActionResult Error(int code){
            return new ObjectResult(new ApiResponse(code));
        }
    }
}