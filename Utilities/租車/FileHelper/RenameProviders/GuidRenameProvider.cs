using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.FileHelper.RenameProviders
{
	public class GuidRenameProvider : IRenameProvider
	{
		public string Rename(string oldName, string newName = null)
		{
			var extension = Path.GetExtension(oldName);

			return $"{Guid.NewGuid().ToString("N")}{extension}";
		}
	}
}
