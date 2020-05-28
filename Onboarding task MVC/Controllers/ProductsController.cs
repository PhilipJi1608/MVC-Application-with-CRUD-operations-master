using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Onboarding_task_MVC.Models;

namespace Onboarding_task_MVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        DataAccessLayer obj = new DataAccessLayer();
        [HttpGet]
        [Route("api/Products/Index")]
        public IEnumerable<Products> Index()
        {
            return obj.GetAllProducts();
        }
        [HttpPost]
        [Route("api/Products/Create")]
        public int Create(Products product)
        {
            return obj.AddProduct(product);
        }
        [HttpGet]
        [Route("api/Products/Details/{id}")]
        public Products Details(int id)
        {
            return obj.GetProductData(id);
        }
        [HttpPut]
        [Route("api/Products/Edit")]
        public int Edit(Products product)
        {
            return obj.UpdateProduct(product);
        }
        [HttpDelete]
        [Route("api/Products/Delete/{id}")]
        public int Delete(int id)
        {
            return obj.DeleteProduct(id);
        }
    }
}