using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Onboarding_task_MVC.Models
{
    public partial class Sales
    {
        public int SalesId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int StoreId { get; set; }
        public DateTime? DateSold { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual Products Product { get; set; }
        public virtual Stores Store { get; set; }
    }
}
