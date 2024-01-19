using DTO;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Exts.DtoExts
{
	public static class CarModelDtoExts
	{
		public static CarModelEntity ToEntity(this CarModelDto carModelDto)
		{
			return new CarModelEntity()
			{
				Id = carModelDto.Id,
				Name = carModelDto.Name,
				BrandId = carModelDto.BrandId,
				TransmissionId = carModelDto.TransmissionId,
				EnergyTypeId = carModelDto.EnergyTypeId,
				Seats = carModelDto.Seats,
				FeePerDay = carModelDto.FeePerDay,
				MainImage = carModelDto.MainImage,
				MaintenanceMileage = carModelDto.MaintenanceMileage
			};
		}
	}
}
