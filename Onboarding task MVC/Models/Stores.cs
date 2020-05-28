using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Onboarding_task_MVC.Models
{
    public partial class Stores
    {
        public Stores()
        {
            Sales = new HashSet<Sales>();
        }

        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public string StoreAddress { get; set; }

        public virtual ICollection<Sales> Sales { get; set; }
    }
}
