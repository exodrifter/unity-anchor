using System.Collections.Generic;

namespace Exodrifter.Anchor
{
	/// <summary>
	/// A Pool is used to produce and manage many items of the same type.
	/// </summary>
	public class Pool<T>
	{
		protected readonly IFactory<T> factory;

		protected readonly LinkedList<T> pooled;
		protected readonly LinkedList<T> spawned;

		/// <summary>
		/// Creates a new Pool with the specified Factory.
		/// </summary>
		/// <param name="factory">The factory to use.</param>
		public Pool(IFactory<T> factory)
		{
			this.factory = factory;
			this.pooled = new LinkedList<T>();
			this.spawned = new LinkedList<T>();
		}

		/// <summary>
		/// Spawns an item from the pool.
		/// </summary>
		public virtual T Spawn()
		{
			T item;
			if (pooled.Count > 0)
			{
				item = pooled.First.Value;
				pooled.RemoveFirst();
			}
			else
			{
				item = factory.Instantiate();
			}

			spawned.AddLast(item);
			return item;
		}

		/// <summary>
		/// Despawns an item in the pool.
		/// </summary>
		/// <param name="item">The item to despawn.</param>
		public virtual void Despawn(T item)
		{
			if (spawned.Remove(item))
			{
				pooled.AddLast(item);
			}
		}

		/// <summary>
		/// Despawns all of the items in the pool.
		/// </summary>
		public virtual void DespawnAll()
		{
			while (spawned.Count > 0)
			{
				pooled.AddLast(spawned.First.Value);
				spawned.RemoveFirst();
			}
		}
	}
}
