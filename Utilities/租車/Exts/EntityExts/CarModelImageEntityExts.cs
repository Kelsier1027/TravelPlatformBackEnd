using EFModel;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Exts.EntityExts
{
	public static class CarModelImageEntityExts
	{
		public static CarModelImage ToEFModel(this CarModelImageEntity entity)
		{
			return new CarModelImage
			{
				Name = entity.Name,
				CarModelId = entity.CarModelId
			};
		}
	}
}
