using EFModel;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Exts.EntityExts
{
	public static class CarModelEntityExts
	{
		public static CarModel ToEFModel(this CarModelEntity entity)
		{
			return new CarModel
			{
				Id = entity.Id,
				Name = entity.Name,
				BrandId = entity.BrandId,
				TransmissionId = entity.TransmissionId,
				EnergyTypeId = entity.EnergyTypeId,
				Seats = entity.Seats,
				FeePerDay = entity.FeePerDay,
				MainImage = entity.MainImage,
				MaintenanceMileage = entity.MaintenanceMileage
			};
		}
	}
}
