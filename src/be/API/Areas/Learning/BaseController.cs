using API.Data;
using API.Entities.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Areas.Learning
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BaseController<T> : ControllerBase where T : BaseEntity
    {
        public GenericRepository<T> _genericRepository { get; set; }

        public BaseController(GenericRepository<T> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get(Guid id) => Ok(await _genericRepository.Get(id));
        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _genericRepository.GetAll());
        [HttpPost]
        public async Task<IActionResult> Post(T entity) => Ok(await _genericRepository.Post(entity));
        [HttpPut]
        public async Task<IActionResult> Put(T entity) => Ok(await _genericRepository.Put(entity));
        [HttpDelete]
        public async Task<IActionResult> Delete(T entity)
        {
            await _genericRepository.Delete(entity);
            return NoContent();
        }
    }
}
