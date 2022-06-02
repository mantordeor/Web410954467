using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web410954467.Models
{
    [MetadataType(typeof(StudentMetadata))]
    public partial class Student
    {
    
    }
    public class StudentMetadata
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "請填寫姓名")]
        [Display(Name = "姓名")]
        [StringLength(5, MinimumLength = 2, ErrorMessage = "2-5")]
        public string Name { get; set; }
        [Required(ErrorMessage = "請填寫學號")]
        [Display(Name = "學號")]
        [StringLength(10, ErrorMessage = "10")]
        public string Number { get; set; }
        [Required(ErrorMessage = "請填寫郵箱")]
        [Display(Name = "郵箱")]
        [EmailAddress]
        public string Email { get; set; }
        
    }
}