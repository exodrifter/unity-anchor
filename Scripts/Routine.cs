using System;
using UnityEngine;

namespace Exodrifter.Anchor
{
	/// <summary>
	/// A routine is a coroutine that cannot be cancelled due to the destruction
	/// of the GameObject that started it.
	///
	/// Due to how this is implemented, <see cref="Routine"/> does not receive
	/// any messages from the GameObject that started it. This means
	/// <see cref="MonoBehaviour.StopAllCoroutines"/> and other similar methods
	/// won't stop <see cref="Routine"/>. Instead, <see cref="Cancel"/>
	/// must be used.
	/// </summary>
	public class Routine
	{
		private GameObject go;

		private Routine(GameObject go)
		{
			this.go = go;
		}

		public void Cancel()
		{
			if (!Util.IsNull(go))
			{
				GameObject.Destroy(go);
			}
		}

		public static Routine Start(float seconds, Action<float> action, Action onFinish = null)
		{
			var gameObject = new GameObject("Routine");
			gameObject.hideFlags = HideFlags.HideAndDontSave;

			var helper = gameObject.AddComponent<Helper>();
			helper.action = action;
			helper.onFinish = onFinish;
			helper.seconds = seconds;

			return new Routine(gameObject);
		}

		private class Helper : MonoBehaviour
		{
			public Action<float> action;
			public Action onFinish;
			public float seconds;
			public float elapsed = 0;

			private void Start()
			{
				action(0);
			}

			private void Update()
			{
				try
				{
					elapsed += Time.deltaTime;

					if (elapsed < seconds)
					{
						var t = elapsed / seconds;
						action?.Invoke(t);
					}
					else
					{
						action(1);
						onFinish?.Invoke();
						Destroy(gameObject);
					}
				}
				catch (Exception e)
				{
					// An uncaught exception does not stop Unity to stop
					// execution. Instead, Unity will run this method again,
					// which is undesirable since that can result in invoking
					// `action(1)` repeatedly when it is expected to happen
					// exactly once.
					Debug.LogError(
						"Aborting routine due to " + e
					);
					Destroy(gameObject);
				}
			}
		}
	}
}
