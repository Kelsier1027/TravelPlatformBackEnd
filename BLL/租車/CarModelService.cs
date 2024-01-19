using Criteria;
using DTO;
using IBLL;
using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Utilities.Exts.DtoExts;
using Utilities.FileHelper;
using Utilities.FileHelper.RenameProviders;

namespace BLL
{
	public class CarModelService : ICarModelService
	{
		private ICarModelRepository _repo;

		private ICarModelImageService _carModelImageService;

		private readonly FileHelper _fileHelper;

		public CarModelService(ICarModelRepository repo, ICarModelImageService carModelImageService)
		{
			_repo = repo;

			_carModelImageService = carModelImageService;

			_fileHelper = new FileHelper(new GuidRenameProvider(), null);
		}

        public void Create(CarModelDto dto, string path, HttpPostedFileBase image, params HttpPostedFileBase[] images)
		{
			try
			{
				if (image != null)
				{
					var mainImage = SaveImages(path, image).SingleOrDefault();

					dto.MainImage = mainImage;
				}

				int id = _repo.Create(dto.ToEntity());

				if (images != null)
				{
					_carModelImageService.Create(path, id, images);
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public void Delete(int id, string path)
		{
			DeleteImages(id, path);

			_repo.Delete(id);
		}

		public CarModelDto GetById(int id)
		{
			return _repo.Get(id);
		}

		public IEnumerable<CarModelDto> SearchAll()
		{
			return _repo.Search(new CarModelCriteria());
		}

		public void SetMainImage(int carModelId, int carModelImageId)
		{
			var dto = _repo.Get(carModelImageId);

			dto.MainImage = _carModelImageService.GetById(carModelImageId).Name;

			_repo.Update(dto.ToEntity());
		}

		private void DeleteImages(int carModelId, string path)
		{
			var imagesToDelete = _carModelImageService.SearchByCarModelId(carModelId);

			_fileHelper.Delete(path, imagesToDelete.Select(x => x.Name).ToArray());
		}

		private IEnumerable<string> SaveImages(string path, params HttpPostedFileBase[] images)
		{
			return _fileHelper.Save(path, images);
		}
	}
}
