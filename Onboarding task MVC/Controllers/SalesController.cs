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
    public class SalesController : Controller
    {
        DataAccessLayer obj = new DataAccessLayer();
        [HttpGet]
        [Route("api/Sales/Index")]
        public IEnumerable<Sales> Index()
        {
            return obj.GetAllSales();
        }
        [HttpPost]
        [Route("api/Sales/Create")]
        public int Create(Sales sales)
        {
            return obj.AddSale(sales);
        }
        [HttpGet]
        [Route("api/Sales/Details/{id}")]
        public Sales Details(int id)
        {
            return obj.GetSaleData(id);
        }
        [HttpPut]
        [Route("api/Sales/Edit")]
        public int Edit(Sales sales)
        {
            return obj.UpdateSale(sales);
        }
        [HttpDelete]
        [Route("api/Sales/Delete/{id}")]
        public int Delete(int id)
        {
            return obj.DeleteSale(id);
        }

        [HttpGet]
        [Route("api/Stores/GetStoreName")]
        public IEnumerable<Stores> DetailsStoreName()
        {
            return obj.GetStore();
        }

        [HttpGet]
        [Route("api/Products/GetProductName")]
        public IEnumerable<Products> DetailsProductName()
        {
            return obj.GetProduct();
        }

        [HttpGet]
        [Route("api/Customers/GetCustomerName")]
        public IEnumerable<Customers> DetailCustomerName()
        {
            return obj.GetCustomer();
        }
    }
}