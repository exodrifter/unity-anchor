using System;
using System.Collections.Generic;

namespace Exodrifter.Anchor
{
	public class ControllerState
	{
		public bool connected;
		public Dictionary<ButtonCode, ButtonState> buttons;
		public Dictionary<AxisCode, float> axis;

		public ControllerState()
		{
			connected = false;
			buttons = new Dictionary<ButtonCode, ButtonState>();
			axis = new Dictionary<AxisCode, float>();

			foreach (var code in Enum.GetValues(typeof(ButtonCode)))
			{
				buttons[(ButtonCode)code] = ButtonState.Off;
			}
			foreach (var code in Enum.GetValues(typeof(AxisCode)))
			{
				axis[(AxisCode)code] = 0;
			}
		}
	}

	public enum ButtonCode
	{
		ButtonA,
		ButtonB,
		ButtonX,
		ButtonY,
		LeftAnalogLeft,
		LeftAnalogRight,
		LeftAnalogUp,
		LeftAnalogDown,
	}

	public enum AxisCode
	{
		LeftAnalogX,
		LeftAnalogY,
		Trigger,
		TriggerLeft,
		TriggerRight,
	}

	public enum ButtonState
	{
		Off, Down, On, Up
	}

	public enum PlayerCode
	{
		Any = -1,
		P1 = 0,
		P2 = 1,
		P3 = 2,
		P4 = 3,
	}
}
