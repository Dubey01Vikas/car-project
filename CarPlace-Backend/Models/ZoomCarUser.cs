using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarPlace_Backend.Models
{
    public class ZoomCarUser
    {
        [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ZoomCarUserId { set; get; }
        public string Email { get;  set; }
        public String Password { get; set; }
        public int UserId { get; set; }
        
    }
}
