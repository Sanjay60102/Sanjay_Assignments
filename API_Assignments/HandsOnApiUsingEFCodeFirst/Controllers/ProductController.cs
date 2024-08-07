using HandsOnApiUsingEFCodeFirst.Entities;
using HandsOnApiUsingEFCodeFirst.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnApiUsingEFCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        //public ProductController()
        //{
        //    _productRepository = new ProductRepository();
        //}
        //Get Endpoints
        [HttpGet, Route("GetProducts")]
        public IActionResult GetAll() //Get All product details
        {
            var products = _productRepository.GetAll();
            return StatusCode(200, products);
        }
        [HttpGet, Route("GetProduct/{id}")]
        public IActionResult Get([FromRoute] int id) //Get a Product By Id
        {
            var product = _productRepository.Get(id);
            if (product != null)
                return StatusCode(200, product);
            else
                return StatusCode(404, "Invalid Id");
        }
        [HttpPost, Route("AddProduct")]
        public IActionResult Add([FromBody]Product product)
        {
            _productRepository.Add(product);
            return StatusCode(200, product);
        }
        //Post Endpoint
        [HttpPut, Route("EditProduct")]
        public IActionResult Edit([FromBody] Product product) //Edit Product details
        {
            _productRepository.Update(product);
            return StatusCode(200, product);
        }
        //Delete Endpoint
        [HttpDelete, Route("DeleteProduct")]
        public IActionResult Delete([FromQuery]int id) //Delete Product using id
        {
            _productRepository.Delete(id);
            return Ok(); //Empty Response
        }
    }
}
