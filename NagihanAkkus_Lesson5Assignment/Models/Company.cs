using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagihanAkkus_Lesson5Assignment.Models
{
    public class Company : Customer
    {
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }
}
