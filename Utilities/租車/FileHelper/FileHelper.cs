using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Utilities.FileHelper.RenameProviders;
using Utilities.FileHelper.UploadValidators;

namespace Utilities.FileHelper
{
	public class FileHelper
	{
		private IRenameProvider _renameProvider;

		private IUploadValidator[] _uploadValidators;

		public FileHelper(IRenameProvider renameProvider, params IUploadValidator[] validators)
		{
			_renameProvider = renameProvider;

			_uploadValidators = validators;
		}

		public IEnumerable<string> Save(string path, params HttpPostedFileBase[] files)
		{
			foreach (var file in files)
			{
				IsValid(file);
			}

			foreach (var file in files)
			{
				string newName = _renameProvider.Rename(file.FileName);

				string fullPath = Path.Combine(path, newName);

				file.SaveAs(fullPath);

				yield return newName;
			}
		}

		public void Delete(string path, params string[] fileNames)
		{
			foreach (var fileName in fileNames)
			{
				var fullName = Path.Combine(path, fileName);

				if (File.Exists(fullName)) File.Delete(fullName);
			}
		}

		private void IsValid(HttpPostedFileBase file)
		{
			if (_uploadValidators == null) return;

			foreach (var item in _uploadValidators)
			{
				item.CheckValid(file);
			}
		}
	}
}
