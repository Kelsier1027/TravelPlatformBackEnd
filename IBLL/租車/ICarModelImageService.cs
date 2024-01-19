using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace IBLL
{
	public interface ICarModelImageService
	{
		void Create(string path, int carModelId, params HttpPostedFileBase[] files);

		IEnumerable<CarModelImageDto> SearchByCarModelId(int carModelId);

		CarModelImageDto GetById(int id);

		void DeleteById(int id);
	}
}
