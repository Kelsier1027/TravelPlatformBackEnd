using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Utilities.FileHelper.UploadValidators
{
	public class RequiredValidator : IUploadValidator
	{
		public void CheckValid(HttpPostedFileBase file)
		{
			if (file == null || file.ContentLength < 0) throw new Exception(Consts.FileRequiredExMessage);
		}
	}
}
