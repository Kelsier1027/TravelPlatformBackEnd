using Criteria;
using DTO;
using EFModel;
using Entity;
using IDAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Exts.EFModelExts;
using Utilities.Exts.EntityExts;

namespace DAL.EFModel
{
	public class CarModelEFRepository : ICarModelRepository
	{
		public int Create(CarModelEntity entity)
		{
			var db = new AppDbContext();

			var eFModel = entity.ToEFModel();

			db.CarModels.Add(eFModel);

			db.SaveChanges();

			return eFModel.Id;
		}

		public void Delete(int id)
		{
			var db = new AppDbContext();

			var eFModel = db.CarModels.Find(id);

			db.CarModels.Remove(eFModel);

			db.SaveChanges();
		}

		public CarModelDto Get(int id)
		{
			return new AppDbContext().CarModels.Find(id).ToDto();
		}

		public IEnumerable<CarModelDto> Search(CarModelCriteria criteria)
		{
			return new AppDbContext().CarModels.AsNoTracking()
											   .Include(x => x.Brand)
											   .Include(x => x.EnergyType)
											   .Include(x => x.Transmission)
											   .Include(x => x.CarModelImages)
											   .WhereBrandId(criteria.BrandId)
											   .WhereName(criteria.Name)
											   .Select(x => new CarModelDto
											   {
												   Id = x.Id,
												   Name = x.Name,
												   BrandId = x.BrandId,
												   TransmissionId = x.TransmissionId,
												   EnergyTypeId = x.EnergyTypeId,
												   Seats = x.Seats,
												   FeePerDay = x.FeePerDay,
												   MainImage = x.MainImage,
												   MaintenanceMileage = x.MaintenanceMileage,
												   Brand = new BrandDto
												   {
													   Id = x.Brand.Id,
													   Name = x.Brand.Name,
												   },
												   Transmission = new TransmissionDto
												   {
													   Id = x.Transmission.Id,
													   Name = x.Transmission.Name,
												   },
												   EnergyType = new EnergyTypeDto
												   {
													   Id = x.EnergyType.Id,
													   Name = x.EnergyType.Name,
												   },
												   CarModelImages = x.CarModelImages.Select(carModelImage => new CarModelImageDto
												   {
													   Id = carModelImage.Id,
													   Name = carModelImage.Name,
													   CarModelId = carModelImage.CarModelId
												   })
											   }).ToList();
		}

		public void Update(CarModelEntity entity)
		{
			var db = new AppDbContext();
			// todo修改
			var eFModel = db.CarModels.Find(entity.Id);

			eFModel.Name = entity.Name;

			eFModel.BrandId = entity.BrandId;

			eFModel.TransmissionId = entity.TransmissionId;

			eFModel.EnergyTypeId = entity.EnergyTypeId;

			eFModel.Seats = entity.Seats;

			eFModel.FeePerDay = entity.FeePerDay;

			eFModel.MainImage = entity.MainImage;

			eFModel.MaintenanceMileage = entity.MaintenanceMileage;

			db.SaveChanges();
		}
	}
}
