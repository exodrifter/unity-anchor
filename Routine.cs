using System;
using System.Collections;
using UnityEngine;

namespace Exodrifter.Anchor
{
	public class Routine
	{
		private GameObject go;
		private Helper helper;

		private Routine(GameObject go, Helper helper)
		{
			this.go = go;
			this.helper = helper;
		}

		public IEnumerator AsIEnumerator()
		{
			while (!Util.IsNull(go) && helper.elapsed < helper.seconds)
			{
				yield return null;
			}
		}

		public void Cancel()
		{
			if (!Util.IsNull(go))
			{
				GameObject.Destroy(go);
			}
		}

		public static IEnumerator IEnumerator(float seconds, Action<float> action)
		{
			return Start(seconds, action).AsIEnumerator();
		}

		public static Routine Start(float seconds, Action<float> action)
		{
			var gameObject = new GameObject("Routine");
			gameObject.hideFlags = HideFlags.HideAndDontSave;

			var helper = gameObject.AddComponent<Helper>();
			helper.action = action;
			helper.seconds = seconds;

			return new Routine(gameObject, helper);
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
