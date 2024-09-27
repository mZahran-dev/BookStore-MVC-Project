using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAL.Models
{
    public class User : IdentityUser
    {
        [PersonalData]
        [Required]
        public string FName { get; set; }
        [PersonalData]
        [Required]
        public string LName { get; set; }
        [PersonalData]
        [Required]
        public string Address { get; set; }
        [PersonalData]
        [Required]
        public int ZipCode  { get; set; }
        [PersonalData]
        [DataType(DataType.Date)]
        public DateTime UserCreationDate { get; set; } = DateTime.Now;



    }
}
