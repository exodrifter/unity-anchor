#if UNITY_EDITOR_WIN
#define WINDOWS
#elif UNITY_EDITOR_OSX
#define OSX
#elif UNITY_EDITOR_LINUX
#define LINUX
#elif UNITY_STANDALONE_WIN
#define WINDOWS
#elif UNITY_STANDALONE_OSX
#define OSX
#elif UNITY_STANDALONE_LINUX
#define LINUX
#endif
using UnityEngine;

#if WINDOWS
using XInputDotNetPure;
using XButtonState = XInputDotNetPure.ButtonState;
#endif

namespace Exodrifter.Anchor
{
	public class ControllerHelper : MonoBehaviour
	{
		public ControllerState[] States
		{
			get { return states; }
		}
		private ControllerState[] states;

		private void Awake()
		{
			states = new ControllerState[4];
			for (int i = 0; i < states.Length; ++i)
			{
				states[i] = new ControllerState();
			}
		}

#if WINDOWS

		private void Update()
		{
			for (int i = 0; i < 4; ++i)
			{
				var index = (PlayerIndex)i;
				var state = GamePad.GetState(index);
				if (!state.IsConnected)
				{
					continue;
				}

				states[i].connected = true;

				SetButtonState(i, ButtonCode.ButtonA, state.Buttons.A);
				SetButtonState(i, ButtonCode.ButtonB, state.Buttons.B);
				SetButtonState(i, ButtonCode.ButtonX, state.Buttons.X);
				SetButtonState(i, ButtonCode.ButtonY, state.Buttons.Y);

				SetAxisButtonState(i, ButtonCode.LeftAnalogLeft, state.ThumbSticks.Left.X, true);
				SetAxisButtonState(i, ButtonCode.LeftAnalogRight, state.ThumbSticks.Left.X, false);
				SetAxisButtonState(i, ButtonCode.LeftAnalogUp, state.ThumbSticks.Left.Y, false);
				SetAxisButtonState(i, ButtonCode.LeftAnalogDown, state.ThumbSticks.Left.Y, true);

				SetAxisState(i, AxisCode.LeftAnalogX, state.ThumbSticks.Left.X);
				SetAxisState(i, AxisCode.LeftAnalogY, state.ThumbSticks.Left.Y);

				SetAxisState(i, AxisCode.Trigger, state.Triggers.Right - state.Triggers.Left);
				SetAxisState(i, AxisCode.TriggerLeft, state.Triggers.Left);
				SetAxisState(i, AxisCode.TriggerRight, state.Triggers.Right);
			}
		}

		#region Util

		private void SetAxisState(int index, AxisCode code, float value)
		{
			states[index].axis[code] = value;
		}

		private void SetAxisButtonState(int index, ButtonCode code, float value, bool negative)
		{
			if (negative ^ value < 0)
			{
				SetButtonState(index, code, XButtonState.Released);
				return;
			}

			value = Mathf.Abs(value);
			if (value > 0.9f)
			{
				SetButtonState(index, code, XButtonState.Pressed);
			}
			else
			{
				SetButtonState(index, code, XButtonState.Released);
			}
		}

		private void SetButtonState
			(int index, ButtonCode code, XButtonState state)
		{
			switch (state)
			{
				case XButtonState.Pressed:
					if (states[index].buttons[code] == ButtonState.Off)
					{
						states[index].buttons[code] = ButtonState.Down;
					}
					else
					{
						states[index].buttons[code] = ButtonState.On;
					}
					break;
				case XButtonState.Released:
					if (states[index].buttons[code] == ButtonState.On)
					{
						states[index].buttons[code] = ButtonState.Up;
					}
					else
					{
						states[index].buttons[code] = ButtonState.Off;
					}
					break;
			}
		}

		#endregion

#endif

		#region Static

		public static ControllerHelper Instance
		{
			get { return instance; }
		}
		private static ControllerHelper instance;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void Initialize()
		{
			var go = new GameObject("Controller Helper");
			go.hideFlags = HideFlags.HideAndDontSave;
			instance = go.AddComponent<ControllerHelper>();

			DontDestroyOnLoad(go);
		}

		#endregion
	}
}