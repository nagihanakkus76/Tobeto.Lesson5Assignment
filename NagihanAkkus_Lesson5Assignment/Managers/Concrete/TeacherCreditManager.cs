using NagihanAkkus_Lesson5Assignment.Managers.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagihanAkkus_Lesson5Assignment.Managers.Concrete
{
    public class TeacherCreditManager : BaseCreditManager, ICreditManager
    {
        public override void Calculate()
        {
            Console.WriteLine("Öğretmen kredisi hesaplandı");
        }

        public override void Save()
        {
            Console.WriteLine("Kayıt tamamlandı.");   // Base Classın daki Save() ezildi.
            base.Save();
        }
    }
}
