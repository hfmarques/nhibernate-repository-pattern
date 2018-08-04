using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NHibernate.Core.Dto;
using NHibernate.Core.Models;
using NHibernate.Data.Persistence.DataContext;
using NHibernate.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NHibernate.Api.Controllers
{
    /// <inheritdoc />
    [Produces("application/json")]
    [Route("api/Hotel")]
    public class HotelController : Controller
    {
        private readonly IMapper _mapper;
        private readonly HotelService _hotelService;

        /// <inheritdoc />
        public HotelController(DataContext session, IMapper mapper)
        {
            _hotelService = new HotelService(session);
            _mapper = mapper;
        }
        // GET: api/Hotel
        /// <summary>
        /// Retorna todos os hoteis cadastrados
        /// </summary>
        /// <remarks>Objeto contendo todos os hoteis</remarks>
        [HttpGet]
        [Produces(typeof(Hotel))]
        public async Task<IActionResult> Get()
        {
            try
            {
                var hotel = await _hotelService.GetAllAsync();


                if (hotel == null || !hotel.Any())
                    return NotFound("Nenhnum Hotel Cadastrado");

                var hotelDto = _mapper.Map<List<HotelDto>>(hotel);

                return Ok(hotelDto);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Retorna o hotel correspondente ao Id
        /// </summary>
        /// <param name="id">Id do hotel</param>
        /// <remarks>Objeto contendo o hotel correspondente ao Id</remarks>
        // GET: api/Hotel/5
        [HttpGet("{id}", Name = "Get")]
        [Produces(typeof(Hotel))]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var hotel = await _hotelService.GetAllAsync();

                if (hotel == null || !hotel.Any())
                    return NotFound("Nenhnum Hotel Cadastrado");

                return Ok(hotel);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // POST: api/Hotel
        /// <summary>
        /// Inseri um novo hotel
        /// </summary>
        /// <param name="value">Hotel a ser inserido</param>
        /// <returns>Retorna o hotel inserido</returns>
        [HttpPost]
        [Produces(typeof(Hotel))]
        public async Task<IActionResult> Post([FromBody]Hotel value)
        {
            try
            {
                var hotel = await _hotelService.AddAsync(value);

                return CreatedAtRoute("Get", new { hotel.Id }, hotel);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //// PUT: api/Hotel/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
