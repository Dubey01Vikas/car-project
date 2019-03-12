using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarPlace_Backend.Models
{
    public class OrderDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        public int ZoomCarUserId { get; set; }
        [ForeignKey("ZoomCarUserId")]
        public ZoomCarUser user { get; set; }
       
        public int CarId { get; set; }
        [ForeignKey("CarId")]
        public CarDetails CarDetails { get; set; }
        public String Email { get; set; }
        
       

    }
}
