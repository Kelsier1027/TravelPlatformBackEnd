using DTO;
using EFModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Exts.EFModelExts
{
	public static class CarModelImageEFModelExts
	{
		public static IEnumerable<CarModelImage> WhereName(this IEnumerable<CarModelImage> carModelImages, string name)
		{
			return name == null ? carModelImages : carModelImages.Where(x => x.Name == name);
		}

		public static IEnumerable<CarModelImage> WhereCarModelId(this IEnumerable<CarModelImage> carModelImages, int id)
		{
			return id == 0 ? carModelImages : carModelImages.Where(x => x.Id == id);
		}

		public static CarModelImageDto ToDto(this CarModelImage model)
		{
			return new CarModelImageDto
			{
				Id = model.Id,
				Name = model.Name,
				CarModelId = model.CarModelId
			};
		}
	}
}
