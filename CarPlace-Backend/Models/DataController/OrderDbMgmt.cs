using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarPlace_Backend.Controllers.Repository;

namespace CarPlace_Backend.Models.DataController
{
    public class OrderDbMgmt : Repository<OrderDetails>
      {
        readonly ZoomCarContext _context;
        public OrderDbMgmt(ZoomCarContext content1) {

            _context = content1;
        }
        public bool create(OrderDetails entity)
        {
            _context.OrderDetails.Add(entity);
            _context.SaveChanges();
            return true;
        }

        public bool delete(OrderDetails entity)
        {
            _context.OrderDetails.Remove(entity);
            _context.SaveChanges();
            return true;

        }

        public List<OrderDetails> read()
        {
          return  _context.OrderDetails.ToList();
        }

        public IEnumerable<OrderDetails> readById(int id)
        {
            throw new NotImplementedException();
        }

         OrderDetails readbyId(int id)
        {
            return (from OrderDetails in _context.OrderDetails where OrderDetails.CarId == id select OrderDetails).FirstOrDefault();
        }

        public bool update(OrderDetails entity)
        {
            throw new NotImplementedException();
        }

        bool Repository<OrderDetails>.create(OrderDetails entity)
        {
            _context.OrderDetails.Add(entity);
            
            return true;
        }

        bool Repository<OrderDetails>.delete(OrderDetails entity)
        {
            throw new NotImplementedException();
        }

        List<OrderDetails> Repository<OrderDetails>.read()
        {
            throw new NotImplementedException();
        }

        

        bool Repository<OrderDetails>.update(OrderDetails entity)
        {
            throw new NotImplementedException();
        }

        OrderDetails Repository<OrderDetails>.readById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
