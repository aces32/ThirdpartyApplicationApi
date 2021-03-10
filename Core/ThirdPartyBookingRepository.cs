using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThirdPartyBookingApi.Entites;

namespace ThirdPartyBookingApi.Core
{
    public class ThirdPartyBookingRepository: IThirdPartyBookingRepository, IDisposable
    {
        private readonly SharpGasContext vehicleContext;
        public ThirdPartyBookingRepository(SharpGasContext vehicleContext)
        {
            this.vehicleContext = vehicleContext;
        }



        public List<VehicleModelInformation> ValidateVehicleModel(string vehicleModel)
        {
            try
            {
                return vehicleContext.VehicleModelInformation.Where(x => x.VehicleModel == vehicleModel).ToList();
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public List<VehicleMakeInformation> ValidateVehicleMake(string vehicleMake)
        {
            try
            {
                return vehicleContext.VehicleMakeInformation.Where(x => x.VehicleMake == vehicleMake).ToList();
            }
            catch (Exception ex)
            {
                return null;

            }

        }

        public void InsertThirdPartyRequest(ThirdPartyApplication thirdPartyApplication)
        {
            vehicleContext.ThirdPartyApplications.Add(thirdPartyApplication);
        }

        public int Commit()
        {
            return vehicleContext.SaveChanges();
        }

        public void Dispose()
        {
            ((IDisposable)vehicleContext).Dispose();
        }
    }
}
