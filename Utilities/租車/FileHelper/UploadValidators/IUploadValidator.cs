using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Utilities.FileHelper.UploadValidators
{
	public interface IUploadValidator
	{
		void CheckValid(HttpPostedFileBase file);
	}
}
