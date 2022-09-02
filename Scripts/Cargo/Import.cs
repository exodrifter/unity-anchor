using Newtonsoft.Json;

namespace Exodrifter.Anchor
{
	/// <summary>
	/// Provides operations for converting file data into objects.
	/// </summary>
	public static class Import
	{
		/// <summary>
		/// Converts a JSON string into an object.
		/// </summary>
		/// <param name="json">The JSON string to convert.</param>
		/// <returns>An object.</returns>
		public static object Json(string json)
		{
			var settings = new JsonSerializerSettings();
			settings.TypeNameHandling = TypeNameHandling.All;

			return JsonConvert.DeserializeObject(json, settings);
		}

		/// <summary>
		/// Converts a JSON string into an object.
		/// </summary>
		/// <typeparam name="T">The type of the object.</typeparam>
		/// <param name="json">The JSON string to convert.</param>
		/// <returns>An object.</returns>
		public static T Json<T>(string json)
		{
			var settings = new JsonSerializerSettings();
			settings.TypeNameHandling = TypeNameHandling.All;

			return JsonConvert.DeserializeObject<T>(json, settings);
		}
	}
}