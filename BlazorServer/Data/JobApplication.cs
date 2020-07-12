using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Data
{
    public class JobApplication
    {
        [Required]
        public string FullName { get; set; }

        [StringLength(500, ErrorMessage ="You cannot put so many words here")]
        public string Description { get; set; }
        [Required]
        [Range(10000, 150000, ErrorMessage ="Salary cannot be less than 1000 or bigger tha 150000")]
        public int SalaryExpectation { get; set; }
        [Required]
        public bool DoesOpenSource { get; set; }
        [Required]
        public DateTime Availability { get; set; }
    }
}
