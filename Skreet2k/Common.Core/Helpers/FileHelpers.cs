using System.IO;
using System.Linq;

namespace S2k.Common.Core.Helpers
{
	public static class FileHelpers
	{
		public static string GetValidFileName(string fileName, string replace = "")
		{
			var invalidFileParts = Path.GetInvalidFileNameChars().Select(x => x.ToString());

			return invalidFileParts.Aggregate(fileName, (current, charInvalid) => current.Replace(charInvalid, replace));
		}
	}
}