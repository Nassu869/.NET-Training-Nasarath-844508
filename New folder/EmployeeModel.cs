using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace WebApplication8
{
    public class EmployeeModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 8)]
        public string Description { get; set; }

        [Required]
        [Range(16, 30)]
        public int Age { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DOJ { get; set;}

        


    }
}