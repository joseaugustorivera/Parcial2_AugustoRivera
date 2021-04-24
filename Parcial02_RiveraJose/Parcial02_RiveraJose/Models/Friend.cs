using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial02_RiveraJose.Models
{
    public class Friend
    {
        [Key]
        public int FriendID { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }
        public string NickName { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }
    }
}