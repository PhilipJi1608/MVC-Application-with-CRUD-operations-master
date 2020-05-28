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
    public class StoresController : Controller
    {
        DataAccessLayer obj = new DataAccessLayer();
        [HttpGet]
        [Route("api/Stores/Index")]
        public IEnumerable<Stores> Index()
        {
            return obj.GetAllStores();
        }
        [HttpPost]
        [Route("api/Stores/Create")]
        public int Create(Stores store)
        {
            return obj.AddStore(store);
        }
        [HttpGet]
        [Route("api/Stores/Details/{id}")]
        public Stores Details(int id)
        {
            return obj.GetStoreData(id);
        }
        [HttpPut]
        [Route("api/Stores/Edit")]
        public int Edit(Stores store)
        {
            return obj.UpdateStore(store);
        }
        [HttpDelete]
        [Route("api/Stores/Delete/{id}")]
        public int Delete(int id)
        {
            return obj.DeleteStore(id);
        }
    }
}