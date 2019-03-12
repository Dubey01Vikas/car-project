using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarPlace_Backend.Controllers.Repository;
using CarPlace_Backend.Models.Repository;

namespace CarPlace_Backend.Models.DataController
{
    public class ZoomCarUserDbMgmt : IUser<ZoomCarUser>
    {
        readonly ZoomCarContext _context;

        public ZoomCarUserDbMgmt(ZoomCarContext opt)
        {
            this._context = opt;
        }


        bool IUser<ZoomCarUser>.Valid(String email, String pass)
        {
            //bool check = true;
            var x = (from ZoomCarUser in _context.ZoomCarUser where ZoomCarUser.Email == email && ZoomCarUser.Password == pass select ZoomCarUser).FirstOrDefault();
            if (x.Email.Equals(email) && x.Password.Equals(pass))
            {
                return true;
            }
            else
                return false;
        }

        ZoomCarUser Repository<ZoomCarUser>.readById(int id)
        {
            return (from ZoomCarUser in _context.ZoomCarUser where ZoomCarUser.ZoomCarUserId == id select ZoomCarUser).FirstOrDefault();


            //  return _context.ZoomCarUser.Where( Q => Q.ZoomCarUserId == id );

        }

        bool Repository<ZoomCarUser>.create(ZoomCarUser entity)
        {

           
            
            
                _context.ZoomCarUser.Add(entity);
                _context.SaveChanges();
                return true;
            

        }

        bool Repository<ZoomCarUser>.update(ZoomCarUser entity)
        {
            bool check = true;
            var check1 = (from ZoomCarUser in _context.ZoomCarUser where ZoomCarUser.Email == entity.Email select ZoomCarUser).FirstOrDefault();
            
            check1.Password = entity.Password;
            _context.SaveChanges();


            return check;

        }

        bool Repository<ZoomCarUser>.delete(ZoomCarUser entity)
        {
            var abd = (from ZoomCarUser in _context.ZoomCarUser where ZoomCarUser.ZoomCarUserId == entity.ZoomCarUserId select ZoomCarUser).FirstOrDefault();
            if (abd == null)
            {
                return false;
            }
            _context.ZoomCarUser.Remove(abd);

            return true;
        }

        List<ZoomCarUser> Repository<ZoomCarUser>.read()
        {
            return (from ZoomCarUser in _context.ZoomCarUser select ZoomCarUser).ToList();

        }

        ZoomCarUser IUser<ZoomCarUser>.readByEmail(string email)
        {
            ZoomCarUser user = (from ZoomCarUser in _context.ZoomCarUser where ZoomCarUser.Email == email select ZoomCarUser).FirstOrDefault();
            return user;
        }

    }
}
