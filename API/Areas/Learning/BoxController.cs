using API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Areas.Learning
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoxController : BaseController<Box>
    {
    }
}
