using System.ComponentModel.DataAnnotations;

namespace DevCard_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage ="پر کردن فیلد اجباری می باشد")]
        [MinLength(3)]
        [MaxLength(100,ErrorMessage ="تعداد کاراکتر وارد شده بیش از حد مجاز می باشد")]
        public string name { get; set; }
        [Required(ErrorMessage = "پر کردن فیلد اجباری می باشد")]
        [EmailAddress(ErrorMessage ="پر کردن فیلد اجباری می باشد")]
        public string email { get; set; }
        public string service { get; set; }
        public string message { get; set; }
    }
}
