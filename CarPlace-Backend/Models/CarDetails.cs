using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarPlace_Backend.Models
{
    public class CarDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CarId { get; set; }
        public Double Price { get; set; }
        public bool Status { get; set; }
        public String CarOwnerName{ get; set;}
        public String CarOwnerNumber { get; set; }
        public String CarImage { get; set; }       
        public int  ModelId { get; set; }
        [ForeignKey("ModelId")]
        public CarModel CarModel { get; set; }
             

    }
}
