using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Utilities.FileHelper.UploadValidators
{
	public class ExtensionValidator : IUploadValidator
	{
		public void CheckValid(HttpPostedFileBase file)
		{
			var extension = Path.GetExtension(file.FileName);

			// todo
			var imageExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif" };

			if (!imageExtensions.Any(e => e.Equals(extension, StringComparison.OrdinalIgnoreCase)))

				throw new Exception(Consts.FileExtensionExMessage);
		}
	}
}
