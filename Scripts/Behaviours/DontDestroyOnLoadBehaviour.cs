using UnityEngine;

namespace Exodrifter.Anchor
{
	public class DontDestroyOnLoadBehaviour : MonoBehaviour
	{
		void Awake()
		{
			DontDestroyOnLoad(gameObject);
		}
	}
}