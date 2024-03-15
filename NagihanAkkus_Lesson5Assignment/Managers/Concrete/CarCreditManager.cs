using NagihanAkkus_Lesson5Assignment.Managers.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagihanAkkus_Lesson5Assignment.Managers.Concrete
{
    public class CarCreditManager : BaseCreditManager, ICreditManager
    {
        public override void Calculate()
        {
            Console.WriteLine("Taşıt kredisi hesaplandı");
        }

        // Save metodu Base Classta(BaseCreditManager) tanımlandı.
    }
}
