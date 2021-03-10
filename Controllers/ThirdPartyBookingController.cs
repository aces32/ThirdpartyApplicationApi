using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThirdPartyBookingApi.Core;
using ThirdPartyBookingApi.Entites;
using ThirdPartyBookingApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ThirdPartyBookingApi.Controllers
{
    /// <summary>
    /// An endpoint to submit request for Third party application request
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ThirdPartyBookingController : ControllerBase
    {
        private readonly IThirdPartyBookingRepository thirdPartyBookingRepository;
        private readonly IMapper imapper;

        public ThirdPartyBookingController(IThirdPartyBookingRepository thirdPartyBookingRepository,
            IMapper imapper)
        {
            this.thirdPartyBookingRepository = thirdPartyBookingRepository;
            this.imapper = imapper;
        }
        /// <summary>
        /// An endpoint to submit request for Third party application request
        /// </summary>
        /// <param name="bookingDTO"></param>
        /// <returns></returns>

        [HttpPost]
        public ActionResult<DefaultResponse<List<ThirdPartyApplicationResponse>>> Post([FromBody] BookingDTO bookingDTO)
        {
            try
            {

                var validModel = thirdPartyBookingRepository.ValidateVehicleModel(bookingDTO.VehicleModel.Trim());
                if (validModel == null)
                {

                    return StatusCode(500, new DefaultResponse<List<ThirdPartyApplicationResponse>>
                    {
                         Message = "An error occured verifying vehicle model"
                    });

                }
                else if (validModel.Count == 0)
                {
                    return StatusCode(400, new DefaultResponse<List<ThirdPartyApplicationResponse>>
                    {
                        Message = "Invalid Vehicle model passed"
                    });
                }
                else
                {
                    var validMake =  thirdPartyBookingRepository.ValidateVehicleMake(bookingDTO.VehicleMake.Trim());
                    if (validMake == null)
                    {
                        return StatusCode(500, new DefaultResponse<List<ThirdPartyApplicationResponse>>
                        {
                            Message = "An error occured verifying vehicle make"
                        });
                    }
                    else if (validMake.Count == 0)
                    {
                        return StatusCode(400, new DefaultResponse<List<ThirdPartyApplicationResponse>>
                        {
                            Message = "Invalid vehicle make passed"
                        });
                    }
                    else
                    {
                        thirdPartyBookingRepository.InsertThirdPartyRequest(imapper.Map<ThirdPartyApplication>(bookingDTO));
                        thirdPartyBookingRepository.Commit();

                        return Ok(new DefaultResponse<List<ThirdPartyApplicationResponse>>
                        {
                            Message = "Third party request successfully booked"
                        });
                    }
                }
            }
            catch (Exception)
            {

                return StatusCode(500, new DefaultResponse<List<ThirdPartyApplicationResponse>>
                {
                    Message = "An error please try again later"
                });
            }

        }


    }
}
