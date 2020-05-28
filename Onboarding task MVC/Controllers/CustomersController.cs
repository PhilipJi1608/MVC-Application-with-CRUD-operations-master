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
    public class CustomersController : Controller
    {
        DataAccessLayer obj = new DataAccessLayer();
        [HttpGet]
        [Route("api/Customers/Index")]
        public IEnumerable<Customers> Index()
        {
            return obj.GetAllCustomers();
        }
        [HttpPost]
        [Route("api/Customers/Create")]
        public int Create(Customers customer)
        {
            return obj.AddCustomer(customer);
        }
        [HttpGet]
        [Route("api/Customers/Details/{id}")]
        public Customers Details(int id)
        {
            return obj.GetCustomerData(id);
        }
        [HttpPut]
        [Route("api/Customers/Edit")]
        public int Edit(Customers customer)
        {
            return obj.UpdateCustomer(customer);
        }
        [HttpDelete]
        [Route("api/Customers/Delete/{id}")]
        public int Delete(int id)
        {
            return obj.DeleteCustomer(id);
        }
    }
}