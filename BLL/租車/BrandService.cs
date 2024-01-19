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
	public class BrandService : IBrandService, ISelectListService
	{
		private IBrandRepository _repo;

		public BrandService(IBrandRepository repo)
		{
			_repo = repo;
		}

		public IEnumerable<ISelectListItem> SearchAll()
		{
			return _repo.Search();
		}
	}
}
