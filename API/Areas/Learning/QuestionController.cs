using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Areas.Learning
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : BaseController<Question>
    {
        public QuestionController(GenericRepository<Question> genericRepository) : base(genericRepository)
        {
        }
    }
}
