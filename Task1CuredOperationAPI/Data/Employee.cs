using System;
using System.ComponentModel.DataAnnotations;

namespace Task1CuredOperationAPI.Data
{
    public class Employee
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]

        public string City { get; set; }
        [Required]

        public DateTime Recruitmentdate { get; set; }
        [Required]
        public string SSN { get; set; }


    }
}
