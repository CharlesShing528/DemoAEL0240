using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoEL0240.Models
{
    public class EmpBootstrap
    {

        [Display(Name = "員工編號")]
        [StringLength(20)]
        public int Id { get; set; }
        [Display(Name = "姓名")]
        [StringLength(15)]
        public string Name { get; set; }
        [Display(Name = "行動電話")]
        [StringLength(15)]
        public string Mobile { get; set; }
        [Display(Name = "電子郵件")]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "部門")]
        [StringLength(15)]
        public string Department { get; set; }
        [Display(Name = "職稱")]
        [StringLength(15)]
        public string Title { get; set; }

    }
}
