using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagihanAkkus_Lesson5Assignment.Models
{
    public class Customer
    {
        public Customer()
        {
            Console.WriteLine("Müşteri nesnesi başlatıldı.");
        }
        public int ID { get; set; }
        public string City { get; set; }
    }
}
