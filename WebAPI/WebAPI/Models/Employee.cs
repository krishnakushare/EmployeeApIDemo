using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    [Table("Employee")]
    public class Employee
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public int salary { get; set; }
    }
}
