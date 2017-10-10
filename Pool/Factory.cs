using System;
using UnityEngine;

namespace Exodrifter.Anchor
{
	[Serializable]
	public class Factory
	{
		[SerializeField]
		private GameObject prefab;
		[SerializeField]
		private Transform parent;

		/// <summary>
		/// Instantiates a new GameObject.
		/// </summary>
		/// <returns>A new GameObject.</returns>
		public GameObject Instantiate()
		{
			GameObject go;
			if (Util.IsNull(prefab))
			{
				go = new GameObject();
			}
			else
			{
				go = UnityEngine.Object.Instantiate(prefab);
			}

			go.transform.SetParent(parent, false);
			return go;
		}

		/// <summary>
		/// Instantiates a new GameObject and returns a component of the specified
		/// type from the prefab.
		/// </summary>
		/// <typeparam name="T">The type of component to return.</typeparam>
		/// <param name="searchChildren">Whether or not to search children.</param>
		/// <returns>The component on the new GameObject.</returns>
		public T Instantiate<T>(bool searchChildren = false)
		{
			return searchChildren
				? Instantiate().GetComponent<T>()
				: Instantiate().GetComponentInChildren<T>();
		}
	}
}
