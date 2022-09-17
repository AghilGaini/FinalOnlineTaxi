using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseDomain.Entities
{
    public class UserDomain
    {
        [Key]
        public long Id { get; set; }
        [StringLength(100)]
        [Display(Name = "نام کاربری")]
        public string Username { get; set; }
        [StringLength(50)]
        [Display(Name = "نام")]
        public string Firstname { get; set; }
        [StringLength(50)]
        [Display(Name = "نام خانوادگی")]
        public string Lastname { get; set; }
        [StringLength(100)]
        [Display(Name = "ایمیل")]
        public string Email { get; set; }
        [Display(Name = "نوع کاربر")]
        public int UserType { get; set; }
        [StringLength(100)]
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }
        [Display(Name = "فعال/غیر فعال")]
        public bool IsActive { get; set; }
        [Display(Name = "ادمین")]
        public bool IsAdmin { get; set; }

    }
}
