using ApiCrud.Business.Abstract;
using ApiCrud.Business.Concrate;
using CrudApi.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private IHotelService _hotelService;
        public HotelController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }
        //public HotelController()
        //{
        //    _hotelService = new HotelManager();
        //}



        /// <summary>
        /// Get All Data
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        public IActionResult Get()
        {
            return Ok(_hotelService.GetAll());
        }


        [HttpGet]
        [Route("[action]/{id}")]
        public IActionResult GetById(int id)
        {
            var hotel = _hotelService.GetById(id);
            if (hotel != null)
                return Ok(_hotelService.GetById(id));
            return NotFound();
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Create(Hotel hotel)
        {
            _hotelService.Create(hotel);
            return CreatedAtAction("Get", new { id = hotel.Id });
        }

        [HttpPut]
        [Route("[action]/{id}")]
        public IActionResult Update([FromBody] Hotel hotel)
        {
            if (_hotelService.GetById(hotel.Id) != null)
                return Ok(_hotelService.Update(hotel));
            return NotFound();
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public IActionResult Delete(int id)
        {
            var hotel = _hotelService.GetById(id);
            if (hotel != null)
            {
                _hotelService.Delete(id);
                return Ok();
            }
            return BadRequest();
        }
    }
}
