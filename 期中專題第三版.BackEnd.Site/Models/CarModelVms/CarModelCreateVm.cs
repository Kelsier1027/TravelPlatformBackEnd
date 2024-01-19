using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace 期中專題第三版.BackEnd.Site.Models.CarModelVms
{
	public class CarModelCreateVm
	{
		public int Id { get; set; }

		[Display(Name = "車款名稱")]
		public string Name { get; set; }

		[Display(Name = "廠牌")]
		public int BrandId { get; set; }

		[Display(Name = "排檔")]
		public int TransmissionId { get; set; }

		[Display(Name = "能源")]
		public int EnergyTypeId { get; set; }

		[Display(Name = "最大乘車人數")]
		public int Seats { get; set; }

		[Display(Name = "每日租金")]
		public int FeePerDay { get; set; }

		[Display(Name = "主要照片")]
		public string MainImage { get; set; }

		[Display(Name = "其他照片")]
		public string CarModelImages { get; set; }

		[Display(Name = "保養里程數")]
		public int MaintenanceMileage { get; set; }
	}
}