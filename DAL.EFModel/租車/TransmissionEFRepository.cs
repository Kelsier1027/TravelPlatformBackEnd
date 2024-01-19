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
	public class TransmissionEFRepository : ITransmissionRepository
	{
		public IEnumerable<TransmissionDto> Search()
		{
			return new AppDbContext().Transmissions.AsNoTracking().Select(x => new TransmissionDto { Id = x.Id, Name = x.Name }).ToList();
		}
	}
}
