using Criteria;
using DTO;
using Entity;
using IBLL;
using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Utilities.FileHelper;
using Utilities.FileHelper.RenameProviders;

namespace BLL
{
	public class CarModelImageService : ICarModelImageService
	{
		private ICarModelImageRepository _repo;

        public CarModelImageService(ICarModelImageRepository repo)
        {
            _repo = repo;
        }
        public void Create(string path, int carModelId, params HttpPostedFileBase[] files)
		{
			try
			{
				var newFileNames = SaveImages(path, files);

				foreach (var fileName in newFileNames)
				{
					var entity = new CarModelImageEntity
					{
						Name = fileName,

						CarModelId = carModelId,
					};

					_repo.Create(entity);
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public void DeleteById(int id)
		{
			_repo.Delete(id);
		}

		public CarModelImageDto GetById(int id)
		{
			return _repo.Get(id);
		}

		public IEnumerable<CarModelImageDto> SearchByCarModelId(int carModelId)
		{
			return _repo.Search(new CarModelImageCriteria { CarModelId = carModelId });
		}

		private IEnumerable<string> SaveImages(string path, params HttpPostedFileBase[] images)
		{
			var helper = new FileHelper(new GuidRenameProvider(), null);

			return helper.Save(path, images);
		}
	}
}
