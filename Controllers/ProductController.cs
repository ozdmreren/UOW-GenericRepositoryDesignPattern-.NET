using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using UnitOfWorkRepositoryPattern.Interfaces.UnitOfWork;
using UnitOfWorkRepositoryPattern.Models;
using UnitOfWorkRepositoryPatternExample.Dtos;
using UnitOfWorkRepositoryPatternExample.Parameters;

namespace UnitOfWorkRepositoryPattern.Controllers
{
    [ApiController]
    [Route("/api/[controller]/[action]")]
    public class ProductController(IUnitOfWork unitOfWork) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ProductDto productDto, CancellationToken cancellationToken)
        {
            IDbContextTransaction transaction = await unitOfWork.BeginTransaction();

            Product entity = new Product()
            {
                Name = productDto.ProductName,
                Brand = productDto.Brand,
                Category = productDto.Category,
                Quantity = productDto.Quantity,
                UnitPrice = productDto.UnitPrice
            };

            Product result = await unitOfWork.ProductRepository.AddAsync(entity);

            if (result is null)
            {
                return BadRequest("Product Oluşturulamadı");
            }
            else
            {
                await transaction.CommitAsync(cancellationToken);

                return Ok(result);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts([FromQuery] Request request)
        {
            IEnumerable<Product> products = await unitOfWork.ProductRepository.GetPagedProductsAsync(request.PageNumber, request.PageSize);

            return Ok(products.ToList());
        }
    }
}