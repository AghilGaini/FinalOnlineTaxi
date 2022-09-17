using DatabaseDomain.OtherModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseDomain.DTO.Security
{
    public class UsersDTO
    {
        public List<UserInfoDTO> Users { get; set; } = new List<UserInfoDTO>();
        public List<ActionItem> Actions { get; set; } = new List<ActionItem>();
    }

    public class UserInfoDTO
    {
        [Required]
        [Display(Name = "شناسه")]
        public long Id { get; set; }

        [StringLength(100)]
        [Display(Name = "نام کاربری")]
        public string Username { get; set; }

        [Display(Name = "فعال")]
        public bool IsActive { get; set; }

        [Display(Name = "ادمین")]
        public bool IsAdmin { get; set; }
    }
}
