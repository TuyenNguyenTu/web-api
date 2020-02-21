using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppStep01.Models
{
    public class Student
    {
        [Key]
        public long Id { get; set; }
        [Column(TypeName ="nvarchar(50)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Address { get; set; }
        public int Age { get; set; }
        public bool Status { get; set; }
    }
}
