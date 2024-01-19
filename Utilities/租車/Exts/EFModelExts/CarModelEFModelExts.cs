using DTO;
using EFModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Utilities.Exts.EFModelExts
{
	public static class CarModelEFModelExts
	{
		public static IEnumerable<CarModel> WhereBrandId(this IEnumerable<CarModel> models, int id)
		{
			return id == 0 ? models : models.Where(x => x.BrandId == id);
		}

		public static IEnumerable<CarModel> WhereName(this IEnumerable<CarModel> models, string name)
		{
			return name == null ? models : models.Where(x => x.Name == name);
		}

		public static CarModelDto ToDto(this CarModel model)
		{
			return new CarModelDto
			{
				Id = model.Id,
				Name = model.Name,
				BrandId = model.BrandId,
				TransmissionId = model.TransmissionId,
				EnergyTypeId = model.EnergyTypeId,
				Seats = model.Seats,
				FeePerDay = model.FeePerDay,
				MainImage = model.MainImage,
				MaintenanceMileage = model.MaintenanceMileage,
				Brand = new BrandDto
				{
					Id = model.Brand.Id,
					Name = model.Brand.Name,
				},
				Transmission = new TransmissionDto
				{
					Id = model.Transmission.Id,
					Name = model.Transmission.Name,
				},
				EnergyType = new EnergyTypeDto
				{
					Id = model.EnergyType.Id,
					Name = model.EnergyType.Name,
				},
				CarModelImages = model.CarModelImages.Select(x => new CarModelImageDto
				{
					Id = x.Id,
					Name = x.Name,
					CarModelId = x.CarModelId
				})
			};
		}
	}
}
