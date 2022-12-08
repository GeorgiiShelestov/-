using System;
using System.ComponentModel.DataAnnotations;

namespace PassengerTransportCompany
{

    public class Employee
    {
        [Key]
        public int Id { get; set; }
        
        public string Code { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public string MiddleName { get; set; }

        public DateTime? DateBirth { get; set; }

        public string Phone { get; set; }

        public string Department { get; set; }
    }
}
