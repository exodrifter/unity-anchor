using System.Collections.Generic;
using UnityEngine;

namespace Exodrifter.Anchor
{
	public static class SoundbankUtil
	{
		private static GameObject parent;
		private static Dictionary<Soundbank, Pool> pools;

		private static void Init()
		{
			parent = new GameObject("Sound Bank Util");
			parent.hideFlags = HideFlags.HideAndDontSave;

			pools = pools ?? new Dictionary<Soundbank, Pool>();
		}

		private static Pool GetPool(Soundbank bank)
		{
			if (pools.ContainsKey(bank))
			{
				return pools[bank];
			}
			else
			{
				pools[bank] = new Pool();
				pools[bank].Factory.Parent = parent.transform;

				return pools[bank];
			}
		}

		private static void UpdatePools()
		{
			// Despawned finished sources
			foreach (var pool in pools.Values)
			{
				foreach (var item in pool.Spawned)
				{
					if (!item.GetComponent<AudioSource>().isPlaying)
					{
						pool.Despawn(item);
					}
				}
			}

			// Remove old pools
			var toRemove = new List<Soundbank>();
			foreach (var pool in pools.Keys)
			{
				if (pools[pool].SpawnedCount == 0)
				{
					toRemove.Add(pool);
				}
			}

			foreach (var pool in toRemove)
			{
				pools.Remove(pool);
			}
		}

		public static void PlayOneShot(Soundbank bank)
		{
			Init();
			UpdatePools();

			var pool = GetPool(bank);

			// Check max voices
			if (bank.MaxVoices > 0)
			{
				while (pool.SpawnedCount >= bank.MaxVoices)
				{
					pool.DespawnOldest();
				}
			}

			var go = pool.Spawn();
			var source = go.GetComponent<AudioSource>();
			if (Util.IsNull(source))
			{
				source = go.AddComponent<AudioSource>();
				source.playOnAwake = false;
				source.spatialBlend = 0;
				source.gameObject.hideFlags = HideFlags.HideAndDontSave;
			}

			var vol = bank.DefaultVolume;
			source.volume = Random.Range(vol - 0.2f, vol);
			source.pitch = Random.Range(0.9f, 1.1f);
			source.clip = bank.GetRandomClip();
			source.Play();
		}
	}
}
