using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarPlace_Backend.Controllers.Repository;
using CarPlace_Backend.Models;

namespace CarPlace_Backend.Models.DataController
{
    public class CarDetailsMgmt : CarDetailsInterface<CarDetails>
    {
        readonly ZoomCarContext _context;
        public CarDetailsMgmt(ZoomCarContext context1) {
            this._context = context1;
        }

        IEnumerable<object> CarDetailsInterface<CarDetails>.CarDetails => throw new NotImplementedException();

        public List<CarDetails> read()
        {
            return _context.CarDetails.ToList();
        }

          IEnumerable<CarDetails> CarDetailsInterface<CarDetails>.readbyId(int id1)
          {
            
            return _context.CarDetails.Where(q => q.CarId == id1 );
          }
        List<CarDetails> CarDetailsInterface<CarDetails>.read()
        {
            return (from CarDetails in _context.CarDetails select CarDetails).ToList();
        }

      

        List<CarDetails> CarDetailsInterface<CarDetails>.searchByName(string Name)
        {
            return (from CarDetails in _context.CarDetails where CarDetails.ModelId== (from CarModel in _context.CarModel where CarModel.CompanyName == Name select CarModel.ModelId).FirstOrDefault() select CarDetails).ToList();
        }

        void CarDetailsInterface<CarDetails>.updatestatus(int A)
        {
            var result = (from CarDetails in _context.CarDetails where CarDetails.CarId == A select CarDetails).FirstOrDefault();
            result.Status = false;
            _context.SaveChanges();
        }
    }
}
