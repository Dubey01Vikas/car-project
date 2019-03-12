using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarPlace_Backend.Controllers.Repository
{
   public interface CarDetailsInterface<T>   where T: class
    {
        IEnumerable<object> CarDetails { get; }

        IEnumerable<T> readbyId(int id) ;
        List<T> read();
        List<T> searchByName(String Name);
        void updatestatus(int a);
    }
}
