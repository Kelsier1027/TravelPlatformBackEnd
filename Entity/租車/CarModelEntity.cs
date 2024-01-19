using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
	public class CarModelEntity
	{
		// todo篩選條件 builder

		public int Id { get; set; }

		public string Name { get; set; }

		public int BrandId { get; set; }

		public int TransmissionId { get; set; }

		public int EnergyTypeId { get; set; }

		public int Seats { get; set; }

		public int FeePerDay { get; set; }

		public string MainImage { get; set; }

		public int MaintenanceMileage { get; set; }
	}
}
