using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagihanAkkus_Lesson5Assignment.Managers.Concrete
{
    public class CreditManager
    {
        public void Calculate(int creditType)
        {
            Console.WriteLine("Hesaplandı");
        }

        public void Save()
        {
            Console.WriteLine("Kredi verildi");
        }
    }
}
