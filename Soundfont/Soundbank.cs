using System.Collections.Generic;
using UnityEngine;

namespace Exodrifter.Anchor
{
	[CreateAssetMenu(fileName = "New Soundbank", menuName = "Anchor/Soundbank")]
	public class Soundbank : ScriptableObject
	{
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
	}
}
