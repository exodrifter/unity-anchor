using System.Collections.Generic;
using UnityEngine;

namespace Exodrifter.Anchor
{
	/// <summary>
	/// Converts controller inputs into platform-independent inputs
	/// </summary>
	public static class Controller
	{
		/// <summary>
		/// Returns true if the button is held down.
		/// </summary>
		/// <param name="code">The button code to check.</param>
		/// <returns>True if the button is held down</returns>
		public static bool GetButton
			(ButtonCode code, ControllerCode controller = ControllerCode.Any)
		{
			var keys = Convert(code, controller);
			foreach (var k in keys)
			{
				if (Input.GetKey(k))
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>
		/// Returns true if the button was pressed this frame.
		/// </summary>
		/// <param name="code">The button code to check.</param>
		/// <returns>True if the button is held down</returns>
		public static bool GetButtonDown
			(ButtonCode code, ControllerCode controller = ControllerCode.Any)
		{
			var keys = Convert(code, controller);
			foreach (var k in keys)
			{
				if (Input.GetKeyDown(k))
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>
		/// Returns true if the button was released this frame.
		/// </summary>
		/// <param name="code">The button code to check.</param>
		/// <returns>True if the button is held down</returns>
		public static bool GetButtonUp
			(ButtonCode code, ControllerCode controller = ControllerCode.Any)
		{
			var keys = Convert(code, controller);
			foreach (var k in keys)
			{
				if (Input.GetKeyUp(k))
				{
					return true;
				}
			}
			return false;
		}

		#region Conversion

		private static List<KeyCode> Convert(ButtonCode code, ControllerCode controller)
		{
			var codes = new List<KeyCode>();

			var names = Input.GetJoystickNames();
			for (int i = 0; i < names.Length; ++i)
			{
				if (controller == 0 || (int)controller == (i + 1))
				{
					if (names[i].Contains("XBOX 360"))
					{
						codes.Add(Get(Xbox360.Convert(code), controller));
					}
					else
					{
						Debug.LogWarning(string.Format(
							"Unknown controller name \"{0}\"",
							names[i]
						));
					}
				}
			}
			return codes;
		}

		private static KeyCode Get(int button, ControllerCode controller)
		{
			button = (int)KeyCode.JoystickButton0 + button;
			return (KeyCode)(button + (int)controller * 10);
		}

		#endregion
	}
}
