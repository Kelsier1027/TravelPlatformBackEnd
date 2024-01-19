using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class CarModelDto
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public int BrandId { get; set; }

		public int TransmissionId { get; set; }

		public int EnergyTypeId { get; set; }

		public int Seats { get; set; }

		public int FeePerDay { get; set; }

		public string MainImage { get; set; }

		public int MaintenanceMileage { get; set; }

		public BrandDto Brand { get; set; }

		public TransmissionDto Transmission { get; set; }

		public EnergyTypeDto EnergyType { get; set; }

		public IEnumerable<CarModelImageDto> CarModelImages { get; set; }
	}
}
