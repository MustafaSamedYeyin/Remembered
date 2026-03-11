using API.Data;
using API.Entities.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Areas.Learning
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T> : ControllerBase where T : BaseEntity
    {
        public GenericRepository<T> _genericRepository { get; set; }
        [HttpGet]
        public async Task<IActionResult> Get<T>(int id) => Ok(await _genericRepository.Get(id));
        [HttpGet]
        public async Task<IActionResult> GetAll<T>() => Ok(await _genericRepository.GetAll());
        [HttpPost]
        public async Task<IActionResult> Post<T>(T entity) => Ok(await _genericRepository.Post(entity));
        [HttpPut]
        public async Task<IActionResult> Put<T>(T entity) => Ok(await _genericRepository.Put(entity));
        [HttpDelete]
        public async Task<IActionResult> Delete<T>(T entity) => Ok(await _genericRepository.Delete(entity));
    }
}
