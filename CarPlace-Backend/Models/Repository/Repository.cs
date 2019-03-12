using CarPlace_Backend.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarPlace_Backend.Controllers.Repository
{
    
        public interface Repository<T>
        {
            List<T> read();

             T readById(int id);
          bool create(T entity);
            bool update(T entity);
            bool delete(T entity);
      //  OrderDetails GetById(long id);
    }
    
}
