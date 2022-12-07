using ApiCrud.Business.Abstract;
using CrudApi.Data.Abstract;
using CrudApi.Data.Concrate;
using CrudApi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCrud.Business.Concrate
{
    public class HotelManager : IHotelService
    {
        private IHotelRepository _hotelRepository;
        public HotelManager(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        //public HotelManager()
        //{
        //    _hotelRepository = new HotelRepo();
        //}



        public void Create(Hotel hotel)
        {
            _hotelRepository.Create(hotel);
        }

        public void Delete(int id)
        {
            _hotelRepository.Delete(id);
        }

        public List<Hotel> GetAll()
        {
           return _hotelRepository.GetAll();
        }

        public Hotel GetById(int id)
        {
           return _hotelRepository.GetById(id);
        }

        public Hotel Update(Hotel hotel)
        {
           return _hotelRepository.Update(hotel);
        }
    }
}
