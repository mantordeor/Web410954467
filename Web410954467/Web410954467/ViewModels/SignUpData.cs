using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web410954467.ViewModels
{
    public class SignUpData
    {
        [Display(Name = "姓名")]
        [Required(ErrorMessage = "請輸入姓名")]
        [MinLength(1, ErrorMessage = "請輸入至少一個字")]
        [MaxLength(10, ErrorMessage = "請勿輸入超過十個字")]
        public string Name { get ; set; }



        [Display(Name = "帳號")]
        [Required(ErrorMessage ="請輸入帳號")]
        [EmailAddress(ErrorMessage = "請輸入正確的格式")]
        public string Account { get; set; }




        [Display(Name = "密碼")]
        [Required(ErrorMessage = "請輸入密碼")]
        [StringLength(10,MinimumLength = 5,ErrorMessage ="請輸入至少五到十個字")]
        public string Password { get; set; }
        public string NameMessage { get; set; }
        public string AccountMessage { get; set; }
        public string PasswordMessage { get; set; }
        public string Message { get; set; }
    }
}