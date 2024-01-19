using Criteria;
using DTO;
using EFModel;
using Entity;
using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Exts.EFModelExts;
using Utilities.Exts.EntityExts;

namespace DAL.EFModel
{
	public class CarModelImageEFRepository : ICarModelImageRepository
	{
		public int Create(CarModelImageEntity entity)
		{
			var db = new AppDbContext();

			var eFModel = entity.ToEFModel();

			db.CarModelImages.Add(eFModel);

			db.SaveChanges();

			return eFModel.Id;
		}

		public void Delete(int id)
		{
			var db = new AppDbContext();

			var eFModel = db.CarModelImages.Find(id);

			db.CarModelImages.Remove(eFModel);

			db.SaveChanges();
		}

		public CarModelImageDto Get(int id)
		{
			return new AppDbContext().CarModelImages.Find(id).ToDto();
		}

		public IEnumerable<CarModelImageDto> Search(CarModelImageCriteria criteria)
		{
			return new AppDbContext().CarModelImages.AsNoTracking()
													.WhereCarModelId(criteria.CarModelId)
													.WhereName(criteria.Name)
													.Select(x => new CarModelImageDto
													{
														Id = x.Id,
														Name = x.Name,
														CarModelId = x.CarModelId
													}).ToList();
		}
	}
}
