using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservation.API.Infrastructure;
using Reservation.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reservation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResController : ControllerBase
    {
        private readonly IReservationService reservationService;
        public ResController(IReservationService _reservationService)
        {
            reservationService = _reservationService;
        }

        [HttpGet("{Id}")]
        public ReservationDTO Get(int Id)
        {
            return reservationService.GetResByBkgNumber(Id);
        }

    }
}
