using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace 期中專題第三版.BackEnd.Site.Models.CarModelVms
{
	public class CarModelIndexVm
	{
		public int Id { get; set; }

		[Display(Name = "車款")]
		public string Name { get; set; }

		[Display(Name = "廠牌")]
		public string Brand { get; set; }

		[Display(Name = "")]
		public string MainImage { get; set; }
	}
}