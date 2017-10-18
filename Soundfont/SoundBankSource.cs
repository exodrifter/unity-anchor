using System.Collections;
using UnityEngine;

namespace Exodrifter.Anchor
{
	public class SoundBankSource : MonoBehaviour
	{
		[SerializeField]
		private Soundbank bank;

		private Pool pool;

		void Awake()
		{
			pool = new Pool();
			pool.Factory.Parent = transform;
		}

		public void PlayOneShot()
		{
			var go = pool.Spawn();

			var source = go.GetComponent<AudioSource>();
			if (Util.IsNull(source))
			{
				source = go.AddComponent<AudioSource>();
				source.playOnAwake = false;
				source.spatialBlend = 0;
				source.gameObject.hideFlags = HideFlags.HideAndDontSave;
			}

			source.volume = Random.Range(0.8f, 1.0f);
			source.pitch = Random.Range(0.9f, 1.1f);
			source.clip = bank.GetRandomClip();
			source.Play();

			StartCoroutine(Stop(source, source.clip.length + 0.1f));
		}

		private IEnumerator Stop(AudioSource source, float seconds)
		{
			yield return new WaitForSeconds(seconds);
			source.Stop();
			pool.Despawn(source.gameObject);
		}
	}
}
