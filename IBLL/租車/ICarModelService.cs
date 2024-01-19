using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace IBLL
{
	public interface ICarModelService
	{
		IEnumerable<CarModelDto> SearchAll();

		void Create(CarModelDto dto, string path, HttpPostedFileBase image, params HttpPostedFileBase[] images);

		CarModelDto GetById(int id);

		void Delete(int id, string path);

		void SetMainImage(int carModelId, int carModelImageId);
	}
}
