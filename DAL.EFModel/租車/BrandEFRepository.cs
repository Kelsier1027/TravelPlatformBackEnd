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
	public class BrandEFRepository : IBrandRepository
	{
		public IEnumerable<BrandDto> Search()
		{
			return new AppDbContext().Brands.AsNoTracking().Select(x => new BrandDto { Id = x.Id, Name = x.Name }).ToList();
		}
	}
}
