using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.FileHelper.RenameProviders
{
	public interface IRenameProvider
	{
		string Rename(string oldName, string newName = null);
	}
}
