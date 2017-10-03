using UnityEngine;

namespace Exodrifter.Anchor
{
	/// <summary>
	/// Used to produce and manage many GameObjects and their associated active 
	/// states.
	/// </summary>
	public class PrefabPool : Pool<GameObject>
	{
		public PrefabPool(PrefabFactory factory)
			: base(factory)
		{
		}

		public PrefabPool(GameObject prefab, string owner)
			: base(new PrefabFactory(prefab, owner))
		{
		}

		public PrefabPool(GameObject prefab, GameObject owner)
			: base(new PrefabFactory(prefab, owner))
		{
		}

		/// <summary>
		/// Spawns a new GameObject and returns a component from it.
		/// </summary>
		/// <typeparam name="T">
		/// The type of the component to get.
		/// </typeparam>
		/// <param name="searchChildren">Whether or not to search children.</param>
		/// <returns>The component on the spawned GameObject.</returns>
		public T Spawn<T>(bool searchChildren = false)
		{
			return searchChildren
				? Spawn().GetComponent<T>()
				: Spawn().GetComponentInChildren<T>();
		}

		public override void Despawn(GameObject item)
		{
			base.Despawn(item);

			if (!Util.IsNull(item))
			{
				item.SetActive(false);
			}
		}

		public override void DespawnAll()
		{
			base.DespawnAll();

			foreach (var item in pooled)
			{
				item.SetActive(false);
			}
		}

		public override GameObject Spawn()
		{
			var ret = base.Spawn();
			ret.SetActive(true);
			return ret;
		}

		/// <summary>
		/// Deletes all GameObjects managed by this pool.
		/// </summary>
		public void Destroy()
		{
			((PrefabFactory)factory).Destroy();
		}
	}
}
