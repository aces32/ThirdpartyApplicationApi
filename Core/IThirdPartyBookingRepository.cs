using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThirdPartyBookingApi.Entites;

namespace ThirdPartyBookingApi.Core
{
    public interface IThirdPartyBookingRepository
    {
        List<VehicleMakeInformation> ValidateVehicleMake(string vehicleMake);
        List<VehicleModelInformation> ValidateVehicleModel(string vehicleModel);
        void InsertThirdPartyRequest(ThirdPartyApplication thirdPartyApplication);
        int Commit();
    }
}
