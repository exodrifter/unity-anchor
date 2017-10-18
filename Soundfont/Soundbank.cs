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
			SoundbankUtil.PlayOneShot(this);
		}
	}
}
