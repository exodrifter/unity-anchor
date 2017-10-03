namespace Exodrifter.Anchor
{
	public static class Util
	{
		/// <summary>
		/// Returns true if the object is null or destroyed.
		/// </summary>
		/// <returns>
		/// <c>true</c> if the specified obj is null or destroyed.
		/// </returns>
		/// <param name="obj">The object to check.</param>
		public static bool IsNull(object obj)
		{
			return obj == null || obj.Equals(null);
		}

		/// <summary>
		/// Returns the hash for multiple objects.
		/// </summary>
		/// <returns>The hash for multiple objects.</returns>
		/// <param name="args">The objects to hash.</param>
		public static int GetHash(params object[] args)
		{
			unchecked
			{
				int hash = 17;
				foreach (var arg in args)
				{
					hash *= 23;
					if (!IsNull(arg))
					{
						hash += arg.GetHashCode();
					}
				}
				return hash;
			}
		}
	}
}
