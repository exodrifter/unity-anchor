using System.IO;

namespace Exodrifter.Anchor
{
	/// <summary>
	/// Provides file operations.
	/// </summary>
	public static class Cargo
	{
		/// <summary>
		/// Creates a new zip file containing the target directory or file. If
		/// the zip file already exists, the target is added to the zip.
		/// </summary>
		/// <param name="path">The directory or file to zip.</param>
		/// <param name="destination">The zip file location.</param>
		public static void Zip(string path, string destination)
		{
			using (var zip = ZipStorer.Create(destination))
			{
				var compression = ZipStorer.Compression.Deflate;
				var attr = File.GetAttributes(path) & FileAttributes.Directory;
				if (attr == FileAttributes.Directory)
				{
					var name = Path.GetDirectoryName(path);
					zip.AddDirectory(compression, path, name);
				}
				else
				{
					var name = Path.GetFileName(path);
					zip.AddFile(compression, path, name);
				}
			}
		}
	}
}
