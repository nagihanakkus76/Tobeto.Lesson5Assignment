using NagihanAkkus_Lesson5Assignment.Managers.Abstract;
using NagihanAkkus_Lesson5Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagihanAkkus_Lesson5Assignment.Managers.Concrete
{
    public class CustomerManager
    {
        private Customer _customer;
        private ICreditManager _creditManager;
        public CustomerManager(Customer customer, ICreditManager creditManager)
        {
            _customer = customer;
            _creditManager = creditManager;

        }
        public void Save()
        {
            Console.WriteLine("Müşteri Kaydedildi.");
        }
        public void Delete()
        {
            Console.WriteLine("Müşteri Silindi.");
        }
        public void GiveCredit()
        {
            _creditManager.Calculate();
            Console.WriteLine("Kredi onaylandı.");
        }

    }
}
