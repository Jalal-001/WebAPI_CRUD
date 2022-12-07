using CrudApi.Data.Abstract;
using CrudApi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudApi.Data.Concrate
{
    public class HotelRepo : IHotelRepository
    {
        public List<Hotel> GetAll()
        {
            using (var context = new HotelContext())
            {
                return context.Hotels.ToList();
            }
        }

        public Hotel GetById(int id)
        {
            using (var context = new HotelContext())
            {
                return context.Hotels.FirstOrDefault(h => h.Id == id);
            }
        }

        public void Create(Hotel hotel)
        {
            using (var context = new HotelContext())
            {
                var temp = new Hotel
                {
                    Name = hotel.Name,
                    City = hotel.City
                };
                context.Hotels.Add(temp);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new HotelContext())
            {
                var hotel = GetById(id);
                context.Hotels.Remove(hotel);
                context.SaveChanges();
            }
        }

        public Hotel Update(Hotel hotel)
        {
            using (var context = new HotelContext())
            {
                context.Hotels.Update(hotel);
                context.SaveChanges();
                return hotel;
            }
        }
    }
}
