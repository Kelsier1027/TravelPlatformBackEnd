using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Utilities.FileHelper.UploadValidators
{
	public class MaxSizeValidator : IUploadValidator
	{
		public void CheckValid(HttpPostedFileBase file)
		{
			if (file.ContentLength > Consts.FileMaxSize) throw new Exception(Consts.FileSizeExMessage);
		}
	}
}
