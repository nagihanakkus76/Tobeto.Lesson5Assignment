
using NagihanAkkus_Lesson5Assignment.Managers.Concrete;
using NagihanAkkus_Lesson5Assignment.Models;

CreditManager creditManager = new CreditManager();
creditManager.Calculate(1);
creditManager.Save();

Customer customer = new Customer();
customer.ID = 1;
customer.City = "Ankara";

Customer customer1 = new Customer();
Person customer2 = new Person();
Company customer3 = new Company();

CustomerManager customerManager1 = new(new Person(), new MilitaryCreditManager());
customerManager1.GiveCredit();

CustomerManager customerManager2 = new CustomerManager(new Person(), new TeacherCreditManager());
customerManager2.GiveCredit();