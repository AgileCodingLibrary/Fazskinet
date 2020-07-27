using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _context;
        private readonly IProductRepository _repo;

        public ProductsController(StoreContext context, IProductRepository repo)
        {
            _context = context;
            _repo = repo;
        }

        [HttpGet]
        public async Task<IReadOnlyList<Product>> Get()
        {
            return await _repo.GetProductsAsync();
        }

        [HttpGet("{Id}")]
        public async Task<Product> GetProductById(int Id)
        {
            return await _repo.GetProductByIdAsync(Id);
        }
    }
}