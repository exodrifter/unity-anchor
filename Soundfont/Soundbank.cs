using System.Collections.Generic;
using UnityEngine;

namespace Exodrifter.Anchor
{
	[CreateAssetMenu(fileName = "New Soundbank", menuName = "Anchor/Soundbank")]
	public class Soundbank : ScriptableObject
	{
		/// <summary>
		/// The maximum number of clips that can play at once. If negative or
		/// zero, an infinite number of clips can play at once.
		/// </summary>
		public int MaxVoices
		{
			get { return maxVoices; }
		}
		[SerializeField, Tooltip("The max number of clips that can play at once.")]
		private int maxVoices = 0;

		/// <summary>
		/// The default maximum volume of the Soundbank.
		/// </summary>
		public float DefaultVolume
		{
			get { return defaultVolume; }
		}
		[SerializeField, Range(0.2f, 1.0f)]
		private float defaultVolume = 1f;

		[SerializeField]
		private List<AudioClip> clips;

		public AudioClip GetRandomClip()
		{
			if (clips == null || clips.Count == 0)
			{
				return null;
			}

			return clips[Random.Range(0, clips.Count)];
		}

		public void PlayOneShot()
		{
			PlayOneShot(this);
		}

		#region Static

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

		/// <summary>
		/// Loads a soundbank from the Resources folder.
		/// </summary>
		/// <param name="path">
		/// The path to the soundbank relative to the resources folder.
		/// </param>
		/// <returns>The soundbank or null if it cannot be found.</returns>
		public static Soundbank Get(string path)
		{
			return Resources.Load<Soundbank>(path);
		}

		#endregion
	}
}
