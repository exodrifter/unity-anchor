using System;
using System.Collections.Generic;
using UnityEngine;

namespace Exodrifter.Anchor
{
	/// <summary>
	/// Used to produce and manage many GameObjects and their associated active 
	/// states.
	/// </summary>
	[Serializable]
	public class Pool
	{
		public Factory Factory
		{
			get { return factory; }
		}
		[SerializeField]
		private Factory factory = new Factory();

		public List<GameObject> Pooled
		{
			get { return new List<GameObject>(pooled); }
		}
		[SerializeField, HideInInspector]
		private List<GameObject> pooled = new List<GameObject>();

		public int PooledCount
		{
			get { return pooled.Count; }
		}

		public List<GameObject> Spawned
		{
			get { return new List<GameObject>(spawned); }
		}
		[SerializeField, HideInInspector]
		private List<GameObject> spawned = new List<GameObject>();

		public int SpawnedCount
		{
			get { return spawned.Count; }
		}

		/// <summary>
		/// Spawns an item from the pool.
		/// </summary>
		public GameObject Spawn()
		{
			CullDestroyed();

			GameObject item;
			if (pooled.Count > 0)
			{
				item = pooled[pooled.Count - 1];
				pooled.RemoveAt(pooled.Count - 1);
			}
			else
			{
				item = factory.Instantiate();
			}

			item.SetActive(true);
			spawned.Add(item);
			return item;
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

		public void Despawn(GameObject item)
		{
			CullDestroyed();

			if (spawned.Remove(item))
			{
				pooled.Add(item);

				if (!Util.IsNull(item))
				{
					item.SetActive(false);
				}
			}
		}

		public void DespawnAll()
		{
			CullDestroyed();

			for (int i = spawned.Count - 1; i >= 0; --i)
			{
				pooled.Add(spawned[i]);
			}
			spawned.Clear();

			foreach (var item in pooled)
			{
				item.SetActive(false);
			}
		}

		public void DespawnOldest()
		{
			CullDestroyed();

			spawned[0].SetActive(false);

			pooled.Add(spawned[0]);
			spawned.RemoveAt(0);
		}

		public void CullDespawned()
		{
			for (int i = pooled.Count - 1; i >= 0; --i)
			{
				var go = pooled[i];
				UnityEngine.Object.Destroy(go);
			}

			pooled.Clear();
		}

		private void CullDestroyed()
		{
			for (int i = spawned.Count - 1; i >= 0; --i)
			{
				if (Util.IsNull(spawned[i]))
				{
					spawned.RemoveAt(i);
				}
			}
			for (int i = pooled.Count - 1; i >= 0; --i)
			{
				if (Util.IsNull(pooled[i]))
				{
					pooled.RemoveAt(i);
				}
			}
		}
	}
}
