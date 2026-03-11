using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Areas.Learning
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TopicController : BaseController<Topic>
    {
        public TopicController(GenericRepository<Topic> genericRepository) : base(genericRepository)
        {
        }
    }
}
