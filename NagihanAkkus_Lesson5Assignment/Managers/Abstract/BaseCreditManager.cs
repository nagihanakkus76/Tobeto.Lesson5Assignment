using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagihanAkkus_Lesson5Assignment.Managers.Abstract
{
  public abstract class BaseCreditManager : ICreditManager
    {
        public abstract void Calculate();  //Calculate operasyonu değişken olduğu için abstract yazıyoruz ve sadece imzası yazılıyor.
        public virtual void Save()         // Save operasyonu ortak olduğu için ne iş yaptığını burada yazıyoruz ve virtual diyerekte ezilebileceğini belirtiyoruz.
        {
            Console.WriteLine("Kaydedildi");
        }
    }
}
