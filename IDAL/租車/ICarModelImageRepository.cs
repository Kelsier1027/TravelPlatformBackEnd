using Criteria;
using DTO;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
	public interface ICarModelImageRepository
	{
		int Create(CarModelImageEntity entity);

		IEnumerable<CarModelImageDto> Search(CarModelImageCriteria criteria);

		CarModelImageDto Get(int id);

		void Delete(int id);
	}
}
