using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Onboarding_task_MVC.Models
{
    public partial class Products
    {
        public Products()
        {
            Sales = new HashSet<Sales>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public float ProductPrice { get; set; }

        public virtual ICollection<Sales> Sales { get; set; }
    }
}
