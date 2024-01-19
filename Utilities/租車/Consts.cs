using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
	public static class Consts
	{
		public const string FileRequiredExMessage = "請上傳檔案";

		public const string FileExtensionExMessage = "請上傳以\".jpg\", \".jpeg\", \".png\", \".gif\"為副檔名之檔案";

		public const int FileMaxSize = 1024 * 1024;

		public const string FileSizeExMessage = "檔案大小請勿超過1MB";

		public const string CarModelImagesFolderPath = "~/CarModelImages";
	}
}
