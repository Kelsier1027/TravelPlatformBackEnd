using DTO;
using EFModel;
using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EFModel
{
	public class EnergyTypeEFRepository : IEnergyTypeRepository
	{
		public IEnumerable<EnergyTypeDto> Search()
		{
			return new AppDbContext().EnergyTypes.AsNoTracking().Select(x => new EnergyTypeDto { Id = x.Id, Name = x.Name }).ToList();
		}
	}
}
