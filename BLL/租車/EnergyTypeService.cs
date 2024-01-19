using DTO;
using IBLL;
using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
	public class EnergyTypeService : IEnergyTypeService, ISelectListService
	{
		private IEnergyTypeRepository _repo;

        public EnergyTypeService(IEnergyTypeRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<ISelectListItem> SearchAll()
		{
			return _repo.Search();
		}
	}
}
