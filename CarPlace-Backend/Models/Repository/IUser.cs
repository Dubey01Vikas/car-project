using CarPlace_Backend.Controllers.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarPlace_Backend.Models.Repository
{
   public  interface IUser<T> : Repository<T> where T: class
    {
        bool Valid(String email, String pass);
        T readByEmail(String email);
        
    }
}
