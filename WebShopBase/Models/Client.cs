using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Classes
{
    
    public class Client
    {
        [Key, Column("Client_ID")]
        public int Client_ID { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "Ваше имя")]
        public string Name { get; set; }


        [Required]
        [StringLength(20)]
        [Display(Name = "Ваша фамилия")]
        public string Surname { get; set; }

        [Required]
        [Phone]
        [StringLength(11)]
        [Display(Name = "Ваш номер телефона")]
        public string Phone { get; set; }

        [Required]
        [Display(Name = "Ваша почта")]
        [EmailAddress]
        public string Email { get; set; }

        
        [Required]
        [Display(Name = "Ваш пароль")]
        public string Password { get; set; }
    }
}
