using Newtonsoft.Json;
using UnityEngine;

namespace Exodrifter.Anchor
{
	/// <summary>
	/// Provides operations for converting objects into file data.
	/// </summary>
	public static class Export
	{
		/// <summary>
		/// Returns the JSON string for the passed object.
		/// </summary>
		/// <param name="obj">The object to serialize.</param>
		/// <param name="prettyPrint">True, if json should be formatted.</param>
		/// <returns>The JSON string for the passed object.</returns>
		public static string Json(object obj, bool prettyPrint = false)
		{
			var format = prettyPrint ? Formatting.Indented : Formatting.None;
			var settings = new JsonSerializerSettings();
			settings.TypeNameHandling = TypeNameHandling.All;

			return JsonConvert.SerializeObject(obj, format, settings);
		}

		/// <summary>
		/// Returns the OBJ string for the passed object.
		/// </summary>
		/// <param name="mesh">The mesh to serialize.</param>
		/// <returns>The OBJ string for the passed mesh.</returns>
		public static string Obj(Mesh mesh)
		{
			return ObjHelper.ExportObj(mesh);
		}
	}
}
