using HandsOnApiUsingEFCodeFirst.Entities;
using HandsOnApiUsingEFCodeFirst.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnApiUsingEFCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly IProductAsyncRepository repository;
        public DemoController(IProductAsyncRepository repository)
        {
            this.repository = repository;
        }
        [HttpGet, Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            
            return Ok(await repository.GetAll());
        }
        [HttpGet, Route("GetById/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await repository.GetById(id));
        }
        [HttpPut, Route("EditProduct")]
        public async Task<IActionResult> Edit([FromBody] Product product)
        {
            await repository.Update(product);
            return Ok(product);
        }
        [HttpPost, Route("AddProduct")]
        public async Task<IActionResult> Add(Product product)
        {
            await repository.Added(product);
            return Ok(product);
        }
        [HttpDelete, Route("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await repository.DeleteById(id);
            return Ok();
        }
    }
}
