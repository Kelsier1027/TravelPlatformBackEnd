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
	public interface ICarModelRepository
	{
		IEnumerable<CarModelDto> Search(CarModelCriteria criteria);

		CarModelDto Get(int id);

		int Create(CarModelEntity entity);

		void Delete(int id);

		void Update(CarModelEntity entity);
	}
}
