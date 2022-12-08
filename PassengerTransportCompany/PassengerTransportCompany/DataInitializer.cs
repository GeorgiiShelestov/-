using System.Data.Entity;
using System.Linq;

namespace PassengerTransportCompany
{
    class DataInitializer : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext db)
        {
            Employee e1 = new Employee
            {
                Code = "001",
                FirstName = "Иван",
                MiddleName = "Иванович",
                LastName = "Иванов",
                Department = "Отдел планирования",
                Phone = "89123456789",
                DateBirth = new System.DateTime(1990, 12, 1)
            };

            Employee e2 = new Employee
            {
                Code = "002",
                FirstName = "Петр",
                MiddleName = "Иванович",
                LastName = "Петров",
                Department = "Производственный отдел",
                Phone = "89876543219",
                DateBirth = new System.DateTime(1990, 01, 13)
            };

            Employee e3 = new Employee
            {
                Code = "003",
                FirstName = "Анатолий",
                MiddleName = "Викторович",
                LastName = "Смирнов",
                Department = "Отдел планирования",
                Phone = "87615432346",
                DateBirth = new System.DateTime(1981, 12, 1)
            };

            Employee e4 = new Employee
            {
                Code = "004",
                FirstName = "Виктор",
                MiddleName = "Иванович",
                LastName = "Иванов",
                Department = "Отдел кадров",
                Phone = "88005353535",
                DateBirth = new System.DateTime(1995, 5, 3)
            };

            Employee e5 = new Employee
            {
                Code = "005",
                FirstName = "Сидор",
                MiddleName = "Сидорович",
                LastName = "Сидоров",
                Department = "Отдел бухгелтерии",
                Phone = "81234322343",
                DateBirth = new System.DateTime(1994, 12, 1)
            };

            db.Employees.Add(e1);
            db.Employees.Add(e2);
            db.Employees.Add(e3);
            db.Employees.Add(e4);
            db.Employees.Add(e5);

            db.SaveChanges();
        }
    }
}
