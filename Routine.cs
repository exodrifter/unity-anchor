using System;
using UnityEngine;

namespace Exodrifter.Anchor
{
	public static class Routine
	{
		public static void Start(float seconds, Action<float> action)
		{
			var gameObject = new GameObject("Routine");
			gameObject.hideFlags = HideFlags.HideAndDontSave;

			var helper = gameObject.AddComponent<Helper>();
			helper.action = action;
			helper.seconds = seconds;
		}

		private class Helper : MonoBehaviour
		{
			public Action<float> action;
			public float seconds;
			public float elapsed = 0;

			private void Start()
			{
				action(0);
			}

			private void Update()
			{
				elapsed += Time.deltaTime;

				if (elapsed < seconds)
				{
					var t = elapsed / seconds;
					action(t);
				}
				else
				{
					action(1);
					Destroy(gameObject);
				}
			}
		}
	}
}
