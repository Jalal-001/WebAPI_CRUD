using CrudApi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCrud.Business.Abstract
{
    public interface IHotelService
    {
        List<Hotel> GetAll();
        Hotel GetById(int id);
        void Create(Hotel hotel);
        Hotel Update(Hotel hotel);
        void Delete(int id);
    }
}
